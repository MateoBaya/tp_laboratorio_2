using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioRegistrado
    {
        private int id;
        private string nombreCompleto;
        private int dni;
        private string usuario;
        private string contraseña;
        private string genero;

        public UsuarioRegistrado(string nombreCompleto, int dni, string usuario, string contraseña, string genero)
        {
            this.NombreCompleto = nombreCompleto;
            this.Dni = dni;
            this.Usuario = usuario;
            this.Contraseña = contraseña;
            this.Genero = genero;
        }

        public int Id { get => id; set => id = value; }
        public string NombreCompleto 
        { 
            get => nombreCompleto;
            set
            {
                if (!(String.IsNullOrEmpty(value)))
                {
                    this.nombreCompleto = value;
                }
                else
                {
                    throw new UsuarioMalCargadoException("Nombre vacio");
                }
            }
        }
        public int Dni 
        { 
            get => dni;
            set 
            {
                if (value.ToString().Length==8&&value.ToString().All(char.IsDigit))
                {
                    this.dni = value;
                }
                else
                {
                    throw new UsuarioMalCargadoException("Dni mal cargado, use solo numeros");
                }
            } 
        }
        public string Usuario 
        { 
            get => usuario; 
            set
            {
                if (!(String.IsNullOrEmpty(value)))
                {
                    this.usuario = value;
                }
                else
                {
                    throw new UsuarioMalCargadoException("Usuario vacio");
                }
            } 
        }
        public string Contraseña 
        { 
            get => contraseña;
            set
            {
                if(!(String.IsNullOrEmpty(value)))
                {
                    this.contraseña = value;
                }
                else
                {
                    throw new UsuarioMalCargadoException("Contraseña vacio");
                }
            } 
        }
        public string Genero
        { 
            get => genero; 
            set
            {
                if (!(String.IsNullOrEmpty(value)))
                {
                    this.genero = value;
                }
                else
                {
                    throw new UsuarioMalCargadoException("Genero vacio");
                }
            } 
        }
        public static UsuarioRegistrado AveriguarLogeo(string usuario, string password ,List<UsuarioRegistrado> usuariosDeLista)
        {
            foreach (UsuarioRegistrado item in usuariosDeLista)
            {
                if (usuario == item.Usuario && password == item.Contraseña)
                {
                    return item;
                }
            }
            throw new UsuarioMalCargadoException("Usuario o contraseña incorrectos");
        }

    }
}
