﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class DBEntities : DbContext
    {
        public DBEntities()
            : base("name=DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BEBESTIBLE> BEBESTIBLE { get; set; }
        public DbSet<BOLETA> BOLETA { get; set; }
        public DbSet<FACTURA_COMPRA> FACTURA_COMPRA { get; set; }
        public DbSet<MESA> MESA { get; set; }
        public DbSet<METODO_PAGO> METODO_PAGO { get; set; }
        public DbSet<ORDEN> ORDEN { get; set; }
        public DbSet<PEDIDO> PEDIDO { get; set; }
        public DbSet<PLATO> PLATO { get; set; }
        public DbSet<PREPARACION> PREPARACION { get; set; }
        public DbSet<PRODUCTO> PRODUCTO { get; set; }
        public DbSet<PROVEEDOR> PROVEEDOR { get; set; }
        public DbSet<REPORTE_FINANZA> REPORTE_FINANZA { get; set; }
        public DbSet<RESERVA> RESERVA { get; set; }
        public DbSet<ROL> ROL { get; set; }
        public DbSet<UNIDAD_MEDIDA> UNIDAD_MEDIDA { get; set; }
        public DbSet<USUARIO> USUARIO { get; set; }
    
        public virtual int AGREGARMESA(Nullable<decimal> iDMESA, Nullable<decimal> nUMASIENTO, string eSTADOMESA)
        {
            var iDMESAParameter = iDMESA.HasValue ?
                new ObjectParameter("IDMESA", iDMESA) :
                new ObjectParameter("IDMESA", typeof(decimal));
    
            var nUMASIENTOParameter = nUMASIENTO.HasValue ?
                new ObjectParameter("NUMASIENTO", nUMASIENTO) :
                new ObjectParameter("NUMASIENTO", typeof(decimal));
    
            var eSTADOMESAParameter = eSTADOMESA != null ?
                new ObjectParameter("ESTADOMESA", eSTADOMESA) :
                new ObjectParameter("ESTADOMESA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AGREGARMESA", iDMESAParameter, nUMASIENTOParameter, eSTADOMESAParameter);
        }
    
        public virtual int AGREGARPRODUCTO(Nullable<decimal> iDPRODUCTO, Nullable<decimal> sTOCK, string tIPOPRODUCTO, Nullable<decimal> uNIDADMEDIDAID)
        {
            var iDPRODUCTOParameter = iDPRODUCTO.HasValue ?
                new ObjectParameter("IDPRODUCTO", iDPRODUCTO) :
                new ObjectParameter("IDPRODUCTO", typeof(decimal));
    
            var sTOCKParameter = sTOCK.HasValue ?
                new ObjectParameter("STOCK", sTOCK) :
                new ObjectParameter("STOCK", typeof(decimal));
    
            var tIPOPRODUCTOParameter = tIPOPRODUCTO != null ?
                new ObjectParameter("TIPOPRODUCTO", tIPOPRODUCTO) :
                new ObjectParameter("TIPOPRODUCTO", typeof(string));
    
            var uNIDADMEDIDAIDParameter = uNIDADMEDIDAID.HasValue ?
                new ObjectParameter("UNIDADMEDIDAID", uNIDADMEDIDAID) :
                new ObjectParameter("UNIDADMEDIDAID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AGREGARPRODUCTO", iDPRODUCTOParameter, sTOCKParameter, tIPOPRODUCTOParameter, uNIDADMEDIDAIDParameter);
        }
    
        public virtual int AGREGARPROVEEDOR(Nullable<decimal> iDPROVEEDOR, string tIPOPROVEEDOR, string nOMBRES)
        {
            var iDPROVEEDORParameter = iDPROVEEDOR.HasValue ?
                new ObjectParameter("IDPROVEEDOR", iDPROVEEDOR) :
                new ObjectParameter("IDPROVEEDOR", typeof(decimal));
    
            var tIPOPROVEEDORParameter = tIPOPROVEEDOR != null ?
                new ObjectParameter("TIPOPROVEEDOR", tIPOPROVEEDOR) :
                new ObjectParameter("TIPOPROVEEDOR", typeof(string));
    
            var nOMBRESParameter = nOMBRES != null ?
                new ObjectParameter("NOMBRES", nOMBRES) :
                new ObjectParameter("NOMBRES", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AGREGARPROVEEDOR", iDPROVEEDORParameter, tIPOPROVEEDORParameter, nOMBRESParameter);
        }
    
        public virtual int AGREGARRESERVA(Nullable<decimal> iDRESERVA, Nullable<decimal> hORAS, Nullable<System.DateTime> fECHAS, string eSTADORESERVA, string uSUARIORUT, Nullable<decimal> uSUARIOROL)
        {
            var iDRESERVAParameter = iDRESERVA.HasValue ?
                new ObjectParameter("IDRESERVA", iDRESERVA) :
                new ObjectParameter("IDRESERVA", typeof(decimal));
    
            var hORASParameter = hORAS.HasValue ?
                new ObjectParameter("HORAS", hORAS) :
                new ObjectParameter("HORAS", typeof(decimal));
    
            var fECHASParameter = fECHAS.HasValue ?
                new ObjectParameter("FECHAS", fECHAS) :
                new ObjectParameter("FECHAS", typeof(System.DateTime));
    
            var eSTADORESERVAParameter = eSTADORESERVA != null ?
                new ObjectParameter("ESTADORESERVA", eSTADORESERVA) :
                new ObjectParameter("ESTADORESERVA", typeof(string));
    
            var uSUARIORUTParameter = uSUARIORUT != null ?
                new ObjectParameter("USUARIORUT", uSUARIORUT) :
                new ObjectParameter("USUARIORUT", typeof(string));
    
            var uSUARIOROLParameter = uSUARIOROL.HasValue ?
                new ObjectParameter("USUARIOROL", uSUARIOROL) :
                new ObjectParameter("USUARIOROL", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AGREGARRESERVA", iDRESERVAParameter, hORASParameter, fECHASParameter, eSTADORESERVAParameter, uSUARIORUTParameter, uSUARIOROLParameter);
        }
    
        public virtual int AGREGARUSUARIO(string rUT, string nOMBRES, string aPELLIDOP, string aPELLIDOM, Nullable<decimal> rOLIDROL, string cORREOS, string dIRECCIONES, string cLAVES)
        {
            var rUTParameter = rUT != null ?
                new ObjectParameter("RUT", rUT) :
                new ObjectParameter("RUT", typeof(string));
    
            var nOMBRESParameter = nOMBRES != null ?
                new ObjectParameter("NOMBRES", nOMBRES) :
                new ObjectParameter("NOMBRES", typeof(string));
    
            var aPELLIDOPParameter = aPELLIDOP != null ?
                new ObjectParameter("APELLIDOP", aPELLIDOP) :
                new ObjectParameter("APELLIDOP", typeof(string));
    
            var aPELLIDOMParameter = aPELLIDOM != null ?
                new ObjectParameter("APELLIDOM", aPELLIDOM) :
                new ObjectParameter("APELLIDOM", typeof(string));
    
            var rOLIDROLParameter = rOLIDROL.HasValue ?
                new ObjectParameter("ROLIDROL", rOLIDROL) :
                new ObjectParameter("ROLIDROL", typeof(decimal));
    
            var cORREOSParameter = cORREOS != null ?
                new ObjectParameter("CORREOS", cORREOS) :
                new ObjectParameter("CORREOS", typeof(string));
    
            var dIRECCIONESParameter = dIRECCIONES != null ?
                new ObjectParameter("DIRECCIONES", dIRECCIONES) :
                new ObjectParameter("DIRECCIONES", typeof(string));
    
            var cLAVESParameter = cLAVES != null ?
                new ObjectParameter("CLAVES", cLAVES) :
                new ObjectParameter("CLAVES", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AGREGARUSUARIO", rUTParameter, nOMBRESParameter, aPELLIDOPParameter, aPELLIDOMParameter, rOLIDROLParameter, cORREOSParameter, dIRECCIONESParameter, cLAVESParameter);
        }
    
        public virtual int ELIMINARMESA(Nullable<decimal> iDMESA)
        {
            var iDMESAParameter = iDMESA.HasValue ?
                new ObjectParameter("IDMESA", iDMESA) :
                new ObjectParameter("IDMESA", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ELIMINARMESA", iDMESAParameter);
        }
    
        public virtual int ELIMINARPRODUCTO(Nullable<decimal> iDPRODUCTO)
        {
            var iDPRODUCTOParameter = iDPRODUCTO.HasValue ?
                new ObjectParameter("IDPRODUCTO", iDPRODUCTO) :
                new ObjectParameter("IDPRODUCTO", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ELIMINARPRODUCTO", iDPRODUCTOParameter);
        }
    
        public virtual int ELIMINARPROVEEDOR(Nullable<decimal> iDPROVEEDOR)
        {
            var iDPROVEEDORParameter = iDPROVEEDOR.HasValue ?
                new ObjectParameter("IDPROVEEDOR", iDPROVEEDOR) :
                new ObjectParameter("IDPROVEEDOR", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ELIMINARPROVEEDOR", iDPROVEEDORParameter);
        }
    
        public virtual int ELIMINARRESERVA(Nullable<decimal> iDRESERVA)
        {
            var iDRESERVAParameter = iDRESERVA.HasValue ?
                new ObjectParameter("IDRESERVA", iDRESERVA) :
                new ObjectParameter("IDRESERVA", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ELIMINARRESERVA", iDRESERVAParameter);
        }
    
        public virtual int ELIMINARUSUARIO(string rUT)
        {
            var rUTParameter = rUT != null ?
                new ObjectParameter("RUT", rUT) :
                new ObjectParameter("RUT", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ELIMINARUSUARIO", rUTParameter);
        }
    
        public virtual int LISTARMESA()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("LISTARMESA");
        }
    
        public virtual int LISTARPRODUCTO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("LISTARPRODUCTO");
        }
    
        public virtual int LISTARPROVEEDOR()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("LISTARPROVEEDOR");
        }
    
        public virtual int LISTARRESERVA()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("LISTARRESERVA");
        }
    
        public virtual int LISTARUSUARIO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("LISTARUSUARIO");
        }
    
        public virtual int MODIFICARMESA(Nullable<decimal> iDMESA, Nullable<decimal> nUMASIENTO, string eSTADOMESA)
        {
            var iDMESAParameter = iDMESA.HasValue ?
                new ObjectParameter("IDMESA", iDMESA) :
                new ObjectParameter("IDMESA", typeof(decimal));
    
            var nUMASIENTOParameter = nUMASIENTO.HasValue ?
                new ObjectParameter("NUMASIENTO", nUMASIENTO) :
                new ObjectParameter("NUMASIENTO", typeof(decimal));
    
            var eSTADOMESAParameter = eSTADOMESA != null ?
                new ObjectParameter("ESTADOMESA", eSTADOMESA) :
                new ObjectParameter("ESTADOMESA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MODIFICARMESA", iDMESAParameter, nUMASIENTOParameter, eSTADOMESAParameter);
        }
    
        public virtual int MODIFICARPRODUCTO(Nullable<decimal> iDPRODUCTO, Nullable<decimal> sTOCK, string tIPOPRODUCTO, Nullable<decimal> uNIDADMEDIDAID)
        {
            var iDPRODUCTOParameter = iDPRODUCTO.HasValue ?
                new ObjectParameter("IDPRODUCTO", iDPRODUCTO) :
                new ObjectParameter("IDPRODUCTO", typeof(decimal));
    
            var sTOCKParameter = sTOCK.HasValue ?
                new ObjectParameter("STOCK", sTOCK) :
                new ObjectParameter("STOCK", typeof(decimal));
    
            var tIPOPRODUCTOParameter = tIPOPRODUCTO != null ?
                new ObjectParameter("TIPOPRODUCTO", tIPOPRODUCTO) :
                new ObjectParameter("TIPOPRODUCTO", typeof(string));
    
            var uNIDADMEDIDAIDParameter = uNIDADMEDIDAID.HasValue ?
                new ObjectParameter("UNIDADMEDIDAID", uNIDADMEDIDAID) :
                new ObjectParameter("UNIDADMEDIDAID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MODIFICARPRODUCTO", iDPRODUCTOParameter, sTOCKParameter, tIPOPRODUCTOParameter, uNIDADMEDIDAIDParameter);
        }
    
        public virtual int MODIFICARPROVEEDOR(Nullable<decimal> iDPROVEEDOR, string tIPOPROVEEDOR, string nOMBRES)
        {
            var iDPROVEEDORParameter = iDPROVEEDOR.HasValue ?
                new ObjectParameter("IDPROVEEDOR", iDPROVEEDOR) :
                new ObjectParameter("IDPROVEEDOR", typeof(decimal));
    
            var tIPOPROVEEDORParameter = tIPOPROVEEDOR != null ?
                new ObjectParameter("TIPOPROVEEDOR", tIPOPROVEEDOR) :
                new ObjectParameter("TIPOPROVEEDOR", typeof(string));
    
            var nOMBRESParameter = nOMBRES != null ?
                new ObjectParameter("NOMBRES", nOMBRES) :
                new ObjectParameter("NOMBRES", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MODIFICARPROVEEDOR", iDPROVEEDORParameter, tIPOPROVEEDORParameter, nOMBRESParameter);
        }
    
        public virtual int MODIFICARRESERVA(Nullable<decimal> iDRESERVA, Nullable<decimal> hORAS, Nullable<System.DateTime> fECHAS, string eSTADORESERVA, string uSUARIORUT, Nullable<decimal> uSUARIOROL)
        {
            var iDRESERVAParameter = iDRESERVA.HasValue ?
                new ObjectParameter("IDRESERVA", iDRESERVA) :
                new ObjectParameter("IDRESERVA", typeof(decimal));
    
            var hORASParameter = hORAS.HasValue ?
                new ObjectParameter("HORAS", hORAS) :
                new ObjectParameter("HORAS", typeof(decimal));
    
            var fECHASParameter = fECHAS.HasValue ?
                new ObjectParameter("FECHAS", fECHAS) :
                new ObjectParameter("FECHAS", typeof(System.DateTime));
    
            var eSTADORESERVAParameter = eSTADORESERVA != null ?
                new ObjectParameter("ESTADORESERVA", eSTADORESERVA) :
                new ObjectParameter("ESTADORESERVA", typeof(string));
    
            var uSUARIORUTParameter = uSUARIORUT != null ?
                new ObjectParameter("USUARIORUT", uSUARIORUT) :
                new ObjectParameter("USUARIORUT", typeof(string));
    
            var uSUARIOROLParameter = uSUARIOROL.HasValue ?
                new ObjectParameter("USUARIOROL", uSUARIOROL) :
                new ObjectParameter("USUARIOROL", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MODIFICARRESERVA", iDRESERVAParameter, hORASParameter, fECHASParameter, eSTADORESERVAParameter, uSUARIORUTParameter, uSUARIOROLParameter);
        }
    
        public virtual int MODIFICARUSUARIO(string rUT, string nOMBRES, string aPELLIDOP, string aPELLIDOM, Nullable<decimal> rOLIDROL, string cORREOS, string dIRECCIONES, string cLAVES)
        {
            var rUTParameter = rUT != null ?
                new ObjectParameter("RUT", rUT) :
                new ObjectParameter("RUT", typeof(string));
    
            var nOMBRESParameter = nOMBRES != null ?
                new ObjectParameter("NOMBRES", nOMBRES) :
                new ObjectParameter("NOMBRES", typeof(string));
    
            var aPELLIDOPParameter = aPELLIDOP != null ?
                new ObjectParameter("APELLIDOP", aPELLIDOP) :
                new ObjectParameter("APELLIDOP", typeof(string));
    
            var aPELLIDOMParameter = aPELLIDOM != null ?
                new ObjectParameter("APELLIDOM", aPELLIDOM) :
                new ObjectParameter("APELLIDOM", typeof(string));
    
            var rOLIDROLParameter = rOLIDROL.HasValue ?
                new ObjectParameter("ROLIDROL", rOLIDROL) :
                new ObjectParameter("ROLIDROL", typeof(decimal));
    
            var cORREOSParameter = cORREOS != null ?
                new ObjectParameter("CORREOS", cORREOS) :
                new ObjectParameter("CORREOS", typeof(string));
    
            var dIRECCIONESParameter = dIRECCIONES != null ?
                new ObjectParameter("DIRECCIONES", dIRECCIONES) :
                new ObjectParameter("DIRECCIONES", typeof(string));
    
            var cLAVESParameter = cLAVES != null ?
                new ObjectParameter("CLAVES", cLAVES) :
                new ObjectParameter("CLAVES", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MODIFICARUSUARIO", rUTParameter, nOMBRESParameter, aPELLIDOPParameter, aPELLIDOMParameter, rOLIDROLParameter, cORREOSParameter, dIRECCIONESParameter, cLAVESParameter);
        }
    
        public virtual int P_USUARIO(string nOM_USER, string pASS)
        {
            var nOM_USERParameter = nOM_USER != null ?
                new ObjectParameter("NOM_USER", nOM_USER) :
                new ObjectParameter("NOM_USER", typeof(string));
    
            var pASSParameter = pASS != null ?
                new ObjectParameter("PASS", pASS) :
                new ObjectParameter("PASS", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("P_USUARIO", nOM_USERParameter, pASSParameter);
        }
    }
}