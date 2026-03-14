namespace AppBiblioteca_ListasEnlazadas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPosicion = new System.Windows.Forms.NumericUpDown();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.btnInsertarInicio = new System.Windows.Forms.Button();
            this.btnInsertarMedio = new System.Windows.Forms.Button();
            this.btnInsertarFinal = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor";
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(207, 293);
            this.txtPosicion.Margin = new System.Windows.Forms.Padding(2);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(90, 20);
            this.txtPosicion.TabIndex = 3;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(447, 78);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(2);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(76, 20);
            this.txtIsbn.TabIndex = 4;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(447, 121);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(76, 20);
            this.txtTitulo.TabIndex = 5;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(447, 169);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(76, 20);
            this.txtAutor.TabIndex = 6;
            // 
            // dgvLibros
            // 
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(27, 68);
            this.dgvLibros.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RowHeadersWidth = 51;
            this.dgvLibros.RowTemplate.Height = 24;
            this.dgvLibros.Size = new System.Drawing.Size(315, 137);
            this.dgvLibros.TabIndex = 7;
            // 
            // btnInsertarInicio
            // 
            this.btnInsertarInicio.Location = new System.Drawing.Point(27, 226);
            this.btnInsertarInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertarInicio.Name = "btnInsertarInicio";
            this.btnInsertarInicio.Size = new System.Drawing.Size(56, 19);
            this.btnInsertarInicio.TabIndex = 8;
            this.btnInsertarInicio.Text = "Inicio";
            this.btnInsertarInicio.UseVisualStyleBackColor = true;
            this.btnInsertarInicio.Click += new System.EventHandler(this.btnInsertarInicio_Click);
            // 
            // btnInsertarMedio
            // 
            this.btnInsertarMedio.Location = new System.Drawing.Point(155, 226);
            this.btnInsertarMedio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertarMedio.Name = "btnInsertarMedio";
            this.btnInsertarMedio.Size = new System.Drawing.Size(56, 19);
            this.btnInsertarMedio.TabIndex = 9;
            this.btnInsertarMedio.Text = "Medio";
            this.btnInsertarMedio.UseVisualStyleBackColor = true;
            this.btnInsertarMedio.Click += new System.EventHandler(this.btnInsertarMedio_Click);
            // 
            // btnInsertarFinal
            // 
            this.btnInsertarFinal.Location = new System.Drawing.Point(286, 226);
            this.btnInsertarFinal.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertarFinal.Name = "btnInsertarFinal";
            this.btnInsertarFinal.Size = new System.Drawing.Size(56, 19);
            this.btnInsertarFinal.TabIndex = 10;
            this.btnInsertarFinal.Text = "Final";
            this.btnInsertarFinal.UseVisualStyleBackColor = true;
            this.btnInsertarFinal.Click += new System.EventHandler(this.btnInsertarFinal_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(147, 292);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 19);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(500, 294);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 19);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Registro de Libros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 338);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnInsertarFinal);
            this.Controls.Add(this.btnInsertarMedio);
            this.Controls.Add(this.btnInsertarInicio);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPosicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtPosicion;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Button btnInsertarInicio;
        private System.Windows.Forms.Button btnInsertarMedio;
        private System.Windows.Forms.Button btnInsertarFinal;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label4;
    }
}

