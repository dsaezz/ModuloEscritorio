using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//para hacer uso de la base de datos Oracle
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class RolBN
    {
        private DBEntities conexion;
        public RolBN()
        {
            conexion = new DBEntities();
        }
        public decimal id_rol { get; set; }
        public string tipo_rol { get; set; }

        public RolBN(ROL rolBD)
        {
            id_rol = rolBD.ID_ROL;
            tipo_rol = rolBD.TIPO_ROL;
        }
        public List<RolBN> obtenerRol()
        {
            List<ROL> lista = conexion.ROL.ToList();
            List<RolBN> lstRetorno = new List<RolBN>();

            foreach (var item in lista)
            {
                lstRetorno.Add(new RolBN(item));
            }
            return lstRetorno;
        }

       
    }
}
