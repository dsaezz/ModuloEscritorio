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
    
    public partial class BEBESTIBLE
    {
        public BEBESTIBLE()
        {
            this.ORDEN = new HashSet<ORDEN>();
            this.PREP_BEBESTIBLE = new HashSet<PREP_BEBESTIBLE>();
        }
    
        public decimal ID_BEBESTIBLE { get; set; }
        public string TIPO_BEBESTIBLE { get; set; }
        public decimal PRECIO { get; set; }
        public string NOMBRE_BEBESTIBLE { get; set; }
        public byte[] IMAGEN { get; set; }
        public string USUARIO_RUT { get; set; }
        public decimal USUARIO_ROL_ID_ROL { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<ORDEN> ORDEN { get; set; }
        public virtual ICollection<PREP_BEBESTIBLE> PREP_BEBESTIBLE { get; set; }
    }
}
