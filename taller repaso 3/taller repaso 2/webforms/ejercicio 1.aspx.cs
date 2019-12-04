using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taller_repaso_2.webforms
{
    public partial class ejercicio_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "holamundo";
            double num1 = 0;
            double num2 = 0;
            double respuesta = 0;

            num1 = double.Parse(TextBox1.Text);
            num2 = double.Parse(TextBox2.Text);

            switch (DropDownList1.Text)
            {
                case "sumar":
                    {
                        respuesta = num1 + num2;
                        Label2.Text = num1 + "+" + num2 + "=" + respuesta;
                    }
                    break;

                case "restar":
                    {
                        respuesta = num1 - num2;
                        Label2.Text = num1 + "-" + num2 + "=" + respuesta;
                    }
                    break;

                case "multiplicar":
                    {
                        respuesta = num1 * num2;
                        Label2.Text = num1 + "*" + num2 + "=" + respuesta;
                    }
                    break;

                case "dividir":
                    {
                        respuesta = num1 / num2;
                        Label2.Text = num1 + "/"  + num2 + "=" + respuesta;
                    }
                    break;

                case "potenciacion":
                    {
                        double i;
                        double potencia = 1;
                        for (i = 1; i <= num2; i++)
                        {
                            potencia = potencia * num1;
                            respuesta = potencia;
                        }
                        
                        Label2.Text = "la potencia es " + respuesta;
                    }
                    break;

                case "seno":
                    {
                        num2 = 0;
                        respuesta = num1 = Math.Sin(num1* Math.PI/180);
                        Label2.Text =  respuesta.ToString();
                    }
                    break;

                case "coseno":
                    {
                        num2 = 0;
                        respuesta = num1 = Math.Cos(num1 * Math.PI / 180);
                        Label2.Text = Math.Round(respuesta).ToString();
                    }
                    break;

                case "factorial":
                    {
                        double factorial =1;
                        num2 = 0;
                        for (int i = 1; i <= num1; i++)
                        {
                            factorial = factorial * i;
                            
                        }
                        respuesta = factorial;
                        Label2.Text = "el factorial de " + num1  +  " es " + respuesta; 
                    }

                    
                    break;

            }

        }
    }
}