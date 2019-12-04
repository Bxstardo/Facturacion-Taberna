function Validar() {
    if (Form1.checkValidity()) {
        CapturarDatos();
    }
}
function CapturarDatos() {
    var cantidad = Form1.cantidad.value;
    var correo = Form1.correo.value;
    var sitio = Form1.sitio.value;
    var nombre = Form1.nombre.value;
    var direccion = Form1.direccion.value;
    var codigo = Form1.codigo.value;
    var pais = Form1.pais.value;
    var telefono = Form1.telefono.value;
    var tarjeta = Form1.tarjeta.value;
    var confirmacion = Form1.confirmacion.value;
    var vencimiento = Form1.vencimiento.value;
    document.write("<strong>DATOS RECIBIDOS DESDE EL FORMULARIO WEB</strong>< br /> <br />");
    document.write("<strong>DATOS DE LA ORDEN </strong><br/>");
    document.write("Cantidad: " + cantidad + "<br/><br/>");
    document.write("<strong>DATOS DE CONTACTO</strong><br/>");
    document.write("Correo: " + correo + "<br/>");
    document.write("Sitio Web: " + sitio + "<br/><br/>");
    document.write("<strong>DATOS DE PAGO</strong><br/>");
    document.write("Nombre Completo: " + nombre + "<br/>");
    document.write("Direcci&oacute;n: " + direccion + "<br/>");
    document.write("Codigo Postal: " + codigo + "<br/>");
    document.write("Pais: " + pais + "<br/>");
    document.write("Telefono: " + telefono + "<br/>");
    document.write("Tarjeta De Credito: " + tarjeta + "<br/>");
    document.write("Codigo De Confirmaci&oacute;n: " + confirmación + "<br/>");
    document.write("Fecha De Vencimiento: " + vencimiento + "<br/>");
}