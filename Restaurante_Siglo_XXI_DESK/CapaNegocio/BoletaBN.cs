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
        public void agregarBoleta(int total_pagar,int monto_pagado, DateTime fecha_boleta, int cambio, int pedido_id_pedido, int pedido_mesa_id_mesa, int nropago)
        {

        conexion.AGREGARBOLETA(total_pagar, monto_pagado, fecha_boleta, cambio, pedido_id_pedido, pedido_mesa_id_mesa,nropago);
        conexion.SaveChanges();
        }
    }
}
