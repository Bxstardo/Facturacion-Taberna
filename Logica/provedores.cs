using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    public class provedores : Conexion
    {

        private int telefono;
        private string nombre;
        private string correo;
        private string direccion;
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public bool InsertarProvedor()
        {
            string ProcedimientoInsertar = "if not exists (select * from provedores where nombre ='"+this.nombre+"') Insert into provedores(telefono, nombre, correo, direccion) values (" + this.telefono + ",'" + this.nombre + "','" + this.correo + "','" + this.direccion + "')";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public bool ActualizarProvedor(string nombre)
        {
            string ProcedimientoInsertar = "update provedores set nombre ='" + this.nombre + "', correo='" + this.correo + "', telefono =" + this.telefono + ", direccion= '" + this.direccion + "' where nombre  = '" + nombre +"'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public DataSet ConsultarProvedor()
        {
            string ProcedimientoDeConsulta = "select * from provedores";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public bool EliminarProvedor()
        {
            string ProcedimientoInsertar = "Delete from provedores where nombre = '" + this.nombre + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public DataSet ConsultarProvedor2()
        {
            string ProcedimientoDeConsulta = "select * from provedores where nombre = '" + this.nombre + "'";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

    }
}
