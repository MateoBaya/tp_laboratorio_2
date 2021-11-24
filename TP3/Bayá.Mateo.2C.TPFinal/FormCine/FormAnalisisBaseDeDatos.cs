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
    public partial class FormAnalisisBaseDeDatos : Form
    {
        string connectionString = "Server=.;Database=Pelis;Trusted_Connection=True;";
        public FormAnalisisBaseDeDatos()
        {
            InitializeComponent();
        }

        private void cmbAnalisisPorGenero_TextChanged(object sender, EventArgs e)
        {
            PrecioEntradaPromedio();
            CantidadDeEntradasMaxima();
            HorarioMasTarde();
            CantidadUsuario();
            PeliculaMasComprada();
        }

        private void PrecioEntradaPromedio()
        {
            try
            {
                List<Comprador> compradoresPorGenero = SqlHandler.ObtenerCompradoresCompletosDeBaseDeDatosPorGenero(connectionString, cmbAnalisisPorGenero.Text);
                int contador = 0;
                int acum = 0;
                foreach(Comprador item in compradoresPorGenero)
                {
                    acum += item.Precio;
                    contador++;
                }
                txtPrecioPromedio.Text = (acum/contador).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void CantidadDeEntradasMaxima()
        {
            try
            {
                List<Comprador> compradoresPorGenero = SqlHandler.ObtenerCompradoresCompletosDeBaseDeDatosPorGenero(connectionString, cmbAnalisisPorGenero.Text);
                int acumMax = 0;
                foreach (Comprador item in compradoresPorGenero)
                {
                    if (item.Entrada.Cantidad > acumMax)
                    {
                        acumMax = item.Entrada.Cantidad;
                    }
                }
                txtCantidadEntradasMaximas.Text = acumMax.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HorarioMasTarde()
        {
            try
            {
                List<Comprador> compradoresPorGenero = SqlHandler.ObtenerCompradoresCompletosDeBaseDeDatosPorGenero(connectionString, cmbAnalisisPorGenero.Text);
                int acumMax = 0;
                foreach (Comprador item in compradoresPorGenero)
                {
                    string horarioEnNumeros = item.HorarioElegido.Replace(":","");
                    if (int.Parse(horarioEnNumeros) > acumMax)
                    {
                        acumMax = int.Parse(horarioEnNumeros);
                    }
                }
                string horarioFinal = acumMax.ToString().Insert(2,":");
                txtHorarioMasTarde.Text = horarioFinal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CantidadUsuario()
        {
            try
            {
                List<Comprador> compradoresPorGenero = SqlHandler.ObtenerCompradoresCompletosDeBaseDeDatosPorGenero(connectionString, cmbAnalisisPorGenero.Text);
                List<string> compradoresDistintos = new List<string>();
                foreach (Comprador item in compradoresPorGenero)
                {
                    if (!compradoresDistintos.Contains(item.NombreComprador))
                    {
                        compradoresDistintos.Add(item.NombreComprador);
                    }
                }
                txtCantUsuarios.Text = compradoresDistintos.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PeliculaMasComprada()
        {
            try
            {
                List<Comprador> compradoresPorGenero = SqlHandler.ObtenerCompradoresCompletosDeBaseDeDatosPorGenero(connectionString, cmbAnalisisPorGenero.Text);
                Comprador[] compradoresArray = compradoresPorGenero.ToArray();
                string tituloPeli = "";
                int contador = 0;
                int acum = 0;
                for(int i = 0; i < compradoresArray.Length-1; i++)
                {
                    for(int j = i + 1; j < compradoresArray.Length; j++)
                    {
                        if(compradoresArray[i].Entrada.Pelicula.Nombre==compradoresArray[j].Entrada.Pelicula.Nombre)
                        {
                            contador++;
                        }
                    }
                    if (contador > acum)
                    {
                        acum = contador;
                        tituloPeli = compradoresArray[i].Entrada.Pelicula.Nombre;
                    }
                    else if(contador == acum)
                    {
                        tituloPeli = "No hay pelicula mas comprada";
                    }
                    contador = 0;
                }
                
                txtPeliculaMasComprada.Text = tituloPeli;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
