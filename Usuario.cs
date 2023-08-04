using Interfaz2.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interaz7
{
    public class Usuario
    {
        public string? Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Sexo { get; set; }
        public string Fecnac { get; set; }
        public decimal Peso { get; set; }
        public decimal Altura { get; set; }
        public int Hermanos { get; set; }
        public string Instruccion { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Barrio { get; set; }
        public string CPostal { get; set; }
        public string Etnia { get; set; }
        public Usuario() { }

        public void insertar(Usuario u) {

            string sql = $"insert into tbusuarios values (" +
                $"'{u.Id}'," +
                $"'{u.Name}'," +
                $"'{u.Lastname}'," +
                $"'{u.Age}'," +
                $"'{u.Sexo}'," +
                $"'{u.Fecnac}'," +
                $"'{u.Peso}'," +
                $"'{u.Altura}'," +
                $"'{u.Hermanos}'," +
                $"'{u.Instruccion}'," +
                $"'{u.Provincia}'," +
                $"'{u.Canton}'," +
                $"'{u.Barrio}'," +
                $"'{u.CPostal}'," +
                $"'{u.Etnia}')";
            new ConexionMysql().insertar(sql);
        }

        /*------------------------------------------------------------------------------------------------------*/
        public void modificar(Usuario u)
        {
            string sql = $"update tbusuarios set " +
                $"Id = '{u.Id}'," +
                $"Nombre = '{u.Name}'," +
                $"Apellido = '{u.Lastname}'," +
                $"Edad = '{u.Age}'," +
                $"Sexo = '{u.Sexo}'," +
                $"Fecnac = '{u.Fecnac}'," +
                $"Peso = '{u.Peso}'," +
                $"Altura = '{u.Altura}'," +
                $"Hermanos = '{u.Hermanos}'," +
                $"Instruccion = '{u.Instruccion}'," +
                $"Provincia = '{u.Provincia}'," +
                $"Canton = '{u.Canton}'," +
                $"Barrio = '{u.Barrio}'," +
                $"CPostal = '{u.CPostal}'," +
                $"Etnia = '{u.Etnia}'" +
                $"where Id = '{u.Id}'";
            new ConexionMysql().Update(sql);
        }

        /*------------------------------------------------------------------------------------------------------*/

        public List<Usuario> listar()
        {
            return new ConexionMysql().Select("select * from tbusuarios");
        }

        /*--------------------------------------------------------------------------------------------------------*/

        public void eliminar(Usuario u)
        {
            var sql = $"delete from tbusuarios where Id = '{u.Id}'";
            new ConexionMysql().Delete(sql);
        }

    }
}
