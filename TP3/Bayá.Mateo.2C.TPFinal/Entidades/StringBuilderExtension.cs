using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class StringBuilderExtension
    {
        /// <summary>
        /// Método de extensión de StringBuilder que verifica si el string pasado por parametro está en una de la lineas del StringBuilder
        /// </summary>
        /// <param name="sb">Parametro de referencia del stringbuilder modificado</param>
        /// <param name="comparable">Parametro de tipo string que será verificado si existe en las lineas del stringbuilder</param>
        /// <returns>Retorna true si existe la linea en el stringbuilder, retorna false si no o si hubo un error</returns>
        public static bool Contains(this StringBuilder sb,string comparable)
        {
            try
            {
                System.IO.StringReader reader = new System.IO.StringReader(sb.ToString());
                while(reader.Peek()>-1)
                {
                    string line = reader.ReadLine();
                    if(!(line is null))
                    {
                        if (line.Equals(comparable))
                        {
                            return true;
                        }
                    }
                }
                reader.Close();
                
            }
            catch (ArgumentNullException)
            {
                return false;
            }

            return false;
        }
        /// <summary>
        /// Método de extensión de StringBuilder que convierte un stringbuilder a una lista de string
        /// </summary>
        /// <param name="sb">Parametro de referencia del stringbuilder modificado</param>
        /// <returns>Retorna una lista de strings creada a partir del stringbuilder</returns>
        public static List<string> StringBuilderToList(this StringBuilder sb)
        {
            List<string> listOfStringBuilder = new List<string>(); 
            if(!(sb is null))
            {
                System.IO.StringReader reader = new System.IO.StringReader(sb.ToString());
                while(reader.Peek()>-1)
                {
                    string line = reader.ReadLine();
                    if(!(line is null))
                    {
                        listOfStringBuilder.Add(line);
                    }
                }
                reader.Close();
            }
            return listOfStringBuilder;
        }
        /// <summary>
        /// Método de extensión de StringBuilder que realiza un Sort de las oraciones que contiene convertiendose momentaneamente en lista y despues regresa a ser stringbuilder
        /// </summary>
        /// <param name="sb">Paramtro de referencia del stringbuilder modificado</param>
        /// <returns>Retorna el StringBuilder ordenado alfabéticamente</returns>
        public static StringBuilder Sort (this StringBuilder sb)
        {
            StringBuilder newSB=null;
            if(!(sb is null))
            {
                List<string> listaAOrdenar = sb.StringBuilderToList();
                listaAOrdenar.Sort();
                newSB = new StringBuilder(string.Join("\r\n", listaAOrdenar.ToArray()));
            }
            return newSB;
        }
    }
}
