using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;


namespace Logica
{
    public class clientes : Conexion
    {
        private int identificacioncli;
        private string nombre;
        private string apellido;
        private int celular;
        private string edad;


        public int IdentificacionCli
        {
            get { return identificacioncli; }
            set { identificacioncli = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }


        public int Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }


        public bool InsertarCliente()
        {
            string ProcedimientoInsertar = "Insert into cliente(identificacioncli, nombre,apellido, celular, edad) values (" + this.identificacioncli + ",'" + this.nombre + "','" + this.apellido + "'," + this.celular + ",'"+ this.edad +"')";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public bool ActualizarCliente()
        {
            string ProcedimientoInsertar = "update cliente set nombre ='" + this.nombre + "', apellido='" + this.apellido + "', celular ='" + this.celular + "', edad= '" + this.edad + "' where identificacioncli = " + this.identificacioncli;

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public DataSet ConsultarCliente()
        {
            string ProcedimientoDeConsulta = "select * from Cliente";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public bool EliminarCliente()
        {
            string ProcedimientoInsertar = "Delete from cliente where identificacioncli = " + this.identificacioncli;

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public DataSet ConsultarCliente2()
        {
            string ProcedimientoDeConsulta = "select * from cliente where identificacioncli =" + this.identificacioncli;

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }




    }
}
