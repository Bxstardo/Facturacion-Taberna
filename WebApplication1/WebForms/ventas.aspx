<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ventas.aspx.cs" Inherits="WebApplication1.WebForms.ventas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>VENTAS</title>
    <style type="text/css">
        .auto-style1 {
            width: 233px;
        }
        .auto-style2 {
            width: 266px;
        }
           .input:invalid{
            border: 1px solid red;
        }
        .input:valid{
            border: 1px solid green;
        }
        .auto-style3 {
            height: 28px;
        }
    </style>
</head>
<body  bgcolor="#e8e8e8">
    <form id="form1" runat="server">
    <div>
    
        GENERAR FACTURA&nbsp;
        <br />
&nbsp;
        <br />
        <table style="width:100%;" border="1" runat ="server" id ="table12">
            <tr>
                  <td>Identificacion Cliente</td>
                  <td>
                      <asp:TextBox ID="TextBox5" runat="server" placeholder="0000000000" MaxLength="10" type="text" pattern="[0-9 ]+" CssClass="input"></asp:TextBox>
                  </td>
            </tr>
            <tr>
                  <td>Producto</td>
                  <td>
                      <asp:DropDownList ID="DropDownList1" runat="server">
                      </asp:DropDownList>
&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Cantidad de Productos</td>
                <td class="auto-style2">
                    <asp:TextBox  type="number" ID="TextBox1" runat="server" placeholder="Solo Numeros" ></asp:TextBox>
                &nbsp; <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click1" />
                    <br />
                    <asp:BulletedList ID="BulletedList1" runat="server">
                    </asp:BulletedList>
                    <br />
              <%--      <asp:DropDownList ID="DropDownList2" runat="server">
                    </asp:DropDownList>
&nbsp;<asp:Button ID="Button3" runat="server" Text="Quitar" OnClick="Button3_Click1" />--%>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Modo De Pago</td>
                <td class="auto-style2">
                    
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                           <asp:ListItem>Efectivo</asp:ListItem>
                        <asp:ListItem>Targeta De Credito</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">

                    Paga:</td>
                  <td class="auto-style3">

                      <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>

                </td>
            </tr>
            </table>
    
        <br />
        <asp:Button ID="Button2" runat="server" Text="Generar Factura" OnClick="Button2_Click1" style="text-align: center" />
        <br />
    
        <br />
    </div>
        <asp:Panel ID="Panel1" runat="server" style="text-align: center" Visible="False" Height="372px" Width="1353px">
            <strong>FACTURA</strong><br />
            <table style="width:98%; height: 349px;"border="1">
                <tr>
                    <td></td>
                          <td></td>
                          <td>Cantidad</td>
                          <td>Precio</td>
                          <td>Total</td>
                </tr>
                <tr>
                    <td>Productos vendidos:</td>
                    <td>
                        <asp:BulletedList ID="BulletedList2" runat="server">
                        </asp:BulletedList>
                      </td>
                    <td>
                         <asp:BulletedList ID="BulletedList3" runat="server">
                        </asp:BulletedList>
                    </td>
                     <td>
                         <asp:BulletedList ID="BulletedList4" runat="server">
                        </asp:BulletedList>
                    </td>
                       <td>
                         <asp:BulletedList ID="BulletedList5" runat="server">
                        </asp:BulletedList>
                    </td>
                </tr>
                <tr>
                    <td>Metodo de pago:</td>
                    <td>
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Paga:</td>
                    <td>
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                    </td>
                </tr>
                   <tr>
                    <td>Suma total de productos:</td>
                    <td>
                        <asp:Label ID="Label3" runat="server"></asp:Label>
                       </td>
                </tr>
                   <tr>
                    <td>Cambio:</td>
                    <td>
                        <asp:Label ID="Label4" runat="server"></asp:Label>
                       </td>
                          <tr>
                    <td>Cliente:</td>
                    <td>
                        <asp:Label ID="Label5" runat="server"></asp:Label>
                              </td>
                </tr>
                   <tr>
                    <td>Empleado: </td>
                    <td>
                        <asp:Label ID="Label6" runat="server"></asp:Label>
                       </td>
                </tr>
                       <tr>
                    <td>Fecha Factura: </td>
                    <td>
                        <asp:Label ID="Label7" runat="server"></asp:Label>
                           </td>
                </tr>
            </table>
        </asp:Panel>
    </form>
</body>
</html>
