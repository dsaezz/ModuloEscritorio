using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class MetodoPagoBN
    {

        public decimal nro_pago { get; set; }
        public string tipo_pago { get; set; }
        public string activo { get; set; }
        
        private DBEntities conexion;

        public MetodoPagoBN()
        {
            conexion = new DBEntities();
        }
        public MetodoPagoBN(METODO_PAGO metodoBD)
        {
            nro_pago = metodoBD.NRO_PAGO;
            tipo_pago = metodoBD.TIPO_PAGO;
        }
        
        public List<MetodoPagoBN> obtenerMetodo()
        {
            List<METODO_PAGO> lista = conexion.METODO_PAGO.ToList();
            List<MetodoPagoBN> lstRetorno = new List<MetodoPagoBN>();

            foreach (var item in lista)
            {
                MetodoPagoBN m = new MetodoPagoBN();
                m.nro_pago = item.NRO_PAGO;
                m.tipo_pago = item.TIPO_PAGO;
                
                lstRetorno.Add(m);
            }
            return lstRetorno;
        }

    }
}
