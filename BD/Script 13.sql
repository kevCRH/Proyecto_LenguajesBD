/*************************************************************************************************************************
**************************************************************************************************************************
****************************************BORRADO DE TABLAS*****************************************************************
**************************************************************************************************************************
**************************************************************************************************************************/
--DESCOMENTAR SI SE OCUPA EJECUTAR

/*
DROP TABLE TBUSUARIOS;
DROP TABLE TBUSERNAME;
DROP TABLE TBROL;
DROP TABLE TBCATEGORIA;
DROP TABLE TB_TIPODONACION;
DROP TABLE TBDONACION;
DROP TABLE TBTELEFONOS;
DROP TABLE TBCORREOS;
DROP TABLE TBSEDES;
DROP TABLE TBAUDITORIADONACIONES;
DROP TABLE TBAUDITORIASEDES;
DROP TABLE TBAUDITORIAUSUARIOS;
*/

/*************************************************************************************************************************
**************************************************************************************************************************
****************************************CREACION DE TABLAS****************************************************************
**************************************************************************************************************************
**************************************************************************************************************************/

CREATE TABLE TBUsuarios(
    ATId_Usuario INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
    ATNombre varchar2(50),
    ATApellido_1 varchar2(50),
    ATApellido_2 varchar2(50),
    ATCedula varchar2(30),
    ATActivo varchar2(30),
    ATRol varchar2(50),
    PRIMARY KEY(ATCedula)
);

ALTER TABLE TBUsuarios ADD CONSTRAINT fk_rol FOREIGN KEY (ATRol) REFERENCES TBRol (ATTipoRol);

------------------------------------------------------------------------------------------

CREATE TABLE TBRol(
    ATRol INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
	ATTipoRol varchar2(50),
    PRIMARY KEY(ATTipoRol)
);

------------------------------------------------------------------------------------------

CREATE TABLE TBUsername(
    ATId_Username INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
    ATUsername varchar2(50),
    ATContrasenna varchar2(50),
    ATDuenoUsername varchar2(30),
    ATRolUsername varchar2(30),
    PRIMARY KEY(ATUsername)
);

ALTER TABLE TBUsername ADD CONSTRAINT fk_Rol_Username FOREIGN KEY (ATRolUsername) REFERENCES TBRol (ATTipoRol);

-------------------------------------------------------------------------------------------

CREATE TABLE TBSedes (
    ATId_Sede INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
    ATNombreSede varchar2(30),
    ATCodPostal Varchar(10),
	ATProvincia varchar2(50),
    ATCanton varchar2(50),
    ATDistrito varchar2(50),
    ATDireccionExacta varchar2(100),
    PRIMARY KEY(ATNombreSede) /*La sede es el primary key porque el nombre de cada sede es unico y para poner usarlo en correos y telefonos*/
);

-------------------------------------------------------------------------------------------

CREATE TABLE TBCATEGORIA (
    ATID_CATEGORIA INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
    AT_DESCRIPCION varchar(30),
    PRIMARY KEY(AT_DESCRIPCION) /*El nombre de las categorias nunca va a cambiar por eso cada nombre puede ser primary key*/
);

-------------------------------------------------------------------------------------------

CREATE TABLE TBCorreos(
    ATId_Correo INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
	ATCorreo varchar2(150),
    ATDuenoCorreo varchar2(30),
    ATCategoriaCorreo varchar2(30),
    PRIMARY KEY(ATId_Correo)
);

ALTER TABLE TBCorreos ADD CONSTRAINT fk_categoria_correo FOREIGN KEY (ATCategoriaCorreo) REFERENCES TBCATEGORIA (AT_DESCRIPCION);

-------------------------------------------------------------------------------------------

CREATE TABLE TBTelefonos(
    ATId_Telefono INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
	ATTelefono varchar2(150),
    ATDuenoTelefono varchar2(30),
    ATCategoriaTelefono varchar2(30),
    PRIMARY KEY(ATId_Telefono)
);

ALTER TABLE TBTelefonos ADD CONSTRAINT fk_categoria_telefono FOREIGN KEY (ATCategoriaTelefono) REFERENCES TBCATEGORIA (AT_DESCRIPCION);

--------------------------------------------------------------------------------------------

