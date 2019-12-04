using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    public class ventass : Conexion
    {

        private int numero_de_ventas;
        private int suma_total;
        private int identificacionemp;


        public int IdentificacionEmp
        {
            get { return identificacionemp; }
            set { identificacionemp = value; }
        }

        public int Numero_De_Ventas
        {
            get { return numero_de_ventas; }
            set { numero_de_ventas = value; }
        }

        public int Suma_Total
        {
            get { return suma_total; }
            set { suma_total = value; }
        }

        //public DataSet InsertarVenta()
        //{
        //    string ProcedimientoInsertar = "Insert into ventas(identificacionemp) values (" + this.identificacionemp + ")";

        //    DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        //}

        public bool InsertarVenta2(int id_ventas)
        {
            string ProcedimientoInsertar = "update ventas set suma_total = "+ this.suma_total + " , numero_de_ventas = "+ this.numero_de_ventas + " where id_ventas = "+ id_ventas;

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }
        public DataSet ConsultarVenta()
        {
            string ProcedimientoDeConsulta = "select id_ventas from ventas where identificacionemp = "+ this.identificacionemp;

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public DataSet InsertarVenta()
        {
            string ProcedimientoDeConsulta = "Insert into ventas(identificacionemp) values (" + this.identificacionemp + ") Select SCOPE_IDENTITY() as id_ventass ";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

    }
}
