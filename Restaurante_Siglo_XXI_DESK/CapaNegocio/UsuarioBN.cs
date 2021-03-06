using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//para hacer uso de la base de datos Oracle
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{

    public class UsuarioBN
    {
        
        private DBEntities conexion;

        public string rut { get; set; }
        public string nombre { get; set; }
        public string apellido_p { get; set; }
        public string apellido_m { get; set; }
        public RolBN rol_id_rol { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public string contrasena { get; set; }



        

        public UsuarioBN()
        {
            conexion = new DBEntities();
        }
        public UsuarioBN(USUARIO usuarioBD)
        {
            rut = usuarioBD.RUT;
            nombre = usuarioBD.NOMBRE;
            apellido_p = usuarioBD.APELLIDO_P;
            apellido_m = usuarioBD.APELLIDO_M;
            rol_id_rol = new RolBN(usuarioBD.ROL);
            correo = usuarioBD.CORREO;
            direccion = usuarioBD.DIRECCION;
            contrasena = usuarioBD.CLAVE;
        }


        public string ValidarUsuario(string usuario, string clave)
        {
            string msj = "";
            var resultado = (from u in conexion.USUARIO
                             where u.CORREO == usuario && u.CLAVE == clave
                             select u).FirstOrDefault();
            if (resultado != null)
            {
                msj = "Bienvenido";
                return msj;
            }
            else
            {
                msj = "Error: Los datos son incorrectos";
                return msj;
            }
            

        }


        public DataTable listarUsuario()
        {
            OracleConnection conn = new OracleConnection("PASSWORD=123;USER ID= ANGEL;DATA SOURCE=localhost:1521/orcl;");
            conn.Open();
            OracleCommand cmd = new OracleCommand("LISTARUSUARIO", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("REG", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            
            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;

        }
        public void agregarUsuario(string rut,string nombre, string apellidoM, string apellidoP,Int32 rol,string correo,string direccion, string clave)
        {
            conexion.AGREGARUSUARIO(rut,nombre,apellidoP,apellidoM,rol,correo,direccion,clave,"1");
            conexion.SaveChanges();
        }

        public void eliminarUsuario(string rut)
        {
            conexion.ELIMINARUSUARIO(rut);
            conexion.SaveChanges();
        }

        public void modificarUsuario(string rut, string nombre, string apellidoM, string apellidoP, Int32 rol, string correo, string direccion, string clave)
        {
            conexion.MODIFICARUSUARIO(rut, nombre, apellidoP, apellidoM, rol, correo, direccion, clave,"1");
            conexion.SaveChanges();
        }
        public decimal BuscarRolUser(string rut)
        {
            var resultado = (from u in conexion.USUARIO
                             where u.RUT == rut
                             select new { u.ROL_ID_ROL }).Single();
            decimal rol = resultado.ROL_ID_ROL;
            return rol;
        }
    }
}