CREATE TABLE TB_TipoDonacion(
    ATId_TipoDonacion INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
    ATTipo_Donacion varchar2(500),
    PRIMARY KEY(ATId_TipoDonacion)
);

--------------------------------------------------------------------------------------------

CREATE TABLE TBDonacion(
    ATId_Donacion INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
    ATFecha date,
    ATProcedencia varchar2(80),
    ATId_TDonacion int,
    ATCedulaUsuario varchar(30),
    ATCedulaUsuarioCaptacion varchar(30),
    ATNombreSede varchar2(30),
    ATCantidad varchar2(60),
    ATNumeroRecibo varchar2(60),
    ATDescripcion varchar2(500),
    ATMetodoPago varchar2(60),
    ATMonto varchar2(500),
    PRIMARY KEY(ATId_Donacion) 
);

ALTER TABLE TBDonacion ADD CONSTRAINT fk_donacion_usuario FOREIGN KEY (ATCedulaUsuario) REFERENCES TBUsuarios (ATCedula);
ALTER TABLE TBDonacion ADD CONSTRAINT fk_donacion_usuario_captacion FOREIGN KEY (ATCedulaUsuarioCaptacion) REFERENCES TBUsuarios (ATCedula);
ALTER TABLE TBDonacion ADD CONSTRAINT fk_donacion_sede FOREIGN KEY (ATNombreSede) REFERENCES TBSedes (ATNombreSede);
ALTER TABLE TBDonacion ADD CONSTRAINT fk_tipo_donacion FOREIGN KEY (ATId_TDonacion) REFERENCES TB_TipoDonacion (ATId_TipoDonacion);

--------------------------------------------------------------------------------------------

CREATE TABLE TBAuditoriaUsuarios (
Id_Record NUMBER GENERATED ALWAYS AS IDENTITY,
Accion VARCHAR2(200),
Usuario VARCHAR2(20),
Fecha DATE,
PRIMARY KEY(Id_Record)
);

CREATE TABLE TBAuditoriaSedes (
Id_Record NUMBER GENERATED ALWAYS AS IDENTITY,
Accion VARCHAR2(200),
Sede VARCHAR2(20),
Fecha DATE,
PRIMARY KEY(Id_Record)
);

CREATE TABLE TBAuditoriaDonaciones (
Id_Record NUMBER GENERATED ALWAYS AS IDENTITY,
Accion VARCHAR2(200),
Sede VARCHAR2(20),
Fecha DATE,
PRIMARY KEY(Id_Record)
);

/*************************************************************************************************************************
**************************************************************************************************************************
****************************************SE INSERTAN DATOS*****************************************************************
**************************************************************************************************************************
**************************************************************************************************************************/

-- SELECTS PARA LAS AUDITORIAS
SELECT * FROM TBAuditoriaUsuarios;
SELECT * FROM TBAuditoriaSedes;
SELECT * FROM TBAuditoriaDonaciones;


--ROLES DEFINIDOS PARA USUARIO
SELECT * FROM TBRol;
INSERT INTO TBRol VALUES (1,'Administrador');
INSERT INTO TBRol VALUES (2,'Empleado');
INSERT INTO TBRol VALUES (3,'Donante');


--INSERTAR TABLA CATEGORIA -------> VALORES QUEMADOS DE LA TABLA DE CATEGORIA
SELECT * FROM TBCATEGORIA;
INSERT INTO TBCATEGORIA (AT_DESCRIPCION) VALUES ('Usuario');
INSERT INTO TBCATEGORIA (AT_DESCRIPCION) VALUES ('Sede');


/*----------------------------------------------------------------------------*/
--USUARIOS DE PRUEBA

--Rol de administrador TBUSUARIO
select * from TBUsuarios;
INSERT INTO TBUsuarios (ATNombre,ATApellido_1,ATApellido_2,ATCedula,ATActivo,ATRol)
VALUES ('Nombre','Apellido1','Apellido2','305380675','Activo','Administrador');
--Rol de empleado TBUSUARIO
INSERT INTO TBUsuarios (ATNombre,ATApellido_1,ATApellido_2,ATCedula,ATActivo,ATRol)
VALUES ('Nombre','Apellido1','Apellido2','405380675','Activo','Empleado');
-- Rol de donante TBUSUARIO
INSERT INTO TBUsuarios (ATNombre,ATApellido_1,ATApellido_2,ATCedula,ATActivo,ATRol)
VALUES ('Nombre','Apellido1','Apellido2','402500983',1,'Donante');

