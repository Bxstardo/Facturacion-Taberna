using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    public class Empleadoo : Conexion
    {

        private int identificacionemp;
        private string nombre;
        private string apellido;
        private string direccion;
        private string cargo;
        private string email;
        private string eps;
        private string contraseña;
        private int identificacionadm;


        public int IdentificacionEmp
        {
            get { return identificacionemp; }
            set { identificacionemp = value; }
        }
        public int IdentificacionAdm
        {
            get { return identificacionadm; }
            set { identificacionadm = value; }
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

        public string Eps
        {
            get { return eps; }
            set { eps = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public DataSet Login()
        {
            string ProcedimientoDeConsulta = "select * from empleado where identificacionemp= " + this.identificacionemp + " and contraseña= '" + this.contraseña + "'";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public bool InsertarEmpleado()
        {
            string ProcedimientoInsertar = "Insert into empleado (identificacionemp, nombre,apellido, direccion, cargo, email, eps, contraseña) values (" + this.identificacionemp + ",'" + this.nombre + "','" + this.apellido + "','" + this.direccion + "','" + this.cargo + "','" + this.email + "','" + this.eps + "','" + this.contraseña+ "')";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }


        public bool ActualizarEmpleado()
        {
            string ProcedimientoInsertar = "update empleado set nombre ='" + this.nombre+ "', apellido='" + this.apellido+ "', direccion ='" + this.direccion + "', cargo= '" + this.cargo + "', email='" + this.email + "', eps='" + this.eps + "', contraseña='" + this.contraseña+"' where identificacionemp = " + this.identificacionemp;

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }


        public DataSet ConsultarEmpleado()
        {
            string ProcedimientoDeConsulta = "select * from Empleado";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public bool EliminarEmpleado()
        {
            string ProcedimientoInsertar = "Delete from empleado where identificacionemp = "+this.identificacionemp;

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }


        public DataSet ConsultarEmpleado2()
        {
            string ProcedimientoDeConsulta = "select * from Empleado where identificacionemp ="+ this.identificacionemp;

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }
    }
}
