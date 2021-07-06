using CapaDatos;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class BoletaBN
    {
        private DBEntities conexion;
        
        public decimal id_boleta { get; set; }
        public decimal total_pagar { get; set; }
        public decimal monto_pagado { get; set; }
        public System.DateTime fecha_boleta { get; set; }
        public decimal cambio { get; set; }
        public decimal pedido_id_pedido { get; set; }
        public decimal pedido_mesa_id_mesa { get; set; }
        public decimal nro_pago { get; set; }
        public BoletaBN()
        {
            conexion = new DBEntities();
        }
        public BoletaBN(BOLETA boletaBD)
        {
            total_pagar = boletaBD.TOTAL_PAGAR;
            monto_pagado = boletaBD.MONTO_PAGADO;
            fecha_boleta = boletaBD.FECHA_BOLETA;
            cambio = boletaBD.CAMBIO;
    }
        public void agregarBoleta(Int32 total_pagar, Int32 monto_pagado, DateTime fecha_boleta, Int32 cambio, Int32 pedido_id_pedido, Int32 pedido_mesa_id_mesa, Int32 nropago)
        {

        //conexion.AGREGARBOLETA(total_pagar, monto_pagado, fecha_boleta, cambio, pedido_id_pedido, pedido_mesa_id_mesa,nropago);
        conexion.SaveChanges();
        }

        public List<BoletaBN> listarBoleta()
        {
            //conexion.BOLETA.Find();
            List<BOLETA> lista = conexion.BOLETA.ToList();
            List<BoletaBN> lstRetorno = new List<BoletaBN>();

            foreach (var item in lista)
            {
                
            lstRetorno.Add(new BoletaBN(item));
            }
            return lstRetorno;
        }
        public List<BoletaBN> listaDia(DateTime fecha)
        {
            
            var resultado = from b in conexion.BOLETA.ToList()
                            where Convert.ToDateTime(b.FECHA_BOLETA.ToString("dd/MM/yyyy")) == Convert.ToDateTime(fecha.ToString("dd/MM/yyyy"))
                            select b;
            List<BoletaBN> lst = new List<BoletaBN>();
            foreach (var item in resultado)
            {
                lst.Add(new BoletaBN(item));

            }
            return lst;

        }
        public List<BoletaBN> listaMes(DateTime fecha)
        {

            var resultado = from b in conexion.BOLETA.ToList()
                            where Convert.ToDateTime(b.FECHA_BOLETA.ToString("MM/yyyy")) == Convert.ToDateTime(fecha.ToString("MM/yyyy"))
                            select b;
            List<BoletaBN> lst = new List<BoletaBN>();
            foreach (var item in resultado)
            {
                lst.Add(new BoletaBN(item));

            }
            return lst;


        }
        public DataTable RePCLIENTEMENSUAL(string fechaini, string fechafin)
        {
            OracleConnection conn = new OracleConnection("PASSWORD=1234;USER ID= SIGLOXXI;DATA SOURCE=localhost:1521/orcl;");
            conn.Open();
            OracleCommand cmd = new OracleCommand("RPCLIENTEMENSUAL", conn);
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

        public DataTable RPENGRESO()
        {
            OracleConnection conn = new OracleConnection("PASSWORD=1234;USER ID= SIGLOXXI;DATA SOURCE=localhost:1521/orcl;");
            conn.Open();
            OracleCommand cmd = new OracleCommand("RPENGRESO", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("REG", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            

            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable RPINGRESO()
        {
            OracleConnection conn = new OracleConnection("PASSWORD=1234;USER ID= SIGLOXXI;DATA SOURCE=localhost:1521/orcl;");
            conn.Open();
            OracleCommand cmd = new OracleCommand("RPINGRESO", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("REG", OracleDbType.RefCursor).Direction = ParameterDirection.Output;


            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }



    }
}