--Rol de administrador TBUsername
select * from TBUsername;
INSERT INTO TBUsername(ATUsername,ATContrasenna,ATDuenoUsername,ATRolUsername)
VALUES ('Administrador','1234','305380675','Administrador');
--Rol de empleado TBUsername
INSERT INTO TBUsername(ATUsername,ATContrasenna,ATDuenoUsername,ATRolUsername)
VALUES ('Empleado','1234','123456789','Empleado');

--Tipos de donacion TB
SELECT * FROM TB_TipoDonacion;
INSERT INTO TB_TipoDonacion (ATId_TipoDonacion,ATTipo_Donacion) VALUES (1, 'Monetaria');
INSERT INTO TB_TipoDonacion (ATId_TipoDonacion,ATTipo_Donacion) VALUES (2, 'Especie');

-- Sedes
SELECT * FROM TBSedes;
INSERT INTO TBSedes (ATNombreSede,ATCodPostal,ATProvincia,ATCanton,ATDistrito,ATDireccionExacta) 
VALUES ('San Jose','01','San Jose','Centro','Cristo Rey','De la Escuela Nicaragua 200 mts al Oeste, Contiguo a la Parroquia de Cristo Rey.');
INSERT INTO TBSedes (ATNombreSede,ATCodPostal,ATProvincia,ATCanton,ATDistrito,ATDireccionExacta) 
VALUES ('Alajuela','02','Alajuela','Alajuela','La Garita','Del Restaurante Fiesta del Ma�z 300 mts al Este');
INSERT INTO TBSedes (ATNombreSede,ATCodPostal,ATProvincia,ATCanton,ATDistrito,ATDireccionExacta) 
VALUES ('Puntarenas','03','Puntarenas','Puntarenas','Falta','Costado Norte del Estadio Lito Perez');

/*************************************************************************************************************************
**************************************************************************************************************************
****************************************PROCEDIMIENTOS ALMACENADOS********************************************************
**************************************************************************************************************************
**************************************************************************************************************************/   

/*------------------------------ CRUD DONACIONES ------------------------------*/
--Para ingresar donaciones

CREATE OR REPLACE PROCEDURE INSERTAR_DONACION 
    (pFecha IN date, pProcedencia IN VARCHAR2, pTipoDonacion IN int, pCedulaUsuario IN VARCHAR2,
    pCedulaUsuarioCaptacion IN VARCHAR2, pSede IN VARCHAR2,pCantidad IN VARCHAR2, 
    pNumeroRecibo IN VARCHAR2, pDescripcion IN VARCHAR2, pMetodoPago IN VARCHAR2, 
    pMonto IN VARCHAR2)
AS
BEGIN
    INSERT INTO TBDonacion 
    (ATFecha,ATProcedencia,ATId_TDonacion,ATCedulaUsuario, ATCedulaUsuarioCaptacion,
    ATNombreSede,ATCantidad,ATNumeroRecibo,ATDescripcion,ATMetodoPago,ATMonto)
    VALUES 
    (pFecha,pProcedencia,pTipoDonacion,pCedulaUsuario,pCedulaUsuarioCaptacion,
    pSede,pCantidad,pNumeroRecibo,pDescripcion,pMetodoPago,pMonto);
END;

--Para ver donaci�n

/* procedimiento para ver todas las donaciones*/
CREATE OR REPLACE PROCEDURE ver_donacion
    (pNumeroRecibo in VARCHAR2, registros out sys_refcursor)
AS
BEGIN
    OPEN registros FOR SELECT A.ATNUMERORECIBO AS "NUMERO RECIBO", A.ATFECHA AS "FECHA", 
        A.ATPROCEDENCIA AS "PROCEDENCIA", A.ATCEDULAUSUARIO AS "CED DONANTE", 
        A.ATCEDULAUSUARIOCAPTACION AS "EMPLEADO CAPTACION", A.ATNOMBRESEDE AS "SEDE", 
        B.ATTipo_Donacion AS "TIPO DONACION",
        A.ATCANTIDAD AS "CANTIDAD DE LA DONACION", A.ATDESCRIPCION AS "DESCRIPCION", 
        A.ATMETODOPAGO AS "METODO PAGO", A.ATMONTO AS "MONTO" 
    FROM TBDonacion A, TB_TipoDonacion B WHERE  A.ATId_TDonacion = B.ATId_TipoDonacion AND 
        A.ATNumeroRecibo = pNumeroRecibo;
