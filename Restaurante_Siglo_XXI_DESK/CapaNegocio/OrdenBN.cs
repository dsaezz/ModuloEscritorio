using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class OrdenBN
    {
        public decimal nro_orden { get; set; }
        public Nullable<decimal> cantidad_pla { get; set; }
        public Nullable<decimal> cantidad_beb { get; set; }
        public decimal pedido_id_pedido { get; set; }
        public decimal pedido_id_mesa { get; set; }
        public decimal plato_id_plato { get; set; }
        public decimal bebestible_id_bebestible { get; set; }

        private DBEntities conexion;

        public OrdenBN()
        {
            conexion = new DBEntities();
        }
        public OrdenBN(ORDEN ordenBD)
        {
            nro_orden = ordenBD.NRO_ORDEN;
            cantidad_pla = ordenBD.CANTIDAD_PLA;
            cantidad_beb = ordenBD.CANTIDAD_BEB;
            pedido_id_pedido = ordenBD.PEDIDO_ID_PEDIDO;
            pedido_id_mesa = ordenBD.PEDIDO_ID_MESA;
            plato_id_plato = ordenBD.PLATO_ID_PLATO;
            bebestible_id_bebestible = ordenBD.BEBESTIBLE_ID_BEBESTIBLE;
    }
        public List<string> ListaMejorPlato()
        {
            /* SELECT to_char(bo.fecha_boleta,'Month'),sum(o.cantidad_pla),pl.nombre_plato
                     FROM PEDIDO P JOIN ORDEN O ON 
                    p.mesa_id_mesa = o.pedido_id_mesa AND P.ID_PEDIDO = o.pedido_id_pedido
                    JOIN PLATO pl on
                    pl.id_plato = o.plato_id_plato
                    JOIN BEBESTIBLE B ON
                    b.id_bebestible = o.bebestible_id_bebestible
                    JOIN boleta bo on 
                    bo.pedido_id_pedido = p.id_pedido AND bo.pedido_id_mesa = p.mesa_id_mesa
                    where to_char(bo.fecha_boleta,'mm/yyyy') BETWEEN '06/2021' and '08/2021'
                    group by bo.fecha_boleta,pl.nombre_plato; */

            var resultado = (from o in conexion.ORDEN
                            join p in conexion.PEDIDO on new { x1 = o.PEDIDO_ID_MESA, x2 = o.PEDIDO_ID_PEDIDO } equals new { x1 = p.MESA_ID_MESA, x2 = p.ID_PEDIDO }
                            join pl in conexion.PLATO on o.PLATO_ID_PLATO equals pl.ID_PLATO
                            join b in conexion.BOLETA on new {y1 = p.ID_PEDIDO, y2 = p.MESA_ID_MESA} equals new { y1 = b.PEDIDO_ID_PEDIDO, y2 = b.PEDIDO_ID_MESA}
                            group new {b,pl} by new {pl.NOMBRE_PLATO, b.FECHA_BOLETA} into g                                                 
                            select g).ToList();

            List<string> lst = new List<string>();
            
              

            
            return lst;
        }
    }
}
