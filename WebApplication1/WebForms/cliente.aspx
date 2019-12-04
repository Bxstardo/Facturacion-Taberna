<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cliente.aspx.cs" Inherits="WebApplication1.WebForms.cliente" %>

<!DOCTYPE html>
<link href="Estilos/estiloindex.css" rel="stylesheet" type="text/css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>CLIENTE</title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            height: 23px;
            width: 130px;
        }
        .auto-style3 {
            width: 130px;
        }
        .auto-style4 {
            width: 130px;
            height: 32px;
        }
        .auto-style5 {
            height: 32px;
        }
        .auto-style6 {
            height: 24px;
            width: 130px;
        }
        .auto-style7 {
            height: 24px;
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
  
    
        DATOS DEL CLIENTE<br />
            <br />
            Identificacion:
            <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Cargar Datos" />
&nbsp;
            <br />
        <br />
  
        <hr />
        DATOS DEL CLIENTE<br />
        <table style="width: 100%;">
            <tr>
                <td class="auto-style6">Nombre </td>
                <td class="auto-style7">
                    
                    &nbsp;<asp:TextBox ID="TextBox18" runat="server" placeholder="Nombre"  MaxLength="50" type="text" pattern="[aA-zZ ]+" CssClass="input"></asp:TextBox>
                </td>
                <td class="auto-style7"></td>
            </tr>
                <tr>
                <td class="auto-style2">Apellido </td>
                <td class="auto-style1">
                    
                    &nbsp;<asp:TextBox ID="TextBox1" runat="server" placeholder="Apellidos"  MaxLength="50" type="text" pattern="[aA-zZ ]+" CssClass="input"></asp:TextBox>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style3">Identificacion</td>
                <td>
                    &nbsp;<asp:TextBox ID="TextBox19" runat="server" placeholder="0000000000" MaxLength="10" type="text" pattern="[0-9 ]+" CssClass="input"></asp:TextBox>

                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Telefono</td>
                <td class="auto-style5">
                    &nbsp;<asp:TextBox ID="TextBox20" runat="server" placeholder="000-0000-0000"  MaxLength="10 " type="text" pattern="[0-9 ]+" CssClass="input"></asp:TextBox>
                </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style3">Edad</td>
                <td>
                    &nbsp;<asp:TextBox ID="TextBox21" runat="server" placeholder="00"  MaxLength="12" type="text" pattern="[0-9 ]+" CssClass="input"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
  
    
    </div>
        <p>
        <asp:Button ID="Button1" runat="server" Text="Almacenar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Consultar" OnClick="Button2_Click" />
        <asp:Button ID="Button4" runat="server" Text="Actualizar" OnClick="Button4_Click" />
        <asp:Button ID="Button3" runat="server" Text="Eliminar" OnClick="Button3_Click" style="height: 26px" />
    
        </p>
            *Para actualizar y/o eliminar empleado ingrese la identificacion en la primera casilla*<br />
            <br />
            *No se puede modificar la identificacion*<br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
    
    </form>
</body>
</html>
