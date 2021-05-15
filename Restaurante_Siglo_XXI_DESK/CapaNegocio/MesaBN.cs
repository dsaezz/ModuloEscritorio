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

    public class MesaBN
    {
        private DBEntities conexion;
        public MesaBN()
        {
            conexion = new DBEntities();
        }

        public DataTable listarMesa()
        {
            
            OracleConnection conn = new OracleConnection("PASSWORD=123;USER ID= ANGEL;DATA SOURCE=localhost:1521/orcl;");
            conn.Open();
            OracleCommand cmd = new OracleCommand("LISTARMESA", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("REG", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public void agregarMesa(Int32 id, Int32 num_asiento, string estadoMesa,string rut,Int32 rol)
        {
            conexion.AGREGARMESA( id,  num_asiento,  estadoMesa,rut,rol,"1");
            conexion.SaveChanges();
        }
        public void eliminarMesa(Int32 id)
        {
            conexion.ELIMINARMESA(id);
            conexion.SaveChanges();
        }
        public void modificarMesa(Int32 id, Int32 num_asiento, string estadoMesa, string rut, Int32 rol)
        {
            conexion.MODIFICARMESA(id, num_asiento, estadoMesa, rol, rut, "1");
            conexion.SaveChanges();

        }

    }
    
}
