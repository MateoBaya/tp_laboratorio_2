using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public static class Ticket
    {
        /// <summary>
        /// Este metodo de clase utiliza el metodo ManejoXmlEscritura
        /// </summary>
        /// <param name="comprador">Parametro del comprador que se convertira a xml en forma de ticket</param>
        /// <returns>Retorna el path en el que se guardo el xml</returns>
        public static string ArmarTicket(Comprador comprador)
        {
            try
            {
                return ManejoXmlEscritura(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Ticket.xml"),comprador);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Metodo de clase que utiliza el metodo ManejoXmlLectura para instanciar un comprador
        /// </summary>
        /// <param name="path">Parametro de tipo string que tiene el path del archivo Ticket.xml</param>
        /// <returns>Retorna el comprador instanciado del archivo</returns>
        public static Comprador LeerTicket(string path)
        {

            Comprador comprador = new Comprador();

            try
            {
                comprador = ManejoXmlLectura(path, comprador);
            }
            catch (Exception)
            {
                throw;
            }

            return comprador;
        }

        /// <summary>
        /// Metodo estatico que convierte un comprador a un ticket de tipo .xml
        /// </summary>
        /// <param name="path">Parametro de tipo string que tiene la direccion donde guardar el archivo</param>
        /// <param name="comprador">Parametro de tipo comprador que convertir a .xml</param>
        /// <returns>Retorna el path de donde se guardo efectivamente el comprador</returns>
        private static string ManejoXmlEscritura(string path, Comprador comprador)
        {

            try
            {
                int contador = 0;
                while(File.Exists(path))
                {
                    contador++;
                    int i = path.IndexOf(".xml");
                    if (i >= 0)
                    {
                        if(path[i-1]==')')
                        {
                            int j = i-1;
                            while (path[j]!='(')
                            {
                                j--;
                            }
                            path = path.Remove(j,3);
                            path = path.Insert(j, $"({contador})");

                        }
                        else
                        {
                            path = path.Insert(i, $"({contador})");
                        }
                    }
                }
                StreamWriter sw = new StreamWriter(path);
                XmlTextWriter writer = new XmlTextWriter(sw);
                XmlSerializer serializer = new XmlSerializer(typeof(Comprador));
                serializer.Serialize(writer, comprador);
                writer.Close();
                sw.Close();

            }
            catch (PathTooLongException)
            {
                ManejoXmlEscritura("Ticket.xml", comprador);
            }
            catch (System.UnauthorizedAccessException)
            {
                ManejoXmlEscritura("Ticket.xml", comprador);
            }
            catch (FileNotFoundException)
            {
                ManejoXmlEscritura("Ticket.xml", comprador);
            }
            catch (Exception)
            {
                throw;
            }
            
            return path;
        }

        /// <summary>
        /// Metodo estatico que convierte un archivo Ticket.xml a Comprador
        /// </summary>
        /// <param name="path">Parametro de tipo string donde se ubica el archivo a convertir</param>
        /// <param name="comprador">Parametro de tipo Comprador al que sera convertido el archivo .xml</param>
        /// <returns></returns>
        private static Comprador ManejoXmlLectura(string path, Comprador comprador)
        {
            try
            {
                if (File.Exists(path)&&Path.GetExtension(path)==".xml")
                {
                    StreamReader sr = new StreamReader(path);
                    XmlSerializer serializer = new XmlSerializer(typeof(Comprador));
                    comprador = serializer.Deserialize(sr) as Comprador;
                    sr.Close();
                    return comprador;
                }
                else
                {
                    throw new FileNotFoundException("El archivo no existe o no es .xml");
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