END;

--Para ver donaci�nes
CREATE OR REPLACE PROCEDURE ver_donaciones_monetaria
    (registros out sys_refcursor)
AS
BEGIN
    OPEN registros FOR SELECT A.ATNUMERORECIBO AS "NUMERO RECIBO", A.ATFECHA AS "FECHA", 
        A.ATPROCEDENCIA AS "PROCEDENCIA", 
        C.ATNombre ||' '|| C.ATApellido_1 ||' '|| C.ATApellido_2 AS "Donante", 
        A.ATCEDULAUSUARIO AS "CED DONANTE", 
        D.ATNombre ||' '|| D.ATApellido_1 ||' '|| D.ATApellido_2 AS "EMPLEADO CAPTACION",
        A.ATCEDULAUSUARIOCAPTACION AS "CED EMPLEADO", 
        A.ATNOMBRESEDE AS "SEDE", B.ATTipo_Donacion AS "TIPO DONACION",
        A.ATMETODOPAGO AS "METODO PAGO", A.ATMONTO AS "MONTO" 
    FROM TBDonacion A 
    INNER JOIN  TB_TipoDonacion B 
        ON A.ATId_TDonacion = B.ATId_TipoDonacion and A.ATId_TDonacion = 1
    INNER JOIN  TBUsuarios C
        ON A.ATCEDULAUSUARIO = C.ATCedula
    INNER JOIN  TBUsuarios D
        ON A.ATCEDULAUSUARIOCAPTACION = D.ATCedula;
END;

CREATE OR REPLACE PROCEDURE ver_donaciones_especie
    (registros out sys_refcursor)
AS
BEGIN
    OPEN registros FOR SELECT A.ATNUMERORECIBO AS "NUMERO RECIBO", A.ATFECHA AS "FECHA", 
        A.ATPROCEDENCIA AS "PROCEDENCIA", 
        C.ATNombre ||' '|| C.ATApellido_1 ||' '|| C.ATApellido_2 AS "Donante", 
        A.ATCEDULAUSUARIO AS "CED DONANTE", 
        D.ATNombre ||' '|| D.ATApellido_1 ||' '|| D.ATApellido_2 AS "EMPLEADO CAPTACION",
        A.ATCEDULAUSUARIOCAPTACION AS "CED EMPLEADO", 
        A.ATNOMBRESEDE AS "SEDE", B.ATTipo_Donacion AS "TIPO DONACION",
        A.ATCANTIDAD AS "CANTIDAD DE LA DONACION", A.ATDESCRIPCION AS "DESCRIPCION" 
    FROM TBDonacion A   
    INNER JOIN  TB_TipoDonacion B
        ON A.ATId_TDonacion = B.ATId_TipoDonacion and A.ATId_TDonacion = 2
    INNER JOIN  TBUsuarios C
        ON A.ATCEDULAUSUARIO = C.ATCedula
    INNER JOIN  TBUsuarios D
        ON A.ATCEDULAUSUARIOCAPTACION = D.ATCedula;
END;

--Para actualizar donaci�n

CREATE OR REPLACE PROCEDURE actualizar_donacion
    (pNumeroRecibo IN VARCHAR2, npNUMERORECIBO IN VARCHAR2, npFECHA IN DATE, 
    npPROCEDENCIA IN VARCHAR2,npNOMBRESEDE IN VARCHAR2, npID_TDONACION IN INT, 
    npCANTIDAD IN VARCHAR2, npDESCRIPCION IN VARCHAR2, npMETODOPAGO IN VARCHAR2, 
    npMONTO IN VARCHAR2)
