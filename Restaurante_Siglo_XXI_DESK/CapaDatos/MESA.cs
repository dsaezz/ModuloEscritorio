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
    
    public partial class MESA
    {
        public MESA()
        {
            this.PEDIDO = new HashSet<PEDIDO>();
            this.RESERVA = new HashSet<RESERVA>();
        }
    
        public decimal ID_MESA { get; set; }
        public decimal NUM_ASIENTO { get; set; }
        public string ESTADO { get; set; }
        public string USUARIO_RUT { get; set; }
        public decimal USUARIO_ROL_ID_ROL { get; set; }
        public string ACTIVO { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<PEDIDO> PEDIDO { get; set; }
        public virtual ICollection<RESERVA> RESERVA { get; set; }
    }
}
