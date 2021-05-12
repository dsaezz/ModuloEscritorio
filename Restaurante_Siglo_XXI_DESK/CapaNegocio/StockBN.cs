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
   public class StockBN
    {
        private DBEntities conexion;
        public StockBN()
        {
            conexion = new DBEntities();
        }
        public DataTable listarStock()
        {
            
            OracleConnection conn = new OracleConnection("PASSWORD=123;USER ID= ANGEL;DATA SOURCE=localhost:1521/orcl;");
            conn.Open();
            OracleCommand cmd = new OracleCommand("LISTARPRODUCTO", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("REG", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public void agregarStock(Int32 id, Int32 stock, string tipoProducto, Int32 idUnidadMedida)
        {
            conexion.AGREGARPRODUCTO(id,stock,tipoProducto,idUnidadMedida);
            conexion.SaveChanges();
        }

        public void eliminarStock(Int32 id)
        {
            conexion.ELIMINARPRODUCTO(id);
            conexion.SaveChanges();
        }

        public void modificarStock(Int32 id, Int32 stock, string tipoProducto, Int32 idUnidadMedida)
        {
            conexion.MODIFICARPRODUCTO(id, stock, tipoProducto, idUnidadMedida);
            conexion.SaveChanges();
        }
    }
}
