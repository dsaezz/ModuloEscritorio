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
    public class ProveedorBN
    {
        private DBEntities conexion;
        public ProveedorBN()
        {
            conexion = new DBEntities();
        }
        public DataTable listarProveedor()
        {
            OracleConnection conn = new OracleConnection("PASSWORD=123;USER ID= ANGEL;DATA SOURCE=localhost:1521/orcl;");
            conn.Open();
            OracleCommand cmd = new OracleCommand("LISTARPROVEEDOR", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("REG", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public void agregarProveedor(Int32 id, string tipo, string nombre,string rut, string apellido,string fono,string direccion)
        {
            conexion.AGREGARPROVEEDOR(id,tipo,nombre,rut,apellido,fono,direccion,"1");
            conexion.SaveChanges();
        }

        public void eliminarProveedor(Int32 id)
        {
            conexion.ELIMINARPROVEEDOR(id);
            conexion.SaveChanges();
        }

        public void modificarProveedor(Int32 id, string tipo, string nombre, string rut, string apellido, string fono, string direccion)
        {
            conexion.MODIFICARPROVEEDOR(id,tipo,nombre,rut,apellido,fono,direccion,"1");
            conexion.SaveChanges();
        }
    }
}
