using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    public class Administrador : Conexion
    {

        private int identificacionadm;
        private string nombre;
        private string apellido;
        private int celular;
        private string eps;
        private string direccion;
        private string email;
        private string contraseña;

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

        public DataSet Login()
        {
            string ProcedimientoDeConsulta = "select * from administrador where identificacionadm= " + this.identificacionadm +" and contraseña= '"+this.contraseña +"'";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }
    }
}
