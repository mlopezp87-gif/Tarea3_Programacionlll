using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBiblioteca_ListasEnlazadas
{
    public partial class Form1 : Form
    {
        ListaEnlazada miLista = new ListaEnlazada();
        public Form1()
        {
            InitializeComponent();
            ConfigurarGrid();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ConfigurarGrid()
        {
            dgvLibros.Columns.Add("isbn", "Codigo");
            dgvLibros.Columns.Add("titulo", "Título");
            dgvLibros.Columns.Add("autor", "Autor");
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void ActualizarPantalla()
        {
            dgvLibros.Rows.Clear();
            // Usamos el método ToList() que creamos en la clase ListaEnlazada
            foreach (var nodo in miLista.ToList())
            {
                dgvLibros.Rows.Add(nodo.Isbn, nodo.Titulo, nodo.Autor);
            }
        }

        private void btnInsertarInicio_Click(object sender, EventArgs e)
        {
            miLista.InsertarInicio(txtIsbn.Text, txtTitulo.Text, txtAutor.Text);
            ActualizarPantalla();

            txtAutor.Clear();
            txtIsbn.Clear();
            txtTitulo.Clear();

            if (miLista.ExisteCodigo(txtIsbn.Text))
            {
                MessageBox.Show("Error: El código ya está registrado.");
                return; // Salimos del método sin insertar
            }

            miLista.InsertarInicio(txtIsbn.Text, txtTitulo.Text, txtAutor.Text);
            ActualizarPantalla();

            txtAutor.Clear();
            txtIsbn.Clear();
            txtTitulo.Clear();


        }

        private void btnInsertarMedio_Click(object sender, EventArgs e)
        {
            int pos = (int)txtPosicion.Value;
            miLista.InsertarMedio(pos, txtIsbn.Text, txtTitulo.Text, txtAutor.Text);
            ActualizarPantalla();

            txtAutor.Clear();
            txtIsbn.Clear();
            txtTitulo.Clear();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var encontrado = miLista.Buscar(txtIsbn.Text);
            if (encontrado != null)
                MessageBox.Show($"Encontrado: {encontrado.Titulo} de {encontrado.Autor}");
            else
                MessageBox.Show("No se encontró el registro.");

            txtAutor.Clear();
            txtIsbn.Clear();
            txtTitulo.Clear(); 

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (miLista.Eliminar(txtIsbn.Text))
            {
                MessageBox.Show("Registro eliminado.");
                ActualizarPantalla();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar (ISBN no existe).");
            }
        }

        private void btnInsertarFinal_Click(object sender, EventArgs e)
        {
            // 1. Validar que los campos no estén vacíos (Opcional pero recomendado)
            if (string.IsNullOrEmpty(txtIsbn.Text) || string.IsNullOrEmpty(txtTitulo.Text))
            {
                MessageBox.Show("Por favor, llena los datos básicos.");
                return;
            }

            // 2. Validar que el código no esté repetido
            if (miLista.ExisteCodigo(txtIsbn.Text))
            {
                MessageBox.Show("Error: El código ya existe.");
                return;
            }

            // 3. Llamar al método que recorre hasta el último nodo
            miLista.InsertarFinal(txtIsbn.Text, txtTitulo.Text, txtAutor.Text);

            // 4. Actualizar la tabla y limpiar los cuadros de texto
            ActualizarPantalla();
            //LimpiarFormulario();
        }
    }
}

