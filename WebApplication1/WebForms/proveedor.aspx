<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="proveedor.aspx.cs" Inherits="WebApplication1.WebForms.proveedor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>PROVEEDOR</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 105px;
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
    <div>
    
        DATOS DEL PROVEEDOR<br />
            <br />
            Nombre del Proveedor:
            <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Cargar Datos" />
&nbsp;
            <br />
        <br />
        <hr />
        <br />
        INFORMACION DE PROVEDORES
        <br />
        <table class="auto-style1">
            <tr>

                <td class="auto-style2">Nombre:</td>
                <td><asp:TextBox ID="TextBox1" runat="server"   MaxLength="50" type="text" pattern="[aA-zZ ]+" CssClass="input"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Correo:</td>
                <td><asp:TextBox ID="TextBox2" runat="server"    MaxLength="100" type="email" CssClass="input"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Direccion:</td>
                <td><asp:TextBox ID="TextBox3" runat="server"    MaxLength="50" type="text"  CssClass="input"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Telefono:</td>
                <td><asp:TextBox ID="TextBox4" runat="server" placeholder="0000000000" MaxLength="10" type="text" pattern="[0-9 ]+" CssClass="input"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Almacenar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Consultar" OnClick="Button2_Click1" />
        <asp:Button ID="Button4" runat="server" Text="Actualizar" OnClick="Button4_Click1" />
        <asp:Button ID="Button3" runat="server" Text="Eliminar" OnClick="Button3_Click1" />
    
        <br />
        <br />
        *Para actualizar y/o eliminar proveedor ingrese el nombre en la primera casilla*<br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
