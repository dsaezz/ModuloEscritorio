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
    
    public partial class PREP_BEBESTIBLE
    {
        public decimal PRODUCTO_ID_PRODUCTO { get; set; }
        public decimal PRODUCTO_UNIDAD_MEDIDA_ID_M { get; set; }
        public decimal CANTIDAD_PRO_BEBEST { get; set; }
        public decimal BEBESTIBLE_ID_BEBESTIBLE { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal TIEMPO { get; set; }
    
        public virtual BEBESTIBLE BEBESTIBLE { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}