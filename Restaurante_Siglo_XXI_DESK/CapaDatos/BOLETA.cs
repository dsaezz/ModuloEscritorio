//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class BOLETA
    {
        public BOLETA()
        {
            this.METODO_PAGO = new HashSet<METODO_PAGO>();
        }
    
        public decimal ID_BOLETA { get; set; }
        public decimal TOTAL_PAGAR { get; set; }
        public decimal MONTO_PAGADO { get; set; }
        public System.DateTime FECHA_BOLETA { get; set; }
        public decimal CAMBIO { get; set; }
        public decimal PEDIDO_ID_PEDIDO { get; set; }
        public decimal PEDIDO_MESA_ID_MESA { get; set; }
    
        public virtual PEDIDO PEDIDO { get; set; }
        public virtual ICollection<METODO_PAGO> METODO_PAGO { get; set; }
    }
}
