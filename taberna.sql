create database tabernaMerchan --Ejecuta este primero--

use tabernaMerchan --Ejecuta este segundo--



--De hay para abajo ejecuta todo--
create table empleado
(
identificacionemp bigint primary key,
nombre varchar(50),
apellido varchar(25),
direccion varchar(50),
cargo varchar(25),
email varchar(30),
eps varchar(15),
usuario varchar(15),
contraseña varchar(15),
identificacionadm bigint
)

create table productos 
(
codigo bigint primary key identity (1,1),
nombre varchar (50),
fecha_de_entrada varchar(50),
fecha_de_salida varchar(50),
fecha_de_vencimiento varchar(50),
precio int,
cantidad_de_productos int ,
tipo_producto varchar (50),
id_provedores int
)

create table provedores 
(
id_provedores int primary key identity (1,1),
telefono bigint,
nombre varchar(25),
correo varchar(25),
direccion varchar(25)
)



create table administrador
(
identificacionadm bigint primary key,
nombre varchar(50),
apellido varchar (50),
celular int,
eps varchar (50),
direccion varchar (50),
email varchar (50),
contraseña varchar (50)
)

create table cliente
(
identificacioncli bigint primary key,
nombre varchar(50),
apellido varchar (50),
celular bigint,
edad varchar (50)
)

create table factura_productos
(
id_factura_productos int primary key identity,
cantidad int,
num_factura int,
codigo bigint,
id_ventas int
)

create table ventas

(
id_ventas int primary key identity (1,1),
numero_de_ventas bigint,
suma_total bigint,
identificacionemp bigint


)



create table factura
(
num_factura int primary key identity (1,1),
fecha_factura  date Default CONVERT (date,GETDATE()),
identificacionemp bigint,
identificacioncli bigint,
modo_pago varchar(50)
)

alter table empleado add
constraint FK_Administrador_Empleado
Foreign key (identificacionadm)
references administrador(identificacionadm)

alter table factura_productos add
constraint FK_FacturaPro_Productos
foreign key (codigo)
references productos(codigo)

alter table productos add
constraint FK_Provedores_Productos
foreign key (id_provedores)
references provedores(id_provedores)

alter table factura_productos add
constraint FK_FacturaPro_Factura
foreign key (num_factura)
references factura(num_factura)

alter table factura add
constraint FK_Factura_Empleado
foreign key (identificacionemp)
references empleado (identificacionemp)

alter table ventas add
constraint FK_Ventas_Empleado
foreign key (identificacionemp)
references empleado (identificacionemp)

alter table factura add
constraint FK_Facura_Cliente
foreign key (identificacioncli)
references cliente (identificacioncli)


--x--

insert into administrador (nombre,apellido,celular,eps,direccion,email,contraseña, identificacionadm) 
values ('Merchan', 'Robayos' , 301856456, 'Compensar' , 'Cll 45a @9 89' , 'merchan@gmail.com' , '123', 123)

