using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Scripts;
using Logica;
using WebApplication1.Scripts;
using System.Data;

namespace WebApplication1.WebForms
{
    public partial class empleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Empleadoo ObjEmp = new Empleadoo();
            try
            {
                ObjEmp.Nombre = TextBox10.Text;
                ObjEmp.Apellido = TextBox11.Text;
                ObjEmp.IdentificacionEmp = int.Parse(TextBox12.Text);
                ObjEmp.Direccion = TextBox13.Text;
                ObjEmp.Cargo = RadioButtonList1.Text;
                ObjEmp.Email = TextBox14.Text;
                ObjEmp.Eps = TextBox15.Text;
                ObjEmp.Contraseña = TextBox16.Text;

                bool respuestasql = ObjEmp.InsertarEmpleado();

                if (respuestasql == true)
                {
                    MessageBox.alert("El empleado se ha ingresado correctamente");
                    TextBox10.Text = "";
                    TextBox11.Text = "";
                    TextBox12.Text = "";
                    TextBox13.Text = "";
                    TextBox14.Text = "";
                    TextBox15.Text = "";
                    TextBox16.Text = "";
                    TextBox17.Text = "";
                    GridView1.DataBind();
                }
                else
                {
                    MessageBox.alert("El empleado tuvo problemas para ingresar. Talves tu identificacion ya exista en la base de datos ");
                }

            }
            catch
            {
               
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

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Empleadoo ObjEmp = new Empleadoo();
            try
            {

                DataSet DatosAdm = ObjEmp.ConsultarEmpleado();


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

        protected void Button5_Click(object sender, EventArgs e)
        {
            Empleadoo ObjEmp = new Empleadoo();
            try
            {
                ObjEmp.IdentificacionEmp = int.Parse(TextBox17.Text);
                DataSet DatosAdm = ObjEmp.ConsultarEmpleado2();


                DataTable DatosConsultados = DatosAdm.Tables["DatosConsultados"];


                int numregistros = DatosConsultados.Rows.Count;


                if (numregistros == 0)
                {
                    MessageBox.alert("No hay datos en la base de datos");
                }
                else
                {
                    TextBox10.Text = DatosConsultados.Rows[0]["nombre"].ToString();
                    TextBox11.Text = DatosConsultados.Rows[0]["apellido"].ToString();
                    TextBox12.Text = DatosConsultados.Rows[0]["identificacionemp"].ToString();
                    TextBox13.Text = DatosConsultados.Rows[0]["direccion"].ToString();
                    RadioButtonList1.SelectedValue = DatosConsultados.Rows[0]["cargo"].ToString();
                    TextBox14.Text = DatosConsultados.Rows[0]["email"].ToString();
                    TextBox15.Text = DatosConsultados.Rows[0]["eps"].ToString();
                    TextBox16.Text = DatosConsultados.Rows[0]["contraseña"].ToString(); ;

                }

            }
            catch
            {

            }
        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            Empleadoo ObjEmp = new Empleadoo();
            try
            {
                ObjEmp.Nombre = TextBox10.Text;
                ObjEmp.Apellido = TextBox11.Text;
                ObjEmp.IdentificacionEmp = int.Parse(TextBox17.Text);
         
                ObjEmp.Direccion = TextBox13.Text;
                ObjEmp.Cargo = RadioButtonList1.Text;
                ObjEmp.Email = TextBox14.Text;
                ObjEmp.Eps = TextBox15.Text;
                ObjEmp.Contraseña = TextBox16.Text;

                bool respuestasql = ObjEmp.ActualizarEmpleado();

                if (respuestasql == true)
                {
                    MessageBox.alert("El empleado se ha actualizado correctamente");
                    GridView1.DataBind();
                }
                else
                {
                    MessageBox.alert("El empleado tuvo problemas para actualizar datos. Talves no exista la identificacion en la base de datos");
                }

            }
            catch
            {

            }
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Empleadoo ObjEmp = new Empleadoo();
            try
            {
                ObjEmp.IdentificacionEmp = int.Parse(TextBox17.Text);
           
             

                bool respuestasql = ObjEmp.EliminarEmpleado();

                if (respuestasql == true)
                {
                    MessageBox.alert("El empleado se ha eliminado correctamente");
                    TextBox10.Text = "";
                    TextBox11.Text = "";
                    TextBox12.Text = "";
                    TextBox13.Text = "";
                    TextBox14.Text = "";
                    TextBox15.Text = "";
                    TextBox16.Text = "";
                    TextBox17.Text = "";
                    GridView1.DataBind();
                }
                else
                {
                    MessageBox.alert("El empleado tuvo problemas para eliminar datos. ");
                }

            }
            catch
            {

            }
        }
    }
}