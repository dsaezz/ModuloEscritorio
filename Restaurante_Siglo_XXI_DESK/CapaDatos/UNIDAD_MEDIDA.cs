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
    
    public partial class UNIDAD_MEDIDA
    {
        public UNIDAD_MEDIDA()
        {
            this.PRODUCTO = new HashSet<PRODUCTO>();
        }
    
        public decimal ID_MEDIDA { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<PRODUCTO> PRODUCTO { get; set; }
    }
}
