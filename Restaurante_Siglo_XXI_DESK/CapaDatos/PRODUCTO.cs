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
    
    public partial class PRODUCTO
    {
        public PRODUCTO()
        {
            this.DETALLE_F = new HashSet<DETALLE_F>();
            this.PREP_BEBESTIBLE = new HashSet<PREP_BEBESTIBLE>();
            this.PREP_PLATO = new HashSet<PREP_PLATO>();
        }
    
        public decimal ID_PRODUCTO { get; set; }
        public decimal STOCK { get; set; }
        public string TIPO_PRODUCTO { get; set; }
        public decimal UNIDAD_MEDIDA_ID_M { get; set; }
        public string ACTIVO { get; set; }
    
        public virtual ICollection<DETALLE_F> DETALLE_F { get; set; }
        public virtual ICollection<PREP_BEBESTIBLE> PREP_BEBESTIBLE { get; set; }
        public virtual ICollection<PREP_PLATO> PREP_PLATO { get; set; }
        public virtual UNIDAD_MEDIDA UNIDAD_MEDIDA { get; set; }
    }
}
