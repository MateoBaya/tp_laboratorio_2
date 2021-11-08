using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Interfaz que permite ordenar las clases por su Id, además de ocultar este id de la serialización xml
    /// </summary>
    interface IOrdenamiento
    {
        int Id { get; }
        int OrdenarPorId(int id1,int id2);
    }
}
