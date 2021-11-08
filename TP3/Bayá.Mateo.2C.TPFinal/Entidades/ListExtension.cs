using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ListExtension
    {
        /// <summary>
        /// Método de extensión de List de Peliculas para agregar si no está la película agregada
        /// </summary>
        /// <param name="listPelicula">Parametro de tipo List<Pelicula> es la referencia al objeto afectado</param>
        /// <param name="peliculaAgregar">Parametro de tipo Pelicula que se agregará o no a la lista</param>
        /// <returns></returns>
        public static List<Pelicula> Agregar(this List<Pelicula> listPelicula,Pelicula peliculaAgregar)
        {
            foreach(Pelicula pelicula in listPelicula)
            {
                if (pelicula.Id == peliculaAgregar.Id)
                {
                    return listPelicula;
                }
            }
            listPelicula.Add(peliculaAgregar);
            return listPelicula;
        }
    }
}
