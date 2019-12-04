<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="taller_repaso_2.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>Mi Pagina Index</title>
<link href="Estilos/estiloindex.css" rel="stylesheet" type="text/css" />
</head>
<body>
<div id="content">
<div id="cabecera">
<object type="text/html" data="cabecera.aspx" name='cabecera' width="100%" height="100%" scrolling="No"> </object>
</div>
<div id="menu" >
<object type="text/html" data="menu.aspx" name='menu' width="100%" height="100%">
</object>
</div>
<div id="principal">
<object type="text/html" data="bienvenida.aspx" name='principal' width="100%" height="100%" scrolling="yes"> </object>
</div>
<div id="pie">
<object type="text/html" data="pie.aspx" name='pie' width="100%" height="100%" scrolling="No"> </object>
</div>
</div>
</body>
</html>
