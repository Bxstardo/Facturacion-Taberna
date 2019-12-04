using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    public class factura : Conexion
    {


        private string fecha_factura;
        private int identificacionemp;
        private int identificacioncli;
        private string modo_pago;



        public int IdentificacionEmp
        {
            get { return identificacionemp; }
            set { identificacionemp = value; }
        }

        public int IdentificacionCli
        {
            get { return identificacioncli; }
            set { identificacioncli = value; }
        }

        public string Fecha_Factura
        {
            get { return fecha_factura; }
            set { fecha_factura = value; }
        }

        public string Modo_Pago
        {
            get { return modo_pago; }
            set { modo_pago = value; }
        }



        //public bool InsertarFactura()
        //{
        //    string ProcedimientoInsertar = "Insert into factura(identificacionemp, identificacioncli) values (" + this.identificacionemp + "," + this.identificacioncli + ")";

        //    bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        //}

        public DataSet InsertarFactura()
        {
            string ProcedimientoDeConsulta = "Insert into factura(identificacionemp, identificacioncli) values (" + this.identificacionemp + " , "+this.identificacioncli+") Select SCOPE_IDENTITY() as num_facturaa";
            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public bool InsertarFactura2(int num_factura)
        {
            string ProcedimientoInsertar = "update factura set modo_pago = '" + this.modo_pago + "' where num_factura = "+ num_factura;

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public DataSet ConsultarFactura2(int num_factura)
        {
            string ProcedimientoDeConsulta = "select * from factura where num_factura = "+ num_factura;

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }




    }
}
