
namespace FormCine
{
    partial class FormTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTicket));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCantEntradas = new System.Windows.Forms.Label();
            this.lblCantidadDimensiones = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtTitutlo = new System.Windows.Forms.TextBox();
            this.txtCantidadEntradas = new System.Windows.Forms.TextBox();
            this.txtDimensiones = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormCine.Properties.Resources.camaraimagen;
            this.pictureBox1.Location = new System.Drawing.Point(44, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreCompleto.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNombreCompleto.Location = new System.Drawing.Point(213, 26);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(112, 14);
            this.lblNombreCompleto.TabIndex = 1;
            this.lblNombreCompleto.Text = "Nombre Completo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitulo.Location = new System.Drawing.Point(213, 58);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(49, 14);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblCantEntradas
            // 
            this.lblCantEntradas.AutoSize = true;
            this.lblCantEntradas.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantEntradas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCantEntradas.Location = new System.Drawing.Point(213, 93);
            this.lblCantEntradas.Name = "lblCantEntradas";
            this.lblCantEntradas.Size = new System.Drawing.Size(147, 14);
            this.lblCantEntradas.TabIndex = 3;
            this.lblCantEntradas.Text = "Cantidad de entradas";
            // 
            // lblCantidadDimensiones
            // 
            this.lblCantidadDimensiones.AutoSize = true;
            this.lblCantidadDimensiones.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadDimensiones.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCantidadDimensiones.Location = new System.Drawing.Point(213, 126);
            this.lblCantidadDimensiones.Name = "lblCantidadDimensiones";
            this.lblCantidadDimensiones.Size = new System.Drawing.Size(119, 14);
            this.lblCantidadDimensiones.TabIndex = 4;
            this.lblCantidadDimensiones.Text = "Tipo de pelicula";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHorario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblHorario.Location = new System.Drawing.Point(213, 157);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(56, 14);
            this.lblHorario.TabIndex = 5;
            this.lblHorario.Text = "Horario";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNombreCompleto.Location = new System.Drawing.Point(369, 19);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.ReadOnly = true;
            this.txtNombreCompleto.Size = new System.Drawing.Size(223, 22);
            this.txtNombreCompleto.TabIndex = 6;
            this.txtNombreCompleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTitutlo
            // 
            this.txtTitutlo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitutlo.Location = new System.Drawing.Point(369, 53);
            this.txtTitutlo.Name = "txtTitutlo";
            this.txtTitutlo.ReadOnly = true;
            this.txtTitutlo.Size = new System.Drawing.Size(223, 22);
            this.txtTitutlo.TabIndex = 7;
            this.txtTitutlo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCantidadEntradas
            // 
            this.txtCantidadEntradas.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCantidadEntradas.Location = new System.Drawing.Point(369, 88);
            this.txtCantidadEntradas.Name = "txtCantidadEntradas";
            this.txtCantidadEntradas.ReadOnly = true;
            this.txtCantidadEntradas.Size = new System.Drawing.Size(223, 22);
            this.txtCantidadEntradas.TabIndex = 8;
            this.txtCantidadEntradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDimensiones
            // 
            this.txtDimensiones.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDimensiones.Location = new System.Drawing.Point(369, 121);
            this.txtDimensiones.Name = "txtDimensiones";
            this.txtDimensiones.ReadOnly = true;
            this.txtDimensiones.Size = new System.Drawing.Size(223, 22);
            this.txtDimensiones.TabIndex = 9;
            this.txtDimensiones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHorario
            // 
            this.txtHorario.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHorario.Location = new System.Drawing.Point(369, 152);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.ReadOnly = true;
            this.txtHorario.Size = new System.Drawing.Size(223, 22);
            this.txtHorario.TabIndex = 10;
            this.txtHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPrecio.Location = new System.Drawing.Point(369, 182);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(223, 22);
            this.txtPrecio.TabIndex = 14;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPrecio.Location = new System.Drawing.Point(213, 186);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 14);
            this.lblPrecio.TabIndex = 15;
            this.lblPrecio.Text = "Precio";
            // 
            // FormTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(613, 218);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtDimensiones);
            this.Controls.Add(this.txtCantidadEntradas);
            this.Controls.Add(this.txtTitutlo);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblCantidadDimensiones);
            this.Controls.Add(this.lblCantEntradas);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombreCompleto);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disfrute su pelicula!";
            this.TransparencyKey = System.Drawing.Color.LightPink;
            this.Load += new System.EventHandler(this.FormTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCantEntradas;
        private System.Windows.Forms.Label lblCantidadDimensiones;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.TextBox txtTitutlo;
        private System.Windows.Forms.TextBox txtCantidadEntradas;
        private System.Windows.Forms.TextBox txtDimensiones;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
    }
}