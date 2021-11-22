
namespace FormCine
{
    partial class FormListaPelicula
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaPelicula));
            this.lstPeliculas = new System.Windows.Forms.ListBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblVisitas = new System.Windows.Forms.Label();
            this.lblRanking = new System.Windows.Forms.Label();
            this.txtVisitas = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.txtRanking = new System.Windows.Forms.TextBox();
            this.msControles = new System.Windows.Forms.MenuStrip();
            this.abrirTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descargarTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analisisDeBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRanking5 = new System.Windows.Forms.Label();
            this.lblEstrellas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ttHelp = new System.Windows.Forms.ToolTip(this.components);
            this.msControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPeliculas
            // 
            this.lstPeliculas.FormattingEnabled = true;
            this.lstPeliculas.ItemHeight = 15;
            this.lstPeliculas.Location = new System.Drawing.Point(12, 31);
            this.lstPeliculas.MaximumSize = new System.Drawing.Size(146, 424);
            this.lstPeliculas.Name = "lstPeliculas";
            this.lstPeliculas.Size = new System.Drawing.Size(146, 424);
            this.lstPeliculas.TabIndex = 0;
            this.lstPeliculas.SelectedIndexChanged += new System.EventHandler(this.lstPeliculas_SelectedIndexChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(237, 228);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(210, 23);
            this.txtTitulo.TabIndex = 2;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(237, 345);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.ReadOnly = true;
            this.txtDuracion.Size = new System.Drawing.Size(51, 23);
            this.txtDuracion.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(167, 232);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(37, 15);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(167, 348);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(55, 15);
            this.lblDuracion.TabIndex = 5;
            this.lblDuracion.Text = "Duracion";
            // 
            // lblVisitas
            // 
            this.lblVisitas.AutoSize = true;
            this.lblVisitas.Location = new System.Drawing.Point(167, 376);
            this.lblVisitas.Name = "lblVisitas";
            this.lblVisitas.Size = new System.Drawing.Size(40, 15);
            this.lblVisitas.TabIndex = 8;
            this.lblVisitas.Text = "Visitas";
            // 
            // lblRanking
            // 
            this.lblRanking.AutoSize = true;
            this.lblRanking.Location = new System.Drawing.Point(340, 348);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(50, 15);
            this.lblRanking.TabIndex = 9;
            this.lblRanking.Text = "Ranking";
            // 
            // txtVisitas
            // 
            this.txtVisitas.Location = new System.Drawing.Point(237, 373);
            this.txtVisitas.Name = "txtVisitas";
            this.txtVisitas.ReadOnly = true;
            this.txtVisitas.Size = new System.Drawing.Size(51, 23);
            this.txtVisitas.TabIndex = 10;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(167, 257);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 15);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(237, 257);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(210, 82);
            this.txtDescripcion.TabIndex = 13;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(237, 412);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(210, 39);
            this.btnComprar.TabIndex = 14;
            this.btnComprar.Text = "Comprar entrada";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // txtRanking
            // 
            this.txtRanking.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRanking.Location = new System.Drawing.Point(396, 345);
            this.txtRanking.Name = "txtRanking";
            this.txtRanking.ReadOnly = true;
            this.txtRanking.Size = new System.Drawing.Size(51, 21);
            this.txtRanking.TabIndex = 16;
            // 
            // msControles
            // 
            this.msControles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirTicketToolStripMenuItem,
            this.descargarTicketsToolStripMenuItem,
            this.analisisDeBaseDeDatosToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.msControles.Location = new System.Drawing.Point(0, 0);
            this.msControles.Name = "msControles";
            this.msControles.Size = new System.Drawing.Size(455, 24);
            this.msControles.TabIndex = 17;
            this.msControles.Text = "menuStrip1";
            // 
            // abrirTicketToolStripMenuItem
            // 
            this.abrirTicketToolStripMenuItem.Name = "abrirTicketToolStripMenuItem";
            this.abrirTicketToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.abrirTicketToolStripMenuItem.Text = "Abrir Ticket";
            this.abrirTicketToolStripMenuItem.Click += new System.EventHandler(this.abrirTicketToolStripMenuItem_Click);
            // 
            // descargarTicketsToolStripMenuItem
            // 
            this.descargarTicketsToolStripMenuItem.Enabled = false;
            this.descargarTicketsToolStripMenuItem.Name = "descargarTicketsToolStripMenuItem";
            this.descargarTicketsToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.descargarTicketsToolStripMenuItem.Text = "Descargar Tickets";
            this.descargarTicketsToolStripMenuItem.Visible = false;
            this.descargarTicketsToolStripMenuItem.Click += new System.EventHandler(this.descargarTicketsToolStripMenuItem_Click);
            // 
            // analisisDeBaseDeDatosToolStripMenuItem
            // 
            this.analisisDeBaseDeDatosToolStripMenuItem.Enabled = false;
            this.analisisDeBaseDeDatosToolStripMenuItem.Name = "analisisDeBaseDeDatosToolStripMenuItem";
            this.analisisDeBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.analisisDeBaseDeDatosToolStripMenuItem.Text = "Analisis de usuarios";
            this.analisisDeBaseDeDatosToolStripMenuItem.Visible = false;
            this.analisisDeBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.analisisDeBaseDeDatosToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Enabled = false;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem.Visible = false;
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // lblRanking5
            // 
            this.lblRanking5.AutoSize = true;
            this.lblRanking5.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRanking5.Location = new System.Drawing.Point(416, 348);
            this.lblRanking5.Name = "lblRanking5";
            this.lblRanking5.Size = new System.Drawing.Size(29, 12);
            this.lblRanking5.TabIndex = 18;
            this.lblRanking5.Text = "/5★";
            // 
            // lblEstrellas
            // 
            this.lblEstrellas.AutoSize = true;
            this.lblEstrellas.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstrellas.Location = new System.Drawing.Point(325, 363);
            this.lblEstrellas.Name = "lblEstrellas";
            this.lblEstrellas.Size = new System.Drawing.Size(65, 12);
            this.lblEstrellas.TabIndex = 19;
            this.lblEstrellas.Text = "★★★★★";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormCine.Properties.Resources.help;
            this.pictureBox1.Location = new System.Drawing.Point(428, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.ttHelp.SetToolTip(this.pictureBox1, "Los tickets se guardan por defecto en la carpeta Documentos");
            // 
            // FormListaPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(455, 466);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEstrellas);
            this.Controls.Add(this.lblRanking5);
            this.Controls.Add(this.txtRanking);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtVisitas);
            this.Controls.Add(this.lblRanking);
            this.Controls.Add(this.lblVisitas);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lstPeliculas);
            this.Controls.Add(this.msControles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msControles;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListaPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peliculas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormListaPelicula_FormClosing);
            this.Load += new System.EventHandler(this.FormEntradas_Load);
            this.msControles.ResumeLayout(false);
            this.msControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPeliculas;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblVisitas;
        private System.Windows.Forms.Label lblRanking;
        private System.Windows.Forms.TextBox txtVisitas;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.TextBox txtRanking;
        private System.Windows.Forms.MenuStrip msControles;
        private System.Windows.Forms.ToolStripMenuItem abrirTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descargarTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analisisDeBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.Label lblRanking5;
        private System.Windows.Forms.Label lblEstrellas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip ttHelp;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}