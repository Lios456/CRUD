using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Interaz7;

namespace Interfaz2.clases
{
    internal class ConexionMysql
    {

        private MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=root;database=interfaz7;");

        // ---------------------------------------------------------------------------------------------------------------
        public void CrearConexion()
        {
            connection.Open();

            //connection.Close();
        }
        // ---------------------------------------------------------------------------------------------------------------
        public void insertar(string sql)
        {
            CrearConexion();
            var command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        // ---------------------------------------------------------------------------------------------------------------
        public List<Usuario> Select(string sql)
        {
            CrearConexion();

            
            
            List<Usuario> usuarios = new List<Usuario>();
            
            var command = new MySqlCommand(sql, connection);
            var datos = command.ExecuteReader();
            while(datos.Read())
            {
                var usu = new Usuario();
                usu.Id = (string)datos[0];
                usu.Name = (string)datos[1];
                usu.Lastname = (string)datos[2];
                usu.Age = (int)datos[3];
                usu.Sexo = (string)datos[4];
                usu.Fecnac = Convert.ToString(datos[5]);
                usu.Peso = Convert.ToDecimal(datos[6]);
                usu.Altura = Convert.ToDecimal(datos[7]);
                usu.Hermanos = (int)datos[8];
                usu.Instruccion = (string)datos[9];
                usu.Provincia= (string)datos[10];
                usu.Canton = (string)datos[11];
                usu.Barrio = (string)datos[12];
                usu.CPostal = (string)datos[13];
                usu.Etnia = (string)datos[14];
                usuarios.Add(usu);
            }
            connection.Close();
            
            return usuarios;
        }
        // ---------------------------------------------------------------------------------------------------------------
        public void Update(string sql)
        {
            CrearConexion();
            var command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        // ---------------------------------------------------------------------------------------------------------------
        public void Delete(string sql) 
        {
            CrearConexion();
            var command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }


       
    }
}
