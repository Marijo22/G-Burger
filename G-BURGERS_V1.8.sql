create database G_Burgers
use G_Burgers

create table PRODUCTOS(
  id_producto int NOT NULL IDENTITY primary key,
  nombre_pro varchar(30) NOT NULL UNIQUE,
  descripcion varchar(100) NOT NULL,
  precio float NOT NULL,
  imagen varchar(200),
  categoria varchar(20) NOT NULL,
)

create table COMBO_PRODUCTOS(
  id_combo int,
  id_producto int,
  Cantidad int,
CONSTRAINT fk_combo FOREIGN KEY (id_combo)
        REFERENCES PRODUCTOS(id_producto),
  CONSTRAINT fk_producto FOREIGN KEY (id_producto)
        REFERENCES PRODUCTOS(id_producto) on update cascade,
  primary key(id_combo,id_producto)
)

create table PEDIDO(
  num_referencia int NOT NULL IDENTITY PRIMARY KEY,
  nombre_cliente varchar(50) NOT NULL,
  fecha datetime NOT NULL,
  total float NOT NULL,
  metodopago varchar(15) NOT NULL,
  confirmado bit NOT NULL,
  pagado bit NOT NULL,
  autorizo varchar (18),
  CONSTRAINT fk_empleadoautorizador FOREIGN KEY (autorizo)
        REFERENCES EMPLEADO(CURP_emp) on delete set null on update cascade
)

create table PRODUCTOS_PEDIDOS(
  num_referencia int,
  id_producto int,
  Cantidad int NOT NULL,
  especificaciones varchar(200),
	CONSTRAINT fk_pedido FOREIGN KEY (num_referencia)
        REFERENCES PEDIDO(num_referencia) on delete cascade on update cascade,
  CONSTRAINT fk_producto_pedido FOREIGN KEY (id_producto)
        REFERENCES PRODUCTOS(id_producto) on delete cascade on update cascade,
  primary key(num_referencia,id_producto)
)

create table EMPLEADO(
  CURP_emp varchar (18) primary key,
  nombre_emp varchar(70) NOT NULL,
  direccion_emp varchar(200),
  telefono_emp varchar(10),
  nombre_usuario varchar(20) NOT NULL UNIQUE,
  Contraseña varchar (30) NOT NULL
)

create table MENUIMAGENES(
   id int primary key,
   Imagen varchar(200),
   categoria varchar(20) NOT NULL
)

INSERT INTO EMPLEADO (CURP_emp,nombre_emp,direccion_emp,telefono_emp,nombre_usuario,Contraseña)
VALUES('ABJD4F827383378HD8','Herbert Anthony Stevens IV','Los Ángeles (Estados Unidos)','8829747238','Admin','KendrickLamar')


sp_tables
