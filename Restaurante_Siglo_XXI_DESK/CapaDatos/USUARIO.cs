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
    
    public partial class USUARIO
    {
        public USUARIO()
        {
            this.PEDIDO = new HashSet<PEDIDO>();
            this.REPORTE_FINANZA = new HashSet<REPORTE_FINANZA>();
            this.RESERVA = new HashSet<RESERVA>();
        }
    
        public string RUT { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO_P { get; set; }
        public string APELLIDO_M { get; set; }
        public decimal ROL_ID_ROL { get; set; }
        public string CORREO { get; set; }
        public string DIRECCION { get; set; }
        public string CLAVE { get; set; }
    
        public virtual ICollection<PEDIDO> PEDIDO { get; set; }
        public virtual ICollection<REPORTE_FINANZA> REPORTE_FINANZA { get; set; }
        public virtual ICollection<RESERVA> RESERVA { get; set; }
        public virtual ROL ROL { get; set; }
    }
}
