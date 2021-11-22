using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormCine
{
    public static class FormGenerico <T>
        where T : Form, new()
    {
        /// <summary>
        /// Valida si el formulario pasado por parametro esta cerrado o es nulo, en cuyo caso lo intancia
        /// </summary>
        /// <param name="formGeneric">Parametro de tipo generico, donde es un formulario que tiene constructor sin parametros</param>
        /// <returns>Retorna el formulario de tipo generico</returns>
        public static T IsActivatedSingleton(T formGeneric)
        {
            if(formGeneric is null || formGeneric.IsDisposed)
            {
                formGeneric = new T();
            }
            return formGeneric;
        }
        /// <summary>
        /// Valida si el formulario pasado por parametro esta cerrado o es nulo, en cuyo caso lo intancia
        /// </summary>
        /// <param name="formGeneric">Parametro de tipo generico, donde es un formulario que tiene constructor sin parametros</param>
        /// <param name="elementoDeIncializacion">Parametro de tipo generico, que sera el parametro del constructor de instancia con parametro del tipo Formulario generico</param>
        /// <returns>Retorna el formulario de tipo generico</returns>
        public static T IsActivatedSignleton<U>(T formGeneric, U elementoDeIncializacion)
        {
            if(formGeneric is null || formGeneric.IsDisposed)
            {
                formGeneric = Activator.CreateInstance(typeof(T), new object[] { elementoDeIncializacion }) as T;
            }
            return formGeneric;
        }
    }
}
