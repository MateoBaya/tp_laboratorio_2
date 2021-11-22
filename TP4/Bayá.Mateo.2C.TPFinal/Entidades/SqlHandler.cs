using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class SqlHandler
    {
        public static List<Pelicula> LeerPeliculas(string conexion)
        {
            List<Pelicula> peliculas = new List<Pelicula>();
            SqlConnection connection = new SqlConnection(conexion);
            SqlCommand command = new SqlCommand();
            Pelicula pelicula;

            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM PeliculasGuardadas";
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    pelicula = new Pelicula(int.Parse(dataReader["id"].ToString()), dataReader["titulo"].ToString(), int.Parse(dataReader["duracion"].ToString()),
                        int.Parse(dataReader["visitas"].ToString()), float.Parse(dataReader["ranking"].ToString()), dataReader["descripcion"].ToString());
                    peliculas.Add(pelicula);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return peliculas;
        }

        public static void ModificarPeliculaVisitas(string conexion,int id,int visitas)
        {
            SqlConnection connection = new SqlConnection(conexion);
            SqlCommand command = new SqlCommand();
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE PeliculasGuardadas SET visitas = @VISITAS WHERE id = " + id;
                command.Parameters.AddWithValue("VISITAS", visitas);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

        }
        public static void RegistrarUsuario(string conexion, UsuarioRegistrado usuario)
        {
            SqlConnection connection = new SqlConnection(conexion);
            SqlCommand command = new SqlCommand();
            try
            {
                List<UsuarioRegistrado>usuarios = SqlHandler.LeerUsuarios(conexion);
                foreach(UsuarioRegistrado item in usuarios)
                {
                    if(item.Usuario == usuario.Usuario)
                    {
                        throw new UsuarioMalCargadoException("El usuario ya existe en la base de datos, elija otro");
                    }
                    if(item.Dni == usuario.Dni)
                    {
                        throw new UsuarioMalCargadoException("El DNI ya esta registrado en la base de datos, utilice su usuario y contraseña");
                    }
                }
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO UsuariosRegistrados VALUES (@NOMBRE,@DNI,@USUARIO,@CONTRASEÑA,@GENERO)";
                command.Parameters.AddWithValue("NOMBRE", usuario.NombreCompleto);
                command.Parameters.AddWithValue("DNI", usuario.Dni);
                command.Parameters.AddWithValue("USUARIO", usuario.Usuario);
                command.Parameters.AddWithValue("CONTRASEÑA", usuario.Contraseña);
                command.Parameters.AddWithValue("GENERO", usuario.Genero);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public static List<UsuarioRegistrado> LeerUsuarios(string conexion)
        {
            SqlConnection connection = new SqlConnection(conexion);
            SqlCommand command = new SqlCommand();
            List<UsuarioRegistrado> listaDeUsuarios = new List<UsuarioRegistrado>();
            UsuarioRegistrado usuario;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM UsuariosRegistrados";
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    usuario = new UsuarioRegistrado(dataReader["nombre"].ToString(),int.Parse(dataReader["dni"].ToString()),dataReader["usuario"].ToString(),
                        dataReader["contraseña"].ToString(),dataReader["genero"].ToString());
                    usuario.Id = int.Parse(dataReader["id"].ToString());
                    listaDeUsuarios.Add(usuario);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return listaDeUsuarios;
        }
        public static void AlmacenarTicketEnBaseDeDatos(string conexion, Comprador comprador, int idUsuario)
        {
            SqlConnection connection = new SqlConnection(conexion);
            SqlCommand command = new SqlCommand();
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Tickets VALUES (@NOMBRECOMPRADOR,@TITULO,@CANTENTRADAS,@TIPOPELICULA,@HORARIO,@PRECIO,@IDCOMPRADOR)";
                command.Parameters.AddWithValue("NOMBRECOMPRADOR", comprador.NombreComprador);
                command.Parameters.AddWithValue("TITULO", comprador.Entrada.Pelicula.Nombre);
                command.Parameters.AddWithValue("CANTENTRADAS", comprador.Entrada.Cantidad);
                command.Parameters.AddWithValue("TIPOPELICULA", comprador.Entrada.DimensionesPelicula);
                command.Parameters.AddWithValue("HORARIO", comprador.HorarioElegido);
                command.Parameters.AddWithValue("PRECIO", comprador.Precio);
                command.Parameters.AddWithValue("IDCOMPRADOR", idUsuario);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public static List<Comprador> ObtenerCompradorDeBaseDeDatos(string conexion,int idComprador)
        {
            SqlConnection connection = new SqlConnection(conexion);
            SqlCommand command = new SqlCommand();
            List<Comprador> tickets = new List<Comprador>();
            Comprador comprador;
            Entrada entrada;
            Pelicula pelicula;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Tickets WHERE idComprador = "+idComprador;
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    pelicula = new Pelicula();
                    pelicula.Nombre = dataReader["titulo"].ToString();
                    entrada = new Entrada(int.Parse(dataReader["id"].ToString()),pelicula,dataReader["tipoPelicula"].ToString(),int.Parse(dataReader["cantEntradas"].ToString()));
                    comprador = new Comprador(int.Parse(dataReader["idComprador"].ToString()),entrada,dataReader["nombreComprador"].ToString(),dataReader["horario"].ToString());
                    tickets.Add(comprador);
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return tickets;
        }
        public static List<Comprador> ObtenerCompradoresCompletosDeBaseDeDatosPorGenero(string conexion,string genero)
        {
            SqlConnection connection = new SqlConnection(conexion);
            SqlCommand command = new SqlCommand();
            List<Comprador> compradoresPorGenero = new List<Comprador>();
            Comprador comprador;
            Entrada entrada;
            Pelicula pelicula;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = $"SELECT T.id,T.titulo,T.cantEntradas,T.tipoPelicula,T.horario,T.precio,T.idComprador,U.nombre,U.dni,U.usuario,U.contraseña,U.genero " +
                    $"FROM Tickets T INNER JOIN UsuariosRegistrados U ON T.idComprador = U.id WHERE U.genero = '{genero}'";
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    pelicula = new Pelicula();
                    pelicula.Nombre = dataReader["titulo"].ToString();
                    entrada = new Entrada(int.Parse(dataReader["id"].ToString()), pelicula, dataReader["tipoPelicula"].ToString(), int.Parse(dataReader["cantEntradas"].ToString()));
                    comprador = new Comprador(int.Parse(dataReader["idComprador"].ToString()), entrada, dataReader["nombre"].ToString(), dataReader["horario"].ToString());
                    compradoresPorGenero.Add(comprador);
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return compradoresPorGenero;
        }
    }
}
