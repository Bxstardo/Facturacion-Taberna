<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="empleado.aspx.cs" Inherits="WebApplication1.WebForms.empleado" %>

<!DOCTYPE html>
<link href="Estilos/estiloindex.css" rel="stylesheet" type="text/css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 114px;
            text-align: left;
        }
        .auto-style2 {
            width: 114px;
            height: 23px;
            text-align: left;
        }
        .auto-style4 {
            width: 123px;
            text-align: left;
        }
        .auto-style6 {
            text-align: center;
        }
        .auto-style8 {
            text-align: left;
        }
        .auto-style9 {
            width: 114px;
            text-align: left;
            height: 30px;
        }
        .auto-style10 {
            text-align: left;
            height: 30px;
        }
           .input:invalid{
            border: 1px solid red;
        }
        .input:valid{
            border: 1px solid green;
        }
    </style>
</head>
<body bgcolor="#e8e8e8">
    <form id="form1" runat="server">
    <div class="auto-style6">
    
        <div class="auto-style8">
    
        DATOS DEL EMPLEADO<br />
            <br />
            Identificacion:
            <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Cargar Datos" />
&nbsp;
            <br />
            <br />
            <hr />
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Nombre:</td>
                <td class="auto-style4">&nbsp;<asp:TextBox ID="TextBox10" runat="server" placeholder="Nombres"  MaxLength="50" type="text" pattern="[aA-zZ ]+" CssClass="input"></asp:TextBox>
                </td>
            <tr>
                <td class="auto-style1">Apellido:</td>
                <td class="auto-style4">&nbsp;<asp:TextBox ID="TextBox11" runat="server" placeholder="Apellidos"  MaxLength="50" type="text" pattern="[aA-zZ ]+" CssClass="input"></asp:TextBox>
                
                </td>
                    <tr>
                <td class="auto-style1">Identificacion:</td>
                <td class="auto-style4">&nbsp;<asp:TextBox ID="TextBox12" runat="server" placeholder="0000000000" MaxLength="10" type="text" pattern="[0-9 ]+" CssClass="input"></asp:TextBox>
                
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Direccion: </td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox13" runat="server" style="text-align: left" placeholder="Direccion"  MaxLength="50" type="text"  CssClass="input"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Cargo:</td>
                <td class="auto-style4">
                    
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem>Gerente</asp:ListItem>
                        <asp:ListItem>Servicios Generales</asp:ListItem>
                        <asp:ListItem>Repartidor</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Email:</td>
                <td class="auto-style10">
                    &nbsp;<asp:TextBox ID="TextBox14" runat="server" style="text-align: left" placeholder="Ejemplo@gmail.com"  MaxLength="50" type="email"  CssClass="input"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">EPS:</td>
                <td class="auto-style8" >
                    <asp:TextBox ID="TextBox15" runat="server" placeholder="eps"  MaxLength="50" type="text" pattern="[aA-zZ ]+" CssClass="input"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Contraseña:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox16" runat="server"  MaxLength="50" type="password" CssClass="input"></asp:TextBox>
                </td>
            </tr>
        </table>
        <div class="auto-style8">
        <br />
        <asp:Button ID="Button1" runat="server" Text="Almacenar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Consultar" OnClick="Button2_Click1" />
        <asp:Button ID="Button4" runat="server" Text="Actualizar" OnClick="Button4_Click1" />
        <asp:Button ID="Button3" runat="server" Text="Eliminar" OnClick="Button3_Click1" />
    
            <br />
            <br />
            *Para actualizar y/o eliminar empleado ingrese la identificacion en la primera casilla*<br />
            <br />
            *No se puede modificar la identificacion*<br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
    
        </div>
    
    </div>
    </form>
</body>
</html>
