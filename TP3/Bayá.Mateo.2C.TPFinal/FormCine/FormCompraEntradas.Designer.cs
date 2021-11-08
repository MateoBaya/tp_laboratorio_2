
namespace FormCine
{
    partial class FormCompraEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompraEntradas));
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.ptbCaratula = new System.Windows.Forms.PictureBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmbHorarios = new System.Windows.Forms.ComboBox();
            this.lblHorarios = new System.Windows.Forms.Label();
            this.lblTipoPelicula = new System.Windows.Forms.Label();
            this.cmbTipoDePelicula = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.pctbLess = new System.Windows.Forms.PictureBox();
            this.pctbMore = new System.Windows.Forms.PictureBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCaratula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbLess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMore)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(66, 334);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(55, 15);
            this.lblDuracion.TabIndex = 10;
            this.lblDuracion.Text = "Duracion";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(66, 213);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(37, 15);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(141, 326);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.ReadOnly = true;
            this.txtDuracion.Size = new System.Drawing.Size(51, 23);
            this.txtDuracion.TabIndex = 8;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(141, 209);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(210, 23);
            this.txtTitulo.TabIndex = 7;
            // 
            // ptbCaratula
            // 
            this.ptbCaratula.Location = new System.Drawing.Point(141, 12);
            this.ptbCaratula.MaximumSize = new System.Drawing.Size(300, 190);
            this.ptbCaratula.Name = "ptbCaratula";
            this.ptbCaratula.Size = new System.Drawing.Size(210, 190);
            this.ptbCaratula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbCaratula.TabIndex = 6;
            this.ptbCaratula.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(141, 238);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(210, 82);
            this.txtDescripcion.TabIndex = 15;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(66, 238);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 15);
            this.lblDescripcion.TabIndex = 14;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // cmbHorarios
            // 
            this.cmbHorarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorarios.FormattingEnabled = true;
            this.cmbHorarios.Location = new System.Drawing.Point(141, 355);
            this.cmbHorarios.Name = "cmbHorarios";
            this.cmbHorarios.Size = new System.Drawing.Size(67, 23);
            this.cmbHorarios.TabIndex = 16;
            // 
            // lblHorarios
            // 
            this.lblHorarios.AutoSize = true;
            this.lblHorarios.Location = new System.Drawing.Point(69, 363);
            this.lblHorarios.Name = "lblHorarios";
            this.lblHorarios.Size = new System.Drawing.Size(52, 15);
            this.lblHorarios.TabIndex = 17;
            this.lblHorarios.Text = "Horarios";
            // 
            // lblTipoPelicula
            // 
            this.lblTipoPelicula.AutoSize = true;
            this.lblTipoPelicula.Location = new System.Drawing.Point(204, 334);
            this.lblTipoPelicula.Name = "lblTipoPelicula";
            this.lblTipoPelicula.Size = new System.Drawing.Size(90, 15);
            this.lblTipoPelicula.TabIndex = 18;
            this.lblTipoPelicula.Text = "TIpo de pelicula";
            // 
            // cmbTipoDePelicula
            // 
            this.cmbTipoDePelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDePelicula.FormattingEnabled = true;
            this.cmbTipoDePelicula.Location = new System.Drawing.Point(300, 326);
            this.cmbTipoDePelicula.Name = "cmbTipoDePelicula";
            this.cmbTipoDePelicula.Size = new System.Drawing.Size(51, 23);
            this.cmbTipoDePelicula.TabIndex = 19;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 413);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 15);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre Completo";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(141, 409);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(210, 23);
            this.txtNombreCompleto.TabIndex = 21;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(221, 362);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 15);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "Cantidad";
            // 
            // pctbLess
            // 
            this.pctbLess.Image = global::FormCine.Properties.Resources.less;
            this.pctbLess.Location = new System.Drawing.Point(282, 363);
            this.pctbLess.Name = "pctbLess";
            this.pctbLess.Size = new System.Drawing.Size(17, 16);
            this.pctbLess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbLess.TabIndex = 23;
            this.pctbLess.TabStop = false;
            this.pctbLess.Click += new System.EventHandler(this.pctbLess_Click);
            // 
            // pctbMore
            // 
            this.pctbMore.Image = global::FormCine.Properties.Resources.plus;
            this.pctbMore.Location = new System.Drawing.Point(334, 363);
            this.pctbMore.Name = "pctbMore";
            this.pctbMore.Size = new System.Drawing.Size(17, 16);
            this.pctbMore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbMore.TabIndex = 24;
            this.pctbMore.TabStop = false;
            this.pctbMore.Click += new System.EventHandler(this.pctbMore_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(303, 360);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(28, 23);
            this.txtCantidad.TabIndex = 25;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(141, 452);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(210, 44);
            this.btnComprar.TabIndex = 26;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // FormCompraEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(497, 529);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.pctbMore);
            this.Controls.Add(this.pctbLess);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cmbTipoDePelicula);
            this.Controls.Add(this.lblTipoPelicula);
            this.Controls.Add(this.lblHorarios);
            this.Controls.Add(this.cmbHorarios);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.ptbCaratula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCompraEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compre su entrada";
            this.Load += new System.EventHandler(this.FormCompraEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCaratula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbLess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.PictureBox ptbCaratula;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cmbHorarios;
        private System.Windows.Forms.Label lblHorarios;
        private System.Windows.Forms.Label lblTipoPelicula;
        private System.Windows.Forms.ComboBox cmbTipoDePelicula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.PictureBox pctbLess;
        private System.Windows.Forms.PictureBox pctbMore;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnComprar;
    }
}