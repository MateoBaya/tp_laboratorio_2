using System;
using Entidades;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Carga de datos
            Pelicula pelicula = new Pelicula(12, "Terrible peli", 90, 250, 4, "Tremendo Peliculon, disfrutable");
            Entrada entrada = new Entrada(45, pelicula, "2D", 4);
            Comprador comprador = new Comprador(50, entrada, "Julian", "18:10");

            //Se carga el Ticket.xml
            Ticket.ArmarTicket(comprador);
            Console.WriteLine("Ticket armado correctamente, presione una tecla para avanzar");
            Console.ReadKey();

            comprador = null;

            //Se abre el Ticket.xml
            comprador=Ticket.LeerTicket(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Ticket.xml"));
            Console.WriteLine($"Nombre:{comprador.NombreComprador} \nHora:{comprador.HorarioElegido} \n" +
                $"cantEntradas:{comprador.Entrada.Cantidad} \ncantDimensiones:{comprador.Entrada.DimensionesPelicula} \n" +
                $"Titulo:{comprador.Entrada.Pelicula.Nombre} \nPrecio:{comprador.Precio}");

            Console.WriteLine("Carga efectuada correctamente, precione una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
