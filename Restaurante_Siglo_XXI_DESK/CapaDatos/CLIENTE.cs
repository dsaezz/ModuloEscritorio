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
    
    public partial class CLIENTE
    {
        public CLIENTE()
        {
            this.RESERVA = new HashSet<RESERVA>();
        }
    
        public decimal ID_CLIENTE { get; set; }
        public string RUT { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string CORREO { get; set; }
        public string DIRECCION { get; set; }
        public string CLAVE { get; set; }
        public string ACTIVO { get; set; }
    
        public virtual ICollection<RESERVA> RESERVA { get; set; }
    }
}
