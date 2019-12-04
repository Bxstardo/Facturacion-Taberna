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
    public partial class ventas : System.Web.UI.Page
    {


        
        protected void Page_Load(object sender, EventArgs e)
        {


            if (IsPostBack)
            {
                // It is a postback
            }
            else
            {
                Session["SumaTotalD"] = 0;
                Session["NumVentasID"] = 0;

                ventass ObjVen = new ventass();
                productoss ObjPro = new productoss();
                try
                {

                    DataSet DatosAdm = ObjPro.ConsultarProducto3();


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
                            DropDownList1.Items.Add(DatosConsultados.Rows[i]["nombre"].ToString());
                        }

                    }

                }
                catch
                {
                    MessageBox.alert(ObjPro.Mensaje);
                }

                try
                {
                    ObjVen.IdentificacionEmp = int.Parse(Session["Empleado"].ToString());


                    DataSet DatosAdm2 = ObjVen.InsertarVenta();


                    DataTable DatosConsultados2 = DatosAdm2.Tables["DatosConsultados"];

                    int numregistros = DatosConsultados2.Rows.Count;

                    if (numregistros == 0)
                    {
                        MessageBox.alert("No hay datos en la base de datos");
                    }
                    else
                    {                                   
                            Session["VentasID"] = int.Parse(DatosConsultados2.Rows[0]["id_ventass"].ToString());
                           
                    }
                   
                }
                catch
                {

                }


            }
        }
 

        protected void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.alert("Se Almacenaron Los Dotos");
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

        protected void Button1_Click1(object sender, EventArgs e)
        {
     
            factura_productos ObjFP = new factura_productos();
            productoss ObjPro = new productoss();
            int Total = 0;

            try
            {
                ObjFP.Cantidad = int.Parse(TextBox1.Text);
                ObjFP.Id_Ventas = int.Parse(Session["VentasID"].ToString());




                bool respuestasql = ObjFP.InsertarFacturaPro(DropDownList1.Text);

                if (respuestasql == true)
                {
                    //DropDownList2.Items.Add(DropDownList1.Text);
                    BulletedList1.Items.Add(DropDownList1.Text);

                    BulletedList2.Items.Add(DropDownList1.Text);

                    try
                    {
                        DataSet DatosAdm = ObjPro.ConsultarProducto2(DropDownList1.Text);


                        DataTable DatosConsultados = DatosAdm.Tables["DatosConsultados"];


                        int numregistros = DatosConsultados.Rows.Count;


                        if (numregistros == 0)
                        {
                            MessageBox.alert("No hay datos en la base de datos");
                        }
                        else
                        {


                             Total = int.Parse(DatosConsultados.Rows[0]["precio"].ToString()) * int.Parse(TextBox1.Text);

                            BulletedList3.Items.Add(TextBox1.Text);
                            BulletedList4.Items.Add(DatosConsultados.Rows[0]["precio"].ToString());
                            BulletedList5.Items.Add(Total.ToString());
                            Session["SumaTotalD"] = int.Parse(Session["SumaTotalD"].ToString()) + Total;
                            Session["NumVentasID"] = int.Parse(TextBox1.Text) + int.Parse(Session["NumVentasID"].ToString());
                            TextBox1.Text = "";
                 


                        }
                    }
                    catch
                    {

                    }

                }
                else
                {
                    MessageBox.alert("Error al ingresar producto");
                }

            }
            catch
            {
          
            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            int NumVentas = int.Parse(Session["NumVentasID"].ToString());

            int SumTotal = int.Parse(Session["SumaTotalD"].ToString());

            factura ObjFac = new factura();
            factura_productos ObjFP = new factura_productos();
            ventass ObjVen = new ventass();
    
            try
            {
         
                ObjFac.IdentificacionCli = int.Parse(TextBox5.Text);
                ObjFac.IdentificacionEmp = int.Parse((Session["Empleado"]).ToString());

                DataSet DatosAdm2 = ObjFac.InsertarFactura();


                DataTable DatosConsultados2 = DatosAdm2.Tables["DatosConsultados"];

                int numregistros = DatosConsultados2.Rows.Count;

                if (numregistros == 0)
                {
                    MessageBox.alert("No hay datos en la base de datos");
                }
                else
                {
                    Session["NumFacturaD"] = int.Parse(DatosConsultados2.Rows[0]["num_facturaa"].ToString());

    
                    //TextBox5.Text = "";
                    try
                    {

                        DataSet DatosAdm = ObjFac.ConsultarFactura2(int.Parse(Session["NumFacturaD"].ToString()));


                        DataTable DatosConsultados = DatosAdm.Tables["DatosConsultados"];


                        int numregistros2 = DatosConsultados.Rows.Count;


                        if (numregistros2 == 0)
                        {
                            MessageBox.alert("No hay datos en la base de datos");
                        }
                        else
                        {
        
                            Session["FechaFactura"] = DatosConsultados.Rows[0]["fecha_factura"].ToString();



                            try
                            {
                                ObjFP.Num_Factura = int.Parse(Session["NumFacturaD"].ToString());
                                ObjFP.Id_Ventas = int.Parse(Session["VentasID"].ToString());
                                int Ventas= int.Parse(Session["VentasID"].ToString());
                           
                                bool respuestaFac = ObjFP.InsertarFacturaPro2();

                                if (respuestaFac == true)
                                {
                                    ObjFac.Modo_Pago = RadioButtonList1.Text;
                                    bool respuestaFac2 = ObjFac.InsertarFactura2(int.Parse(Session["NumFacturaD"].ToString()));
                            

                                    if (respuestaFac2 == true)
                                    {
                                 
                                        ObjVen.Suma_Total = SumTotal;
                                        ObjVen.Numero_De_Ventas = NumVentas;

                                        bool respuestaVen = ObjVen.InsertarVenta2(Ventas);

                                        if (respuestaVen == true)
                                        {
                                            MessageBox.alert("Se genero la factura correctamente");
                                            Label1.Text = RadioButtonList1.Text;
                                            Label2.Text = TextBox6.Text;
                                            Label3.Text = Session["SumaTotalD"].ToString();
                                            int Cambio = int.Parse(TextBox6.Text) - int.Parse(Session["SumaTotalD"].ToString());
                                            Label4.Text = Cambio.ToString();
                                            Label5.Text = TextBox5.Text;
                                            Label6.Text = Session["Empleado"].ToString();
                                            Label7.Text = Session["FechaFactura"].ToString();
                                            TextBox1.Text = "";
                                            TextBox5.Text = "";
                                            TextBox6.Text = "";
                                            Panel1.Visible = true;
                                            table12.Visible = false;
                                            Button2.Visible = false;
                                            try
                                            {
                                                ObjVen.IdentificacionEmp = int.Parse(Session["Empleado"].ToString());


                                                DataSet DatosAdm3 = ObjVen.InsertarVenta();


                                                DataTable DatosConsultados3 = DatosAdm2.Tables["DatosConsultados"];

                                                int numregistros3 = DatosConsultados2.Rows.Count;

                                                if (numregistros3 == 0)
                                                {
                                                    MessageBox.alert("No hay datos en la base de datos");
                                                }
                                                else
                                                {
                                                    Session["VentasID"] = int.Parse(DatosConsultados2.Rows[0]["id_ventass"].ToString());

                                                }

                                            }
                                            catch
                                            {

                                            }


                                        }
                                        else
                                        {
                                            MessageBox.alert("Error factura");
                                   
                                        }


                                    }
                                    else
                                    {
                                        MessageBox.alert("3error");

                                    }

                                }
                                else
                                {
                                    MessageBox.alert("2error");
                                }
                            }
                            catch
                            {

                            }



                        }

                    }
                    catch
                    {

                    }


                }


            }
            catch
            {

            }
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {

            //factura_productos ObjFP = new factura_productos();

            //try
            //{

            //    ObjFP.Id_Ventas = VentasID;

            //    bool respuestasql = ObjFP.EliminarFacturaPro(DropDownList2.Text);

            //    if (respuestasql == true)
            //    {
            //        DropDownList2.Items.Remove(DropDownList1.Text);
            //        BulletedList1.Items.Remove(DropDownList1.Text);
            //        BulletedList3.Items.Remove(TextBox1.Text);
            //        BulletedList4.Items.Remove(DatosConsultados.Rows[0]["precio"].ToString());
            //        BulletedList5.Items.Remove(Total.ToString());
            //    }
            //    else
            //    {
            //        MessageBox.alert("Error al ingresar producto");
            //    }

            //}
            //catch
            //{

            //}
        }
    }
}