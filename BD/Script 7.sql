CREATE TABLE TBUsuarios(
    ATId_Usuario INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
	ATUsuario varchar2(50),
    ATContrasenna varchar2(150),
    ATNombre varchar2(50),
    ATApellido_1 varchar2(50),
	ATApellido_2 varchar2(50),
    ATCedula varchar2(30),
    ATActivo char(1) check ( ATActivo in ( '0', '1' )),
    ATRol int,
    ATId_Correo varchar(100),
    ATId_Telefono varchar(10),
    PRIMARY KEY(ATId_usuario)
);

ALTER TABLE TBUsuarios ADD CONSTRAINT fk_rol FOREIGN KEY (ATRol) REFERENCES TBRol (ATRol);

CREATE TABLE TBRol(
    ATRol INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
	ATTipoRol varchar2(50),
    PRIMARY KEY(ATRol)
);

CREATE TABLE TBDonacionDinero(
    ATId_TipoDonacion INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
    ATCantidad int,
    ATConcepto varchar2(500),
    ATMetodoPago varchar2(60),
    PRIMARY KEY(ATId_TipoDonacion)
);

CREATE TABLE TBDonacionEspecie(
    ATId_TipoDonacion INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
    ATCantidad int,
    ATDescripcion varchar2(500),
    PRIMARY KEY(ATId_TipoDonacion)
);

CREATE TABLE TBDonacion(
    ATId_Donacion INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
	ATFecha date,
    ATProcedencia varchar2(80),
    ATId_TipoDonacion int,
    ATId_Usuario int,
    ATId_Sede int,
    PRIMARY KEY(ATId_Donacion)
);

ALTER TABLE TBDonacion ADD CONSTRAINT fk_donacion_especie_usuario FOREIGN KEY (ATId_Usuario) REFERENCES TBUsuarios (ATId_usuario);
ALTER TABLE TBDonacion ADD CONSTRAINT fk_donacion_especie_sede FOREIGN KEY (ATId_Sede) REFERENCES TBSede (ATId_Sede);
ALTER TABLE TBDonacion ADD CONSTRAINT fk_donacion_especie FOREIGN KEY (ATId_TipoDonacion) REFERENCES TBDonacionEspecie (ATId_TipoDonacion);
ALTER TABLE TBDonacion ADD CONSTRAINT fk_donacion_dinero_tipo FOREIGN KEY (ATId_TipoDonacion) REFERENCES TBDonacionDinero (ATId_TipoDonacion);

CREATE TABLE TBSede(
    ATId_Sede INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
    ATId_Localizacion int,
    ATId_Correo int,
    ATId_Telefono int,
    PRIMARY KEY(ATId_Sede)
);

ALTER TABLE TBSede ADD CONSTRAINT fk_sede_correos FOREIGN KEY (ATId_Correo) REFERENCES TBCorreo (ATId_Correo);
ALTER TABLE TBSede ADD CONSTRAINT fk_sede_telefonos FOREIGN KEY (ATId_Telefono) REFERENCES TBTelefono (ATId_Telefono);
ALTER TABLE TBSede ADD CONSTRAINT fk_sede_localizacion FOREIGN KEY (ATId_Localizacion) REFERENCES TBLocalizacion (ATId_Localizacion);

CREATE TABLE TBLocalizacion(
    ATId_Localizacion INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
	ATProvincia varchar2(50),
    ATCanton varchar2(50),
    ATDireccionExacta varchar2(100),
    PRIMARY KEY(ATId_Localizacion)
);

CREATE TABLE TBCorreo(
    ATId_Correo INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
	ATCorreo varchar2(150),
    PRIMARY KEY(ATId_correo)
);

CREATE TABLE TBTelefono(
    ATId_telefono INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
	ATTelefono varchar2(150),
    PRIMARY KEY(ATId_telefono)
);

--SE INSERTAN LOS ROLES DEFINIDOS PARA USUARIO
INSERT INTO TBRol VALUES (1,'administrador');
INSERT INTO TBRol VALUES (2,'empleado');
INSERT INTO TBRol VALUES (3,'donante');


INSERT INTO TBUsuarios VALUES
    ('',
    'UsuarioPrueba',
    '12345',
    'NombrePrueba',
    'Apellido1Prueba',
    'Apellido2Prueba',
    '122223333',
    1,
    2,
    'prueba@gmail.com',
    '8888777');