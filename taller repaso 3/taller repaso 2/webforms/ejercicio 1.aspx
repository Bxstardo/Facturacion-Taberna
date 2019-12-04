<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio 1.aspx.cs" Inherits="taller_repaso_2.webforms.ejercicio_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>sumar dos numeros</title>
</head>
<body>
    <h1>Escoja una operacion para ejecutar</h1>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>sumar</asp:ListItem>
                <asp:ListItem>restar</asp:ListItem>
                <asp:ListItem>multiplicar</asp:ListItem>
                <asp:ListItem>dividir</asp:ListItem>
                <asp:ListItem>potenciacion</asp:ListItem>
                <asp:ListItem>seno</asp:ListItem>
                <asp:ListItem>coseno</asp:ListItem>
                <asp:ListItem>factorial</asp:ListItem>
            </asp:DropDownList>
            <br />
            ESCRIBA EL NUMERO 1
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            ESCRIBA EL NUMERO 2
            <asp:TextBox ID="TextBox2" runat="server">0</asp:TextBox>
            <br />
            
            &nbsp;<asp:Button ID="Button1" runat="server" Text="calcular" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
</div>
    </form>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
</body>
</html>
