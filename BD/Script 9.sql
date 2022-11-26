/*************************************************************************************************************************
**************************************************************************************************************************
****************************************BORRADO DE TABLAS*****************************************************************
**************************************************************************************************************************
**************************************************************************************************************************/
--DESCOMENTAR SI SE OCUPA EJECUTAR

/*DROP TABLE TBCORREOSSEDE;
DROP TABLE TBCORREOSUSUARIOS;
DROP TABLE TBDONACION;
DROP TABLE TB_TIPODONACION;
DROP TABLE TBTELEFONOSUSUARIOS;
DROP TABLE TBTELEFONOSSEDES;
DROP TABLE TBUSUARIOS;
DROP TABLE TBROL;
DROP TABLE TBSEDE;
DROP TABLE TBLOCALIZACION;*/


/*************************************************************************************************************************
**************************************************************************************************************************
****************************************CREACION DE TABLAS****************************************************************
**************************************************************************************************************************
**************************************************************************************************************************/

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
    PRIMARY KEY(ATCedula)
);


ALTER TABLE TBUsuarios ADD CONSTRAINT fk_rol FOREIGN KEY (ATRol) REFERENCES TBRol (ATRol);

/*----------------------------------------------------------------------------*/
CREATE TABLE TBRol(
    ATRol INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
	ATTipoRol varchar2(50),
    PRIMARY KEY(ATRol)
);

/*----------------------------------------------------------------------------*/
CREATE TABLE TBSede(
    ATId_Sede INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
    ATId_Localizacion int,
    PRIMARY KEY(ATId_Sede)
);

ALTER TABLE TBSede ADD CONSTRAINT fk_sede_localizacion FOREIGN KEY (ATId_Localizacion) REFERENCES TBLocalizacion (ATId_Localizacion);

/*----------------------------------------------------------------------------*/
CREATE TABLE TBLocalizacion(
    ATId_Localizacion INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
	ATProvincia varchar2(50),
    ATCanton varchar2(50),
    ATDistrito varchar2(50),
    ATDireccionExacta varchar2(100),
    PRIMARY KEY(ATId_Localizacion)
);

/*----------------------------------------------------------------------------*/
CREATE TABLE TBCorreosUsuarios(
    ATId_CorreoUsuario INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
	ATCorreo varchar2(150),
    ATUsuario varchar(30),
    PRIMARY KEY(ATId_CorreoUsuario)
);

ALTER TABLE TBCorreosUsuarios ADD CONSTRAINT fk_usuarios_correo FOREIGN KEY (ATUsuario) REFERENCES TBUsuarios (ATCedula);

/*----------------------------------------------------------------------------*/
CREATE TABLE TBCorreosSede(
    ATId_CorreosSede INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
	ATCorreo varchar2(150),
    ATSede int,
    PRIMARY KEY(ATId_CorreosSede)
);

ALTER TABLE TBCorreosSede ADD CONSTRAINT fk_sede_correo FOREIGN KEY (ATSede) REFERENCES TBSede (ATId_Sede);

/*----------------------------------------------------------------------------*/
CREATE TABLE TBTelefonosUsuarios(
    ATId_TelefonoUsuario INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
	ATTelefono varchar2(150),
    ATUsuario varchar(30),
    PRIMARY KEY(ATId_TelefonoUsuario)
);

ALTER TABLE TBTelefonosUsuarios ADD CONSTRAINT fk_telefono_correo FOREIGN KEY (ATUsuario) REFERENCES TBUsuarios (ATCedula);

/*----------------------------------------------------------------------------*/
CREATE TABLE TBTelefonosSedes(
    ATId_TelefonoUsuario INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
	ATTelefono varchar2(150),
    ATSede int,
    PRIMARY KEY(ATId_TelefonoUsuario)
);

ALTER TABLE TBTelefonosSedes ADD CONSTRAINT fk_telefono_sede FOREIGN KEY (ATSede) REFERENCES TBSede (ATId_Sede);

/*----------------------------------------------------------------------------*/
CREATE TABLE TB_TipoDonacion(
    ATId_TipoDonacion INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
    ATTipo_Donacion varchar2(500),
    PRIMARY KEY(ATId_TipoDonacion)
);

/*----------------------------------------------------------------------------*/
CREATE TABLE TBDonacion(
    ATId_Donacion INT GENERATED BY DEFAULT ON NULL AS IDENTITY,
    ATFecha date,
    ATProcedencia varchar2(80),
    ATId_TDonacion int,
    ATCedulaUsuario varchar(30),
    ATId_Sede int,
    ATCantidad int,
    ATDescripcion varchar2(500),
    ATMetodoPago varchar2(60),
    ATMonto int,
    PRIMARY KEY(ATId_Donacion) 
);

