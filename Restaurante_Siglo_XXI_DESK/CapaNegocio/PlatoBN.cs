using CapaDatos;
using System;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio
{

    public class PlatoBN
    {
        public decimal id_plato { get; set; }
        public byte[] imagen_plato { get; set; }
        public decimal precio { get; set; }
        public string nombre_plato { get; set; }
        public string usuario_rut { get; set; }
        public decimal usuario_rol_id_rol { get; set; }

        private DBEntities conexion;

        public PlatoBN()
        {
            conexion = new DBEntities();
        }
        public PlatoBN(PLATO platoBD)
        {
            id_plato = platoBD.ID_PLATO;
            imagen_plato = platoBD.IMAGEN_PLATO;
            precio = platoBD.PRECIO;
            nombre_plato = platoBD.NOMBRE_PLATO;
            usuario_rut = platoBD.USUARIO_RUT;
            usuario_rol_id_rol = platoBD.USUARIO_ROL_ID_ROL;
        }
        public DataTable REPplato(string fechaini, string fechafin)
        {
            OracleConnection conn = new OracleConnection("PASSWORD=1234;USER ID= SIGLOXXI;DATA SOURCE=localhost:1521/orcl;");
            conn.Open();
            OracleCommand cmd = new OracleCommand("RPPLATO", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("REG", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("FECHAINI", OracleDbType.Varchar2).Value = fechaini;
            cmd.Parameters.Add("FECHAFIN", OracleDbType.Varchar2).Value = fechafin;

            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

    }
}
