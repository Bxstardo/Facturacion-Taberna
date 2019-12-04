using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    public class productoss : Conexion
    {

        private int codigo;
        private string fecha_de_entrada;
        private string fecha_de_salida;
        private string fecha_de_vencimiento;
        private int precio;
        private int cantidad_de_productos;
        private string tipo_producto;
        private int id_provedores;
        private string nombre;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Fecha_De_Entrada
        {
            get { return fecha_de_entrada; }
            set { fecha_de_entrada = value; }
        }
        public string Fecha_De_Salida
        {
            get { return fecha_de_salida; }
            set { fecha_de_salida = value; }
        }
        public string Fecha_De_Vencimiento
        {
            get { return fecha_de_vencimiento; }
            set { fecha_de_vencimiento = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Cantidad_De_Productos
        {
            get { return cantidad_de_productos; }
            set { cantidad_de_productos = value; }
        }
        public string Tipo_Producto
        {
            get { return tipo_producto; }
            set { tipo_producto = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Id_Provedores
        {
            get { return id_provedores; }
            set { id_provedores = value; }
        }


        public bool InsertarProducto(string nombre2)
        {
            string ProcedimientoInsertar = "if not exists (select * from productos where nombre ='" + this.nombre + "') Insert into productos (nombre, fecha_de_entrada, fecha_de_salida,fecha_de_vencimiento, precio, cantidad_de_productos, tipo_producto, id_provedores) values ('" + this.nombre + "','" + this.fecha_de_entrada+ "','" + this.fecha_de_salida + "','" + this.fecha_de_vencimiento + "'," + this.precio + "," + this.cantidad_de_productos + ",'" + this.tipo_producto + "',(select id_provedores from provedores where nombre = '" + nombre2 + "'))";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }


        public bool ActualizarProducto(string nombre2, string nombre3)
        {
            string ProcedimientoInsertar = "update productos set nombre = '"+this.nombre+"' ,fecha_de_entrada ='" + this.fecha_de_entrada + "', fecha_de_salida='" + this.fecha_de_salida + "', fecha_de_vencimiento ='" + this.fecha_de_vencimiento + "', precio= " + this.precio + ", cantidad_de_productos=" + this.cantidad_de_productos + ",tipo_producto='" + this.tipo_producto + "',id_provedores = (select id_provedores from provedores where nombre = '" + nombre2 + "') where nombre = '" + nombre3 +"'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }


        public DataSet ConsultarProducto()
        {
            string ProcedimientoDeConsulta = "select P.nombre, P.fecha_de_entrada , P.fecha_de_salida, P.fecha_de_vencimiento, P.precio, P.cantidad_de_productos, P.tipo_producto, Pr.nombre as proveedor from Productos as P inner join Provedores as Pr on P.id_provedores = Pr.id_provedores";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }
        public DataSet ConsultarProducto3()
        {
            string ProcedimientoDeConsulta = "select * from productos";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public bool EliminarProducto()
        {
            string ProcedimientoInsertar = "Delete from Productos where  nombre = '" + this.nombre + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public bool DescontarProducto()
        {
            string ProcedimientoInsertar = "Update productos set cantidad_de_productos = "+ this.cantidad_de_productos;

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }


        public DataSet ConsultarProducto2(string nombre2)
        {
            string ProcedimientoDeConsulta = "select P.nombre, P.fecha_de_entrada , P.fecha_de_salida, P.fecha_de_vencimiento, P.precio, P.cantidad_de_productos, P.tipo_producto, Pr.nombre as proveedor from Productos as P inner join Provedores as Pr on P.id_provedores = Pr.id_provedores where P.nombre ='" + nombre2 + "'";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }
    }
}
