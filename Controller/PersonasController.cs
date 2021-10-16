using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2.Controller
{
    public class PersonasController
    {
        BaseDatos bd = new BaseDatos();

        public string insertarPersonas(string documento, string nombre, string apellido, string edad, string sexo)
        {
            string sql = "INSERT INTO trabajadores.personas (Documento,Nombre,Apellido,Edad,Sexo) VALUES ('" + documento + "','" + nombre + "','" + apellido + "','" + edad + "','" + sexo + "')";
            string resultado = bd.ejecutarSQL(sql);
            return resultado;
        }

        public string actualizarPersonas(string nombre, string apellido, string edad, string sexo, string documento)
        {
            string sql = "UPDATE `trabajadores`.`personas` SET `Nombre` = '" + nombre + "', `Apellido` = '" + apellido + "', `Edad` = '" + edad + "', `sexo` = '" + sexo + "' WHERE (`Documento` = '" + documento + "')";
            string resultado = bd.ejecutarSQL(sql);
            return resultado;
        }

        public string eliminarPersonas(string documento)
        {
            string sql = "DELETE FROM `trabajadores`.`personas` WHERE(`Documento` = '" + documento + "')";
            string resultado = bd.ejecutarSQL(sql);
            return resultado;
        }

        public DataTable buscarPersonas(string documento)
        {
            string sql = "SELECT * FROM `trabajadores`.`personas` WHERE(`Documento` = '" + documento + "')";
            DataTable resultado = bd.DsplayData(sql);
            return resultado;
        }

        public DataTable mostrarPersonas()
        {
            string sql = "SELECT * FROM `trabajadores`.`personas`";
            DataTable resultado = bd.DsplayData(sql);
            return resultado;
        }


    }
}

