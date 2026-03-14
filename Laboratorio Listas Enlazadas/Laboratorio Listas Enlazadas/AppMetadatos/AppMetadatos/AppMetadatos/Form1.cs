using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMetadatos
{
    public partial class Form1 : Form
    {
        ListaImagenes miLista = new ListaImagenes();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (dgvMetadatos.Columns.Count == 0)
            {
                dgvMetadatos.Columns.Add("ColNombre", "Nombre de Archivo");
                dgvMetadatos.Columns.Add("ColFormato", "Formato");
                dgvMetadatos.Columns.Add("ColRes", "Resolución");
            }

            
            dgvMetadatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            buscar.Filter = "Archivos de Imagen|*.jpg;*.png;*.bmp;*.jpeg";

            if (buscar.ShowDialog() == DialogResult.OK)
            {
                
                FileInfo info = new FileInfo(buscar.FileName);
                txtNombre.Text = info.Name;
                txtFormato.Text = info.Extension.ToUpper();

                using (Image img = Image.FromFile(buscar.FileName))
                {
                    txtResolucion.Text = $"{img.Width} x {img.Height}";
                    pbVistaPrevia.Image = (Image)img.Clone(); 
                    pbVistaPrevia.SizeMode = PictureBoxSizeMode.Zoom;

                 
                }
            }
        }

        
        private void ActualizarGrid()
        {
            dgvMetadatos.Rows.Clear();

            var listaParaMostrar = miLista.ToList();

            foreach (var nodo in listaParaMostrar)
            {
                
                if (nodo != null)
                {
                    dgvMetadatos.Rows.Add(nodo.NombreArchivo, nodo.Formato, nodo.Resolucion);
                }
            }
        }

        private void btnAgregarInicio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text)) return;

            miLista.InsertarInicio(txtNombre.Text, txtFormato.Text, txtResolucion.Text);
            ActualizarGrid();

            txtNombre.Clear();
            txtFormato.Clear();
            txtResolucion.Clear();
        }

        private void btnAgregarMedio_Click(object sender, EventArgs e)
        {
            int pos = (int)numPosicion.Value;
            miLista.InsertarMedio(pos, txtNombre.Text, txtFormato.Text, txtResolucion.Text);
            ActualizarGrid();

            txtNombre.Clear();
            txtFormato.Clear();
            txtResolucion.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (miLista.Eliminar(txtNombre.Text))
            {
                MessageBox.Show("Metadato eliminado de la lista.");
                ActualizarGrid();
            }
            else
            {
                MessageBox.Show("No se encontró ese archivo en la lista.");
            }
        }

        private void btnAgregarFinal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Primero selecciona una imagen o escribe su nombre.");
                return;
            }

            
            miLista.InsertarFinal(txtNombre.Text, txtFormato.Text, txtResolucion.Text);

            
            ActualizarGrid();
            
            MessageBox.Show("Imagen agregada al final de la lista.");

            txtNombre.Clear();
            txtFormato.Clear();
            txtResolucion.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreABuscar = txtNombre.Text;

            if (string.IsNullOrEmpty(nombreABuscar))
            {
                MessageBox.Show("Escribe el nombre del archivo que deseas buscar.");
                return;
            }

            
            NodoImagen resultado = miLista.Buscar(nombreABuscar);

            if (resultado != null)
            {
                
                txtFormato.Text = resultado.Formato;
                txtResolucion.Text = resultado.Resolucion;
                MessageBox.Show($"¡Encontrado! Formato: {resultado.Formato}, Resolución: {resultado.Resolucion}");
            }
            else
            {
                MessageBox.Show("Ese archivo no se encuentra en la lista actual.");
            }
        }
    }
    }

