using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    public class factura_productos : Conexion
    {
        private int num_factura;
        private int codigo;
        private int cantidad;
        private int id_ventas;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int Id_Ventas
        {
            get { return id_ventas; }
            set { id_ventas = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public int Num_Factura
        {
            get { return num_factura; }
            set { num_factura = value; }
        }


        public bool InsertarFacturaPro(string producto)
        {
            string ProcedimientoInsertar = "Insert into factura_productos(codigo, cantidad,id_ventas) values ((Select codigo from productos where nombre = '"+producto+"'), "+this.cantidad+","+this.id_ventas+")";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public bool InsertarFacturaPro2()
        {
            string ProcedimientoInsertar = "update factura_productos set num_factura = "+ this.num_factura + " where id_ventas = " + this.id_ventas;

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public bool EliminarFacturaPro(string producto)
        {
            string ProcedimientoInsertar = "delete from factura_productos where id_ventas = " + this.id_ventas + " and codigo = (Select codigo from productos where nombre = '" + producto + "')";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

    }
}
