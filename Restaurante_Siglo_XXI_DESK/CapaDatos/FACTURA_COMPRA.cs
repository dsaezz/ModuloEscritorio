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
    
    public partial class FACTURA_COMPRA
    {
        public decimal NRO_COMPRA { get; set; }
        public System.DateTime FECHA_PEDIDO { get; set; }
        public decimal PRODUCTO_ID_PRODUCTO { get; set; }
        public decimal PROD_U_MEDIDA_ID_MEDIDA { get; set; }
        public decimal PROVEEDOR_ID_PROVEEDOR { get; set; }
        public decimal CANTIDAD_PEDIDO { get; set; }
        public decimal PRECIO_UNITARIO { get; set; }
    
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
    }
}