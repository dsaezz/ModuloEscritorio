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
        public decimal boleta_id_boleta { get; set; }
        public string activo { get; set; }
        
        private DBEntities conexion;

        public MetodoPagoBN()
        {
            conexion = new DBEntities();
        }
    }
}
