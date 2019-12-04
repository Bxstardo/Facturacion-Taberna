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
    public partial class productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Panel1.Visible = false;
                DropDownList1.Visible = true;
            }
            else
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
                        for (int i = 0; i <= numregistros - 1; i++)
                        {
                            DropDownList2.Items.Add(DatosConsultados.Rows[i]["nombre"].ToString());
                        }

                    }

                }
                catch
                {
                    MessageBox.alert(ObjPro.Mensaje);
                }
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            productoss ObjProd = new productoss(); 
            try
            {
                ObjProd.Nombre = TextBox6.Text;
                ObjProd.Fecha_De_Entrada = Calendar1.SelectedDate.ToLongDateString();
                ObjProd.Fecha_De_Salida = Calendar2.SelectedDate.ToLongDateString();
                ObjProd.Fecha_De_Vencimiento = Calendar3.SelectedDate.ToLongDateString();
                ObjProd.Precio = int.Parse(TextBox1.Text);
                ObjProd.Cantidad_De_Productos= int.Parse(TextBox2.Text);
                if (DropDownList1.Text == "Otro")
                {
                    ObjProd.Tipo_Producto = TextBox3.Text;
                }
                else
                {
                    ObjProd.Tipo_Producto = DropDownList1.Text;

                }
         

                bool respuestasql = ObjProd.InsertarProducto(DropDownList2.Text);

                if (respuestasql == true)
                {
                    MessageBox.alert("El producto se ha ingresado correctamente");
                    TextBox6.Text = "";
                    TextBox3.Text = "";
                    TextBox1.Text = "";
                    TextBox2.Text = "";
      
                }
                else
                {
                    MessageBox.alert("El producto tuvo problemas para ingresar. Talves ya exista en la base de datos ");
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

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.Text== "Otro")
            {
                Panel1.Visible = true;
                DropDownList1.Visible = false;
            }
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            productoss ObjProd = new productoss();
            try
            {
                ObjProd.Nombre = TextBox6.Text;
                ObjProd.Fecha_De_Entrada = Calendar1.SelectedDate.ToLongDateString();
                ObjProd.Fecha_De_Salida = Calendar2.SelectedDate.ToLongDateString();
                ObjProd.Fecha_De_Vencimiento = Calendar3.SelectedDate.ToLongDateString();
                ObjProd.Precio = int.Parse(TextBox1.Text);
                ObjProd.Cantidad_De_Productos = int.Parse(TextBox2.Text);
                if (DropDownList1.Text == "Otro")
                {
                    ObjProd.Tipo_Producto = TextBox3.Text;
                }
                else
                {
                    ObjProd.Tipo_Producto = DropDownList1.Text;

                }


                bool respuestasql = ObjProd.ActualizarProducto(DropDownList2.Text,TextBox5.Text);

                if (respuestasql == true)
                {
                    MessageBox.alert("El producto se ha actualizado correctamente");
                    TextBox6.Text = "";
                    TextBox3.Text = "";
                    TextBox1.Text = "";
                    TextBox2.Text = "";

                }
                else
                {
                    MessageBox.alert("El producto tuvo problemas para ingresar. Talves ya exista en la base de datos ");
                }

            }
            catch
            {

            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            productoss ObjProd = new productoss();
            try
            {

                DataSet DatosAdm = ObjProd.ConsultarProducto();


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

        protected void Button4_Click1(object sender, EventArgs e)
        {
            productoss ObjProd = new productoss();
            try
            {
                ObjProd.Nombre = TextBox5.Text;



                bool respuestasql = ObjProd.EliminarProducto();

                if (respuestasql == true)
                {
                    MessageBox.alert("El producto se ha eliminado correctamente");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    GridView1.DataBind();
                }
                else
                {
                    MessageBox.alert("El cliente tuvo problemas para eliminar datos");
                }

            }
            catch
            {

            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {

            productoss ObjProd = new productoss();
            try
            {
     
                DataSet DatosAdm = ObjProd.ConsultarProducto2(TextBox5.Text);


                DataTable DatosConsultados = DatosAdm.Tables["DatosConsultados"];


                int numregistros = DatosConsultados.Rows.Count;


                if (numregistros == 0)
                {
                    MessageBox.alert("No hay datos en la base de datos");
                }
                else
                {
                    TextBox6.Text = DatosConsultados.Rows[0]["nombre"].ToString();        
                    TextBox1.Text = DatosConsultados.Rows[0]["precio"].ToString();
                    TextBox2.Text = DatosConsultados.Rows[0]["cantidad_de_productos"].ToString();
                    TextBox3.Text = DatosConsultados.Rows[0]["cargo"].ToString();
                    Label1.Text = DatosConsultados.Rows[0]["tipo_producto"].ToString();            
                    DropDownList2.SelectedValue = DatosConsultados.Rows[0]["proveedores"].ToString();
            

                }

            }
            catch
            {

            }
        }
    }
}