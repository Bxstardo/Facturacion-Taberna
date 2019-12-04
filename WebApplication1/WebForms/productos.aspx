<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productos.aspx.cs" Inherits="WebApplication1.WebForms.productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>PRODUCTOS</title>
    <style type="text/css">
        .auto-style1 {
            width: 278px;
        }
        .auto-style2 {
            width: 285px;
        }
        .auto-style3 {
            width: 278px;
            height: 75px;
        }
        .auto-style4 {
            width: 285px;
            height: 75px;
        }
        .auto-style5 {
            height: 75px;
        }
           .input:invalid{
            border: 1px solid red;
        }
        .input:valid{
            border: 1px solid green;
        }
    </style>
</head>
<body  bgcolor="#e8e8e8">
    <form id="form1" runat="server">
        INFORMACION DE LOS PRODUCTOS<br />
        <br />
        Nombre del Producto:
        &nbsp;<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button5" runat="server" Text="Cargar Datos" OnClick="Button5_Click" />
        <br />
        <br />
           <hr />
        <table style="width:100%;">
             <tr>
                <td class="auto-style1">Nombre del producto:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox6" runat="server" MaxLength="50" type="text" pattern="[aA-zZ ]+" CssClass="input"></asp:TextBox>
                 </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Fecha De Entrada:</td>
                <td class="auto-style2">Fecha De Salida </td>
                <td>Fecha De Vencimiento</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                </td>
                <td class="auto-style2">
                    <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
                </td>
                <td>
                    <asp:Calendar ID="Calendar3" runat="server"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
        Precio:
                </td>
                <td class="auto-style2">
        <asp:TextBox ID="TextBox1" runat="server" placeholder="0000000000" MaxLength="10" type="text" pattern="[0-9 ]+" CssClass="input"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
        Cantidad Productos Disponibles:
                </td>
                <td class="auto-style2">
        <asp:TextBox ID="TextBox2" runat="server" placeholder="0000000000" MaxLength="10" type="text" pattern="[0-9 ]+" CssClass="input"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style3">
                    Tipo de producto:
                </td>
                <td class="auto-style4">
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>Cerveza</asp:ListItem>
                        <asp:ListItem>Gaseosa</asp:ListItem>
                        <asp:ListItem>Papas</asp:ListItem>
                        <asp:ListItem>Cigarrillos</asp:ListItem>
                        <asp:ListItem>Dulces</asp:ListItem>
                        <asp:ListItem>Otro</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:Panel ID="Panel1" runat="server" Visible="False">
                        Otro: <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox> </asp:Panel>
                    <asp:Label ID="Label1" runat="server"></asp:Label></td>
                <td class="auto-style5">
                    </td>
            </tr>
               <tr>
                <td class="auto-style1">
                    Proveedor:
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList2" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        *Para actualizar y/o eliminar producto ingrese el nombre en la primera casilla*<br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Almacenar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Consultar" OnClick="Button2_Click1" />
        <asp:Button ID="Button3" runat="server" Text="Actualizar" OnClick="Button3_Click1" />
        <asp:Button ID="Button4" runat="server" Text="Eliminar" OnClick="Button4_Click1" />
    </form>
</bod>
</html>

