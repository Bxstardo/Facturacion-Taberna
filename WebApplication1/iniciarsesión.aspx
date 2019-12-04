<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="iniciarsesión.aspx.cs" Inherits="WebApplication1.inicio" %>

<!DOCTYPE html>
<link href="Estilos/estiloindex.css" rel="stylesheet" type="text/css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 132px;
            text-align: center;
        }
    </style>
</head>
<body style="height: 133px; background-image: url('http://localhost:53163/Imagenes/bar.jpg');" >
    <form id="form1" runat="server">
    <div class="auto-style1">
        
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" BackColor="Black" ForeColor="White" Height="264px">
            <br />
        INICIO SESION
            <br />
        <br />
        USUARIO<br /> <br />
        <asp:TextBox  ID="TextBox1" required="required" runat="server"></asp:TextBox>
            <br />
        <br />
        CONTRASEÑA<br /> <br />
        <asp:TextBox type="password"  required="required" ID="TextBox2" runat="server"></asp:TextBox>
        <br />
            <br />
        <asp:Button  ID="Button1" runat="server" OnClick="Button1_Click1" Text="INGRESAR" />
            </asp:Panel>
    </div>
        
    </form>
</body>
</html>
