
namespace FormCine
{
    partial class FormAnalisisBaseDeDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbAnalisisPorGenero = new System.Windows.Forms.ComboBox();
            this.lblPrecioPromedio = new System.Windows.Forms.Label();
            this.lblCantidadMaximaEntradas = new System.Windows.Forms.Label();
            this.lblHorarioMasTarde = new System.Windows.Forms.Label();
            this.lblCantidadUsuarios = new System.Windows.Forms.Label();
            this.lblPeliculaMasComprada = new System.Windows.Forms.Label();
            this.txtPrecioPromedio = new System.Windows.Forms.TextBox();
            this.txtCantidadEntradasMaximas = new System.Windows.Forms.TextBox();
            this.txtHorarioMasTarde = new System.Windows.Forms.TextBox();
            this.txtCantUsuarios = new System.Windows.Forms.TextBox();
            this.txtPeliculaMasComprada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbAnalisisPorGenero
            // 
            this.cmbAnalisisPorGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnalisisPorGenero.FormattingEnabled = true;
            this.cmbAnalisisPorGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.cmbAnalisisPorGenero.Location = new System.Drawing.Point(249, 12);
            this.cmbAnalisisPorGenero.Name = "cmbAnalisisPorGenero";
            this.cmbAnalisisPorGenero.Size = new System.Drawing.Size(121, 23);
            this.cmbAnalisisPorGenero.TabIndex = 0;
            this.cmbAnalisisPorGenero.TextChanged += new System.EventHandler(this.cmbAnalisisPorGenero_TextChanged);
            // 
            // lblPrecioPromedio
            // 
            this.lblPrecioPromedio.AutoSize = true;
            this.lblPrecioPromedio.Location = new System.Drawing.Point(39, 71);
            this.lblPrecioPromedio.Name = "lblPrecioPromedio";
            this.lblPrecioPromedio.Size = new System.Drawing.Size(216, 15);
            this.lblPrecioPromedio.TabIndex = 1;
            this.lblPrecioPromedio.Text = "Precio de entrada promedio del genero:";
            // 
            // lblCantidadMaximaEntradas
            // 
            this.lblCantidadMaximaEntradas.AutoSize = true;
            this.lblCantidadMaximaEntradas.Location = new System.Drawing.Point(39, 108);
            this.lblCantidadMaximaEntradas.Name = "lblCantidadMaximaEntradas";
            this.lblCantidadMaximaEntradas.Size = new System.Drawing.Size(345, 15);
            this.lblCantidadMaximaEntradas.TabIndex = 2;
            this.lblCantidadMaximaEntradas.Text = "Cantidad de entradas maximas dispuesto a comprar por genero:";
            // 
            // lblHorarioMasTarde
            // 
            this.lblHorarioMasTarde.AutoSize = true;
            this.lblHorarioMasTarde.Location = new System.Drawing.Point(39, 145);
            this.lblHorarioMasTarde.Name = "lblHorarioMasTarde";
            this.lblHorarioMasTarde.Size = new System.Drawing.Size(288, 15);
            this.lblHorarioMasTarde.TabIndex = 3;
            this.lblHorarioMasTarde.Text = "Horario más tarde dispuesto a comprarse por género:";
            // 
            // lblCantidadUsuarios
            // 
            this.lblCantidadUsuarios.AutoSize = true;
            this.lblCantidadUsuarios.Location = new System.Drawing.Point(39, 185);
            this.lblCantidadUsuarios.Name = "lblCantidadUsuarios";
            this.lblCantidadUsuarios.Size = new System.Drawing.Size(243, 15);
            this.lblCantidadUsuarios.TabIndex = 4;
            this.lblCantidadUsuarios.Text = "Cantidad de usuarios registrados por género:";
            // 
            // lblPeliculaMasComprada
            // 
            this.lblPeliculaMasComprada.AutoSize = true;
            this.lblPeliculaMasComprada.Location = new System.Drawing.Point(39, 222);
            this.lblPeliculaMasComprada.Name = "lblPeliculaMasComprada";
            this.lblPeliculaMasComprada.Size = new System.Drawing.Size(194, 15);
            this.lblPeliculaMasComprada.TabIndex = 5;
            this.lblPeliculaMasComprada.Text = "Pelicula más comprada por género:";
            // 
            // txtPrecioPromedio
            // 
            this.txtPrecioPromedio.Location = new System.Drawing.Point(455, 63);
            this.txtPrecioPromedio.Name = "txtPrecioPromedio";
            this.txtPrecioPromedio.ReadOnly = true;
            this.txtPrecioPromedio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecioPromedio.TabIndex = 6;
            // 
            // txtCantidadEntradasMaximas
            // 
            this.txtCantidadEntradasMaximas.Location = new System.Drawing.Point(455, 100);
            this.txtCantidadEntradasMaximas.Name = "txtCantidadEntradasMaximas";
            this.txtCantidadEntradasMaximas.ReadOnly = true;
            this.txtCantidadEntradasMaximas.Size = new System.Drawing.Size(100, 23);
            this.txtCantidadEntradasMaximas.TabIndex = 7;
            // 
            // txtHorarioMasTarde
            // 
            this.txtHorarioMasTarde.Location = new System.Drawing.Point(455, 137);
            this.txtHorarioMasTarde.Name = "txtHorarioMasTarde";
            this.txtHorarioMasTarde.ReadOnly = true;
            this.txtHorarioMasTarde.Size = new System.Drawing.Size(100, 23);
            this.txtHorarioMasTarde.TabIndex = 8;
            // 
            // txtCantUsuarios
            // 
            this.txtCantUsuarios.Location = new System.Drawing.Point(455, 177);
            this.txtCantUsuarios.Name = "txtCantUsuarios";
            this.txtCantUsuarios.ReadOnly = true;
            this.txtCantUsuarios.Size = new System.Drawing.Size(100, 23);
            this.txtCantUsuarios.TabIndex = 9;
            // 
            // txtPeliculaMasComprada
            // 
            this.txtPeliculaMasComprada.Location = new System.Drawing.Point(364, 214);
            this.txtPeliculaMasComprada.Name = "txtPeliculaMasComprada";
            this.txtPeliculaMasComprada.ReadOnly = true;
            this.txtPeliculaMasComprada.Size = new System.Drawing.Size(191, 23);
            this.txtPeliculaMasComprada.TabIndex = 10;
            // 
            // FormAnalisisBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 284);
            this.Controls.Add(this.txtPeliculaMasComprada);
            this.Controls.Add(this.txtCantUsuarios);
            this.Controls.Add(this.txtHorarioMasTarde);
            this.Controls.Add(this.txtCantidadEntradasMaximas);
            this.Controls.Add(this.txtPrecioPromedio);
            this.Controls.Add(this.lblPeliculaMasComprada);
            this.Controls.Add(this.lblCantidadUsuarios);
            this.Controls.Add(this.lblHorarioMasTarde);
            this.Controls.Add(this.lblCantidadMaximaEntradas);
            this.Controls.Add(this.lblPrecioPromedio);
            this.Controls.Add(this.cmbAnalisisPorGenero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAnalisisBaseDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analisis de usuarios registrados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAnalisisPorGenero;
        private System.Windows.Forms.Label lblPrecioPromedio;
        private System.Windows.Forms.Label lblCantidadMaximaEntradas;
        private System.Windows.Forms.Label lblHorarioMasTarde;
        private System.Windows.Forms.Label lblCantidadUsuarios;
        private System.Windows.Forms.Label lblPeliculaMasComprada;
        private System.Windows.Forms.TextBox txtPrecioPromedio;
        private System.Windows.Forms.TextBox txtCantidadEntradasMaximas;
        private System.Windows.Forms.TextBox txtHorarioMasTarde;
        private System.Windows.Forms.TextBox txtCantUsuarios;
        private System.Windows.Forms.TextBox txtPeliculaMasComprada;
    }
}