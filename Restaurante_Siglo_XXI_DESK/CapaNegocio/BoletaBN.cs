using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class BoletaBN
    {
        private DBEntities conexion;

        public BoletaBN()
        {
            conexion = new DBEntities();
        }
        public void agregarBoleta(Int32 total_pagar, Int32 monto_pagado, DateTime fecha_boleta, Int32 cambio, Int32 pedido_id_pedido, Int32 pedido_mesa_id_mesa, Int32 nropago)
        {

        conexion.AGREGARBOLETA(total_pagar, monto_pagado, fecha_boleta, cambio, pedido_id_pedido, pedido_mesa_id_mesa,nropago);
        conexion.SaveChanges();
        }
    }
}
