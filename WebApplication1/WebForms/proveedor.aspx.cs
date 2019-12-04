using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Scripts;
using Logica;
using System.Data;

namespace WebApplication1.WebForms
{
    public partial class proveedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            provedores ObjPro = new provedores();
            try
            {
                ObjPro.Nombre = TextBox1.Text;
                ObjPro.Telefono = int.Parse(TextBox4.Text);
                ObjPro.Correo = TextBox2.Text;
                ObjPro.Direccion = TextBox3.Text;


                bool respuestasql = ObjPro.InsertarProvedor();

                if (respuestasql == true)
                {
                    MessageBox.alert("El proveedor se ha ingresado correctamente");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox17.Text = "";
                    GridView1.DataBind();
                }
                else
                {
                    MessageBox.alert("hubo problemas para el insertar proveedor. Talves tu proveedor ya exista en la base de datos ");
                }

            }
            catch
            {
                MessageBox.alert(ObjPro.Mensaje);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.alert("Lo Sentimos En Estos Momentos No Se Pueden Consultar Los Datos");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.alert("Datos Actualizados Correctamente");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.alert("Se Eliminaran Los Datos");
        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            provedores ObjPro = new provedores();
            try
            {
                ObjPro.Nombre = TextBox1.Text;
                ObjPro.Telefono = int.Parse(TextBox4.Text);
                ObjPro.Correo = TextBox2.Text;
                ObjPro.Direccion = TextBox3.Text;
         

                bool respuestasql = ObjPro.ActualizarProvedor(TextBox17.Text);

                if (respuestasql == true)
                {
                    MessageBox.alert("El proveedor se ha actualizado correctamente");
                    TextBox17.Text = TextBox1.Text;
                }
                else
                {
                    MessageBox.alert("hubo problemas para el actualizar proveedor");
                }

            }
            catch
            {
                MessageBox.alert(ObjPro.Mensaje);

            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            provedores ObjPro = new provedores();
            try
            {

                DataSet DatosAdm = ObjPro.ConsultarProvedor();


                DataTable DatosConsultados = DatosAdm.Tables["DatosConsultados"];


                int numregistros = DatosConsultados.Rows.Count;


                if (numregistros == 0)
                {
                    MessageBox.alert("No hay datos en la base de datos");
                }
                else
                {
                    GridView1.DataSource = DatosConsultados;
                    GridView1.DataBind();

                }

            }
            catch
            {
                MessageBox.alert(ObjPro.Mensaje);
            }
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            provedores ObjPro = new provedores();
            try
            {
                ObjPro.Nombre = TextBox17.Text;



                bool respuestasql = ObjPro.EliminarProvedor();

                if (respuestasql == true)
                {
                    MessageBox.alert("El proveedor se ha eliminado correctamente");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox17.Text = "";
                    GridView1.DataBind();
                }
                else
                {
                    MessageBox.alert("El proveedor tuvo problemas para eliminar datos.");
                }

            }
            catch
            {
                MessageBox.alert(ObjPro.Mensaje);
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            provedores ObjPro = new provedores();
            try
            {
                ObjPro.Nombre = TextBox17.Text;
                DataSet DatosAdm = ObjPro.ConsultarProvedor2();


                DataTable DatosConsultados = DatosAdm.Tables["DatosConsultados"];


                int numregistros = DatosConsultados.Rows.Count;


                if (numregistros == 0)
                {
                    MessageBox.alert("No hay datos en la base de datos");
                }
                else
                {
                    TextBox1.Text = DatosConsultados.Rows[0]["nombre"].ToString();
                    TextBox2.Text = DatosConsultados.Rows[0]["correo"].ToString();
                    TextBox3.Text = DatosConsultados.Rows[0]["direccion"].ToString();
                    TextBox4.Text = DatosConsultados.Rows[0]["telefono"].ToString();
             


                }

            }
            catch
            {
                MessageBox.alert(ObjPro.Mensaje);
            }
        }
    }
}