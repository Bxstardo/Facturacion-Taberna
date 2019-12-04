using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Logica;
using WebApplication1.Scripts;
using System.Data;

namespace WebApplication1
{
    public partial class inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            
            Administrador ObjAdm = new Administrador();
            Empleadoo ObjEmp = new Empleadoo();
            try
            {
                ObjAdm.IdentificacionAdm = int.Parse(TextBox1.Text);
                ObjAdm.Contraseña = TextBox2.Text;

                DataSet DatosAdm = ObjAdm.Login();


                DataTable DatosConsultados = DatosAdm.Tables["DatosConsultados"];


                int numregistros = DatosConsultados.Rows.Count;


                if (numregistros == 0)
                {
                    ObjEmp.IdentificacionEmp = int.Parse(TextBox1.Text);
                    ObjEmp.Contraseña = TextBox2.Text;
                    Session["Empleado"] = TextBox1.Text;
                    DataSet DatosEmp = ObjEmp.Login();


                    DataTable DatosConsultados2 = DatosEmp.Tables["DatosConsultados"];


                    int numregistros2 = DatosConsultados2.Rows.Count;

                    if (numregistros2 == 0)
                    {
                      
                        MessageBox.alert("Usuario y/o Contraseña incorrecta");
                    }
                    else
                    {
                        Response.Redirect("index2.aspx");
                  
                    }

        
                }
                else
                {
         
                    Response.Redirect("index.aspx");
                }

            }
            catch
            {

            }
       

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}