AS
BEGIN
    UPDATE TBDONACION SET 
    ATNumeroRecibo = npNUMERORECIBO, ATFecha = npFECHA, ATProcedencia = npPROCEDENCIA,
    ATNombreSede = npNOMBRESEDE, ATID_TDONACION = npID_TDONACION, ATCantidad = npCANTIDAD,
    ATDescripcion = npDESCRIPCION, ATMetodoPago = npMETODOPAGO, ATMonto = npMONTO
    where ATNumeroRecibo = pNumeroRecibo;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
    NULL;
    WHEN OTHERS THEN
    RAISE;
END;

/*------------------------------ LOGIN ------------------------------*/
--Para acceder a login

CREATE OR REPLACE PROCEDURE USUARIO_LOGIN (pATUSUARIO IN VARCHAR2, pATCONTRASENNA IN VARCHAR2, pVERIFICAR OUT NUMBER)
AS
VERIFICAR NUMBER;
BEGIN
    SELECT COUNT(1)
    INTO VERIFICAR
    FROM TBUsername
    WHERE pATUSUARIO = ATUsername AND pATCONTRASENNA = ATContrasenna;
    IF VERIFICAR = 1 THEN
        pVERIFICAR := 1;
    ELSE
        pVERIFICAR := 0;
    END IF;
END;

--Para verificar el rol del usuario
CREATE OR REPLACE PROCEDURE USUARIO_ROL_LOGIN (pATUSUARIO IN VARCHAR2, pATCONTRASENNA IN VARCHAR2, pVERIFICAR OUT NUMBER)
AS
VERIFICAR NUMBER;
BEGIN
    SELECT COUNT(1)
    INTO VERIFICAR
    FROM TBUsername
    WHERE pATUSUARIO = ATUsername AND pATCONTRASENNA = ATContrasenna AND ATRolUsername = 'Administrador';
    IF VERIFICAR = 1 THEN
        pVERIFICAR := 1;
    ELSE
        pVERIFICAR := 0;
    END IF;
END;
--Esto es solo para verificar que el procedimiento almacenado este correcto

/*SET SERVEROUTPUT ON;
DECLARE
VERIFICAR NUMBER;
BEGIN
    USUARIO_LOGIN('Administrador','1234',VERIFICAR);
    DBMS_OUTPUT.PUT_LINE(VERIFICAR);
COMMIT;
END;*/

/*------------------------------ CRUD USUARIOS ------------------------------*/
--Ingresar usuario
CREATE OR REPLACE PROCEDURE Agregar_Usuario 
    (pNombre IN varchar2, pApellido_1 IN varchar2, pApellido_2 IN varchar2, 
    pCedula IN varchar2, pRol IN varchar2)
AS 
BEGIN
    INSERT INTO TBUSUARIOS
    (ATNombre,ATApellido_1,ATApellido_2,ATCedula,ATActivo,ATRol)
    VALUES 
    (pNombre,pApellido_1,pApellido_2,pCedula,'ACTIVO',pRol);
END;

--Ingresar username

CREATE OR REPLACE PROCEDURE Agregar_Username
    (pUsername  IN varchar2, pContrasenna IN varchar2, pDuenoUsername IN varchar2, 
    pRolUsername IN varchar2)
AS 
BEGIN
    INSERT INTO TBUsername
    (ATUsername,ATContrasenna,ATDuenoUsername,ATRolUsername)
    VALUES 
    (pUsername,pContrasenna,pDuenoUsername,pRolUsername);
END;

--Ver usuarios

CREATE OR REPLACE PROCEDURE Ver_Usuarios
    (registros out sys_refcursor)
AS
BEGIN
    OPEN registros FOR SELECT * FROM TBUSUARIOS;
END;

/*---------------------------------------------------------------------------*/
--Cargar cada dato de usuario por separado ---!!!!!!!IGNORAR ERA PUERBA!!!!!!!!
CREATE OR REPLACE PROCEDURE Ver_Datos_Usuario
    (nombre out sys_refcursor,apellido_1 out sys_refcursor, pCedula in Varchar2)
AS
BEGIN
    OPEN nombre FOR SELECT ATNOMBRE FROM TBUSUARIOS WHERE ATCEDULA = pCedula;
    OPEN apellido_1 FOR SELECT ATAPELLIDO_1 FROM TBUSUARIOS WHERE ATCEDULA = pCedula;
END;

