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
    
    public partial class REPORTE_FINANZA
    {
        public decimal ID_REPORTE { get; set; }
        public System.DateTime FECHA { get; set; }
        public decimal TOTAL_GASTADO { get; set; }
        public decimal TOTAL_BRUTA { get; set; }
        public decimal GANANCIA_NETA { get; set; }
        public string USUARIO_RUT { get; set; }
        public decimal USUARIO_ROL_ID_ROL { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
    }
}