ALTER TABLE TBDonacion ADD CONSTRAINT fk_donacion_especie_usuario FOREIGN KEY (ATCedulaUsuario) REFERENCES TBUsuarios (ATCedula);
ALTER TABLE TBDonacion ADD CONSTRAINT fk_donacion_especie_sede FOREIGN KEY (ATId_Sede) REFERENCES TBSede (ATId_Sede);
ALTER TABLE TBDonacion ADD CONSTRAINT fk_donacion_especie FOREIGN KEY (ATId_TDonacion) REFERENCES TB_TipoDonacion (ATId_TipoDonacion);

/*************************************************************************************************************************
**************************************************************************************************************************
****************************************SE INSERTAN DATOS*****************************************************************
**************************************************************************************************************************
**************************************************************************************************************************/

--ROLES DEFINIDOS PARA USUARIO

INSERT INTO TBRol VALUES (1,'administrador');
INSERT INTO TBRol VALUES (2,'empleado');

/*----------------------------------------------------------------------------*/
--USUARIOS DE PRUEBA

--Rol de administrador
INSERT INTO TBUsuarios (ATUsuario,ATContrasenna,ATNombre, ATApellido_1,ATApellido_2,ATCedula,ATActivo,ATRol) VALUES
(   'UsuarioAdmin',
    '12345',
    'NombrePrueba',
    'Apellido1Prueba',
    'Apellido2Prueba',
    '12',
    1,
    1);

--Rol de empleado
INSERT INTO TBUsuarios (ATUsuario,ATContrasenna,ATNombre, ATApellido_1,ATApellido_2,ATCedula,ATActivo,ATRol) VALUES
(   'UsuarioEmpleado',
    '12345',
    'NombrePrueba2',
    'Apellido1Prueba2',
    'Apellido2Prueba2',
    '123',
    1,
    2);
    

/*************************************************************************************************************************
**************************************************************************************************************************
****************************************PROCEDIMIENTOS ALMACENADOS********************************************************
**************************************************************************************************************************
**************************************************************************************************************************/


--Para ingresar donaciones
CREATE OR REPLACE PROCEDURE INSERTAR_DONACION 
(pFecha IN date, pProcedencia IN varchar2, pTipoDonacion IN int, pCedulaUsuario IN varchar2, pSede IN int, pCantidad IN int, pDescripcion IN varchar2, pMetodoPago IN varchar2, pMonto IN int)
AS
BEGIN
    INSERT INTO TBDonacion (ATFecha,ATProcedencia,ATId_TDonacion,ATCedulaUsuario,ATId_Sede,ATCantidad,ATDescripcion,ATMetodoPago,ATMonto)
    VALUES (pFecha,pProcedencia,pTipoDonacion,pCedulaUsuario,pSede,pCantidad,pDescripcion,pMetodoPago,pMonto);
END;

/*----------------------------------------------------------------------------*/
--Para LOGIN
CREATE OR REPLACE PROCEDURE USUARIO_LOGIN (pATUSUARIO IN VARCHAR2, pATCONTRASENNA IN VARCHAR2, pVERIFICAR OUT NUMBER)
AS
VERIFICAR NUMBER;
BEGIN
    SELECT COUNT(1)
    INTO VERIFICAR
    FROM TBUSUARIOS
    WHERE pATUSUARIO = ATUSUARIO AND pATCONTRASENNA = ATCONTRASENNA;
    IF VERIFICAR = 1 THEN
        pVERIFICAR := 1;
    ELSE
        pVERIFICAR := 0;
    END IF;
END;

DECLARE
ROL NUMBER;
BEGIN
    USUARIO_LOGIN('UsuarioPrueba','12345',ROL);
    DBMS_OUTPUT.PUT_LINE(ROL);
COMMIT;
END;

--Esto es solo para verificar que el procedimiento almacenado este correcto
/*SET SERVEROUTPUT ON;

DECLARE
ROL NUMBER;
RESULTADO BOOLEAN;
BEGIN
    USUARIO_LOGIN('UsuarioPrueba','12345',ROL,RESULTADO);
    DBMS_OUTPUT.PUT_LINE(ROL);
COMMIT;
END;*/

/*************************************************************************************************************************
**************************************************************************************************************************
****************************************TRIGGERS**************************************************************************
**************************************************************************************************************************
**************************************************************************************************************************/






/*************************************************************************************************************************
**************************************************************************************************************************
****************************************FUNCIONES*************************************************************************
**************************************************************************************************************************
**************************************************************************************************************************/