/*---------------------------------------------------------------------------*/
/*SI QUIERO SABER EL NUMERO DE UN USUARIO EN ESPECIFICO SOLO HAGO UN SELECT CON INNER JOIN*/
SELECT u.ATNombre, t.ATTelefono FROM TBUsuarios u INNER JOIN TBTelefonos t ON u.ATCedula = t.ATDuenoTelefono;

/*------------------------------ CRUD SEDES ------------------------------*/
--Ingresar sede

CREATE OR REPLACE PROCEDURE Agregar_Sede 
    (pNombreSede IN varchar2, pCodPostal IN varchar2,pProvincia IN varchar2,pCanton 
    IN varchar2,pDistrito IN varchar2,pDireccionExacta IN varchar2)
AS 
BEGIN
    INSERT INTO TBSEDES
    (ATNombreSede,ATCodPostal,ATProvincia,ATCanton,ATDistrito,ATDireccionExacta)
    VALUES 
    (pNombreSede,pCodPostal,pProvincia,pCanton,pDistrito,pDireccionExacta);
END;

/*------------------------------ TABLAS CORREO/TELEFONO ------------------------------*/
--Ingresar correo

CREATE OR REPLACE PROCEDURE Agregar_Correo 
    (pCorreo IN varchar2, pDuenoCorreo IN varchar2, pCategoriaCorreo IN varchar2)
AS 
BEGIN
    INSERT INTO TBCorreos
    (ATCorreo,ATDuenoCorreo,ATCategoriaCorreo)
    VALUES 
    (pCorreo,pDuenoCorreo,pCategoriaCorreo);
END;

/*---------------------------------------------------------------------------*/
--Ingresar tel�fono

CREATE OR REPLACE PROCEDURE Agregar_Telefono 
    (pTelefono IN varchar2, pDuenoTelefono IN varchar2, pCategoriaTelefono IN varchar2)
AS 
BEGIN
    INSERT INTO TBTelefonos
    (ATTelefono,ATDuenoTelefono,ATCategoriaTelefono)
    VALUES 
    (pTelefono,pDuenoTelefono,pCategoriaTelefono);
END;

/*TEGO QUE PONER ESTOS PROCEDURES DONDE VAN*/
create or replace NONEDITIONABLE PROCEDURE ActualizarUsuario 
(pNombre IN varchar2, pApellido_1 IN varchar2, pApellido_2 IN varchar2, 
pCedula IN varchar2, pRol IN varchar2)
AS
BEGIN
    UPDATE TBUSUARIOS SET ATNOMBRE = pNombre, ATAPELLIDO_1 = pApellido_1,
    ATAPELLIDO_2 = pApellido_2, ATROL = pRol
    WHERE ATCEDULA = pCedula;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
    NULL;
    WHEN OTHERS THEN
    RAISE;
END;

create or replace NONEDITIONABLE PROCEDURE ActualizarUsername
(pUsername IN varchar2, pContrasenna IN varchar2, pDuenoUsername IN varchar2, pRol IN varchar2)
AS
BEGIN
    UPDATE TBUSERNAME SET ATUSERNAME = pUsername, ATCONTRASENNA = pContrasenna,
    ATROLUSERNAME = pRol
    WHERE ATDUENOUSERNAME = pDuenoUsername;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
    NULL;
    WHEN OTHERS THEN
    RAISE;
END;

create or replace NONEDITIONABLE PROCEDURE ActualizarTelefono
(pTelefono IN varchar2, pDuenoTelefono IN varchar2, pCategoria IN varchar2)
AS
BEGIN
    UPDATE TBTELEFONOS SET ATTELEFONO = pTelefono, ATCATEGORIATELEFONO = pCategoria
    WHERE ATDUENOTELEFONO = pDuenoTelefono;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
    NULL;
    WHEN OTHERS THEN
    RAISE;
END;

create or replace NONEDITIONABLE PROCEDURE ActualizarCorreo
(pCorreo IN varchar2, pDuenoCorreo IN varchar2, pCategoria IN varchar2)
AS
BEGIN
    UPDATE TBCORREOS SET ATCORREO= pCorreo, ATCATEGORIACORREO = pCategoria
    WHERE ATDUENOCORREO = pDuenoCorreo;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
    NULL;
    WHEN OTHERS THEN
    RAISE;
END;

