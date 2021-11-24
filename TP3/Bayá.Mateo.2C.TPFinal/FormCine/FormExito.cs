using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormCine
{
    public partial class FormExito : Form
    {
        string path;
        FormTicket formTicket;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FormExito()
        {
            InitializeComponent();
        }
        public FormExito(string path):this()
        {
            this.path = path;
        }

        private void pctbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctbClose_MouseEnter(object sender, EventArgs e)
        {
            pctbClose.Image = Properties.Resources.redcross;
        }

        private void pctbClose_MouseLeave(object sender, EventArgs e)
        {
            pctbClose.Image = Properties.Resources._1487086345_cross_81577;
        }

        private void btnVerTicket_Click(object sender, EventArgs e)
        {
            try
            {
                    Comprador comprador = Ticket.LeerTicket(path);
                    formTicket = FormGenerico<FormTicket>.IsActivatedSignleton<Comprador>(formTicket,comprador);
                    formTicket.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void FormExito_Load(object sender, EventArgs e)
        {
            txtPath.Text = path;
        }

        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
