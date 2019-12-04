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
    public partial class cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          

            clientes ObjCli = new clientes();
            try
            {
                ObjCli.Nombre = TextBox18.Text;
                ObjCli.Apellido = TextBox1.Text;
                ObjCli.IdentificacionCli = int.Parse(TextBox19.Text);
                ObjCli.Celular = int.Parse(TextBox20.Text);
                ObjCli.Edad = TextBox21.Text;


                bool respuestasql = ObjCli.InsertarCliente();

                if (respuestasql == true)
                {
                    MessageBox.alert("El cliente se ha ingresado correctamente");
                    TextBox18.Text = "";
                    TextBox1.Text = "";
                    TextBox20.Text = "";
                    TextBox21.Text = "";
                    TextBox19.Text = "";
                    TextBox17.Text = "";
                    GridView1.DataBind();

                }
                else
                {
                    MessageBox.alert("El cliente tuvo problemas para ingresar. Talves tu identificacion ya exista en la base de datos ");
                }

            }
            catch
            {
              
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            clientes ObjCli = new clientes();
            try
            {

                DataSet DatosAdm = ObjCli.ConsultarCliente();


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

            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox17.Text == "")
            {
                MessageBox.alert("No deje el campo vacio");
            }
            else
            {
                clientes ObjCli = new clientes();
                try
                {

                    ObjCli.Nombre = TextBox18.Text;
                    ObjCli.Apellido = TextBox1.Text;
                    ObjCli.IdentificacionCli = int.Parse(TextBox19.Text);
                    ObjCli.Celular = int.Parse(TextBox20.Text);
                    ObjCli.Edad = TextBox21.Text;

                    bool respuestasql = ObjCli.ActualizarCliente();

                    if (respuestasql == true)
                    {
                        MessageBox.alert("El cliente se ha actualizado correctamente");
                        GridView1.DataBind();
                    }
                    else
                    {
                        MessageBox.alert("El cliente tuvo problemas para actualizar datos. Talves no exista la identificacion en la base de datos");
                    }

                }
                catch
                {

                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox17.Text == "")
            {
                MessageBox.alert("No deje el campo vacio");
            }
            else
            {
                clientes ObjCli = new clientes();
                try
                {
                    ObjCli.IdentificacionCli = int.Parse(TextBox17.Text);



                    bool respuestasql = ObjCli.EliminarCliente();

                    if (respuestasql == true)
                    {
                        MessageBox.alert("El cliente se ha eliminado correctamente");
                        TextBox18.Text = "";
                        TextBox1.Text = "";
                        TextBox20.Text = "";
                        TextBox21.Text = "";
                        TextBox19.Text = "";
                        TextBox17.Text = "";
                        GridView1.DataBind();
                    }
                    else
                    {
                        MessageBox.alert("El cliente tuvo problemas para eliminar datos.");
                    }

                }
                catch
                {

                }
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            clientes ObjCli = new clientes();
            try
            {
                ObjCli.IdentificacionCli = int.Parse(TextBox17.Text);
                DataSet DatosAdm = ObjCli.ConsultarCliente2();


                DataTable DatosConsultados = DatosAdm.Tables["DatosConsultados"];


                int numregistros = DatosConsultados.Rows.Count;


                if (numregistros == 0)
                {
                    MessageBox.alert("No hay datos en la base de datos");
                }
                else
                {
                    TextBox18.Text = DatosConsultados.Rows[0]["nombre"].ToString();
                    TextBox1.Text = DatosConsultados.Rows[0]["apellido"].ToString();
                    TextBox19.Text = DatosConsultados.Rows[0]["identificacioncli"].ToString();
                    TextBox20.Text = DatosConsultados.Rows[0]["celular"].ToString();
                    TextBox21.Text = DatosConsultados.Rows[0]["edad"].ToString();
   

                }

            }
            catch
            {

            }
        }
    }
}