create or replace NONEDITIONABLE PROCEDURE ActualizarCorreo
(pCorreo IN varchar2, pDuenoCorreo IN varchar2, pCategoria IN varchar2)
AS
BEGIN
    UPDATE TBCORREOS SET ATCORREO= pCorreo, ATCATEGORIACORREO = pCategoria
    WHERE ATDUENOCORREO = pDuenoCorreo;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
    NULL;
    WHEN OTHERS THEN
    RAISE;
END;

create or replace NONEDITIONABLE PROCEDURE VER_SEDE_ESPECIFICA
    (pNombreSede in VARCHAR2, registros out sys_refcursor)
AS
BEGIN
    OPEN registros FOR SELECT * FROM TBSEDES WHERE ATNOMBRESEDE = pNombreSede; 
END;

create or replace NONEDITIONABLE PROCEDURE ActualizarSede
(pNombreSede IN varchar2,pCodPostal IN varchar2, pCanton IN varchar2,pDistrito IN varchar2,pDireccionExacta IN varchar2)
AS
BEGIN
    UPDATE TBSEDES SET ATCODPOSTAL = pCodPostal, ATCANTON = pCanton, ATDISTRITO = pDistrito,
    ATDIRECCIONEXACTA = pDireccionExacta WHERE ATNOMBRESEDE = pNombreSede;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
    NULL;
    WHEN OTHERS THEN
    RAISE;
END;

/*************************************************************************************************************************
**************************************************************************************************************************
**********************************************************TRIGGERS********************************************************
**************************************************************************************************************************
**************************************************************************************************************************/ 

---TABLA USUARIOS

CREATE OR REPLACE TRIGGER AUDITORIADEUSUARIOS
AFTER INSERT OR DELETE OR UPDATE ON TBUSUARIOS
DECLARE
    VUSUARIO VARCHAR2(20);
    VACCION VARCHAR2(200);
    VFECHA DATE;
BEGIN
    SELECT USER,SYSDATE INTO VUSUARIO,VFECHA FROM DUAL;
    IF INSERTING THEN 
        VACCION := 'SE INSERT� UN USUARIO';
    ELSIF UPDATING THEN
        VACCION := 'SE ACTUALIZ� UN USUARIO';
    ELSIF DELETING THEN
        VACCION := 'SE ELIMINO UN USUARIO';
    END IF;
        INSERT INTO TBAuditoriaUsuarios (USUARIO,ACCION,FECHA) VALUES (VUSUARIO,VACCION,VFECHA);
END;

--TABLA SEDES

CREATE OR REPLACE TRIGGER AUDITORIADESEDES
AFTER INSERT OR DELETE OR UPDATE ON TBSEDES
DECLARE
    VSEDE VARCHAR2(20);
    VACCION VARCHAR2(200);
    VFECHA DATE;
BEGIN
    SELECT USER,SYSDATE INTO VSEDE,VFECHA FROM DUAL;
    IF INSERTING THEN 
        VACCION := 'SE INSERT� LA SEDE';
    ELSIF UPDATING THEN
        VACCION := 'SE ACTUALIZ� UNA SEDE';
    ELSIF DELETING THEN
        VACCION := 'SE ELIMINO UNA SEDE';
    END IF;
        INSERT INTO TBAuditoriaSedes (SEDE,ACCION,FECHA) VALUES (VSEDE,VACCION,VFECHA);
END;

--TABLA DONACIONES

CREATE OR REPLACE TRIGGER AUDITORIADONACIONES
AFTER INSERT OR DELETE OR UPDATE ON TBDONACION
DECLARE
    VSEDE VARCHAR2(20);
    VACCION VARCHAR2(200);
    VFECHA DATE;
BEGIN
    SELECT USER,SYSDATE INTO VSEDE,VFECHA FROM DUAL;
    IF INSERTING THEN 
        VACCION := 'SE INSERT� LA DONACION';
    ELSIF UPDATING THEN
        VACCION := 'SE ACTUALIZ� LA DONACION';
    ELSIF DELETING THEN
        VACCION := 'SE ELIMINO LA DONACION';
    END IF;
        INSERT INTO TBAuditoriaDonaciones (SEDE,ACCION,FECHA) VALUES (VSEDE,VACCION,VFECHA);
END;
