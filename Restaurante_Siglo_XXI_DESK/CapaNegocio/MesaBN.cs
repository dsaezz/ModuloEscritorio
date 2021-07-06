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
        public decimal id_mesa { get; set; }
        public decimal num_asiento { get; set; }
        public string estado { get; set; }
        public string usuario_rut { get; set; }
        public decimal usuario_rol_id_rol { get; set; }
        public string activo { get; set; }
        public MesaBN()
        {
            conexion = new DBEntities();
        }
        public MesaBN(MESA mesaBD)
        {


            id_mesa = mesaBD.ID_MESA;
            num_asiento = mesaBD.NUM_ASIENTO;
            estado = mesaBD.ESTADO;
            usuario_rut = mesaBD.USUARIO_RUT;
            usuario_rol_id_rol = mesaBD.USUARIO_ROL_ID_ROL;
            activo = mesaBD.ACTIVO;
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
        public void agregarMesa( Int32 num_asiento, string estadoMesa)
        {
            UsuarioBN u = new UsuarioBN();
            conexion.AGREGARMESA(num_asiento,  estadoMesa, "00.000.000-0", 2,"1");
            conexion.SaveChanges();
        }
        public void eliminarMesa(Int32 id)
        {
            conexion.ELIMINARMESA(id);
            conexion.SaveChanges();
        }
        
        public void modificarMesa(Int32 id,Int32 num_asiento, string estadoMesa, string rut, Int32 rol)
        {
           
            conexion.MODIFICARMESA(id,num_asiento, estadoMesa, rut, rol, "1");
            conexion.SaveChanges();

        }

    
        public DataTable detalleOrden(Int32 id_mesa)
        {
            OracleConnection conn = new OracleConnection("PASSWORD=123;USER ID= ANGEL;DATA SOURCE=localhost:1521/orcl;");
            conn.Open();
            OracleCommand cmd = new OracleCommand("DETALLEORDEN", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("REG", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("ROLIDROL", OracleDbType.Int32).Value = id_mesa;

            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        
    }

}
