
namespace FormCine
{
    partial class FormExito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExito));
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.pctbClose = new System.Windows.Forms.PictureBox();
            this.lblExito = new System.Windows.Forms.Label();
            this.btnVerTicket = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.Fuchsia;
            this.pnlBarra.Controls.Add(this.pctbClose);
            this.pnlBarra.Location = new System.Drawing.Point(3, 2);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(438, 51);
            this.pnlBarra.TabIndex = 0;
            this.pnlBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseDown);
            // 
            // pctbClose
            // 
            this.pctbClose.Image = global::FormCine.Properties.Resources._1487086345_cross_81577;
            this.pctbClose.Location = new System.Drawing.Point(389, 4);
            this.pctbClose.Name = "pctbClose";
            this.pctbClose.Size = new System.Drawing.Size(46, 44);
            this.pctbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbClose.TabIndex = 1;
            this.pctbClose.TabStop = false;
            this.pctbClose.Click += new System.EventHandler(this.pctbClose_Click);
            this.pctbClose.MouseEnter += new System.EventHandler(this.pctbClose_MouseEnter);
            this.pctbClose.MouseLeave += new System.EventHandler(this.pctbClose_MouseLeave);
            // 
            // lblExito
            // 
            this.lblExito.AutoSize = true;
            this.lblExito.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExito.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblExito.Location = new System.Drawing.Point(6, 59);
            this.lblExito.Name = "lblExito";
            this.lblExito.Size = new System.Drawing.Size(428, 50);
            this.lblExito.TabIndex = 5;
            this.lblExito.Text = "Su ticket se ha realizado\r\ncorrectamente en esta direccion:\r\n";
            // 
            // btnVerTicket
            // 
            this.btnVerTicket.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerTicket.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerTicket.Location = new System.Drawing.Point(136, 159);
            this.btnVerTicket.Name = "btnVerTicket";
            this.btnVerTicket.Size = new System.Drawing.Size(149, 30);
            this.btnVerTicket.TabIndex = 11;
            this.btnVerTicket.Text = "Ver Ahora";
            this.btnVerTicket.UseVisualStyleBackColor = false;
            this.btnVerTicket.Click += new System.EventHandler(this.btnVerTicket_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(48, 125);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(345, 23);
            this.txtPath.TabIndex = 12;
            // 
            // FormExito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(440, 201);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnVerTicket);
            this.Controls.Add(this.lblExito);
            this.Controls.Add(this.pnlBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormExito";
            this.Load += new System.EventHandler(this.FormExito_Load);
            this.pnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.PictureBox pctbClose;
        private System.Windows.Forms.Label lblExito;
        private System.Windows.Forms.Button btnVerTicket;
        private System.Windows.Forms.TextBox txtPath;
    }
}