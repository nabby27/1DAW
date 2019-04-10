DROP DATABASE IF EXISTS COMENSALES;
CREATE DATABASE COMENSALES;

use COMENSALES;

CREATE TABLE PERSONAS (
    ID INT AUTO_INCREMENT,
    NOMBRE VARCHAR(200),
    APELLIDOS VARCHAR(500),
    PRIMARY KEY (ID)
);

INSERT INTO PERSONAS (ID, NOMBRE, APELLIDOS) VALUES 
(1, "DANIEL FELIPE", "AGUIRRE MALDONADO"),
(2, "YAIZA", "AMOR ALVAREZ"),
(3, "ALEJANDRO", "AZNAR FERRER"),
(4, "JAIME", "BARRAJEN PEREZ"),
(5, "JUAN JOSE", "BERENGUER SELLES"),
(6, "GINES", "CATALA CONCA"),
(7, "JOSEP", "CRESPO SANTACREU"),
(8, "ORNELLA", "COPERTINO"),
(9, "IVAN PAUL", "CUSTODIO GAMERO"),
(10, "JUAN DANIEL", "DIAZ CADAVID"),
(11, "JUAN DANIEL", "DURO ORTEGA"),
(12, "JUAN JESUS", "GONZALEZ RODRIGUEZ"),
(13, "GUILLERMO", "HERNANDEZ DELGADO"),
(14, "LLUIS", "IVORRA FERRANDO"),
(15, "HAMZA", "LHIMER"),
(16, "LUIS ALEJANDRO", "LLUSIA MORGAN"),
(17, "JOSE FERNANDO", "LORA RIVERO"),
(18, "FABIOLA LUCIA", "MORA TEJEDOR"),
(19, "SANTIAGO", "PALACIO CARO"),
(20, "JESUS", "SAGISTIZABAL SAIZ"),
(21, "JOSE ANTONIO", "SANCHEZ NOVILLO"),
(22, "JORDI", "SANCHO MARTINEZ"),
(23, "DAMIAN ANTONIO", "SANTOS BALDO"),
(24, "WALTER OMAR", "SUAQUITA PORRAS");

CREATE TABLE TIPOS_PLATO (
    ID INT AUTO_INCREMENT,
    NOMBRE VARCHAR(200),
    PRIMARY KEY (ID)
);

INSERT INTO TIPOS_PLATO (ID, NOMBRE) VALUES
(1, "PRINCIPAL"),
(2, "SECUNDARIO");

CREATE TABLE PLATOS (
    ID INT AUTO_INCREMENT,
    NOMBRE VARCHAR(200),
    TIPO_PLATO INT,
    PRIMARY KEY (ID),
    FOREIGN KEY (TIPO_PLATO) REFERENCES TIPOS_PLATO(ID)
);

INSERT INTO PLATOS (ID, NOMBRE, TIPO_PLATO) VALUES
(1, "ARROZ CON POLLO", 1),
(2, "PAELLA VALENCIANA", 1),
(3, "FIDEUÁ", 1),
(4, "GAZPACHO", 1),
(5, "CARNE EN SALSA", 2),
(6, "MERLUZA A LA VASCA", 2),
(7, "HUEVOS CON PATATAS", 2),
(8, "PECHUGA CON VERDURAS", 2);

CREATE TABLE BEBIDAS (
    ID INT AUTO_INCREMENT,
    NOMBRE VARCHAR(200),
    PRIMARY KEY (ID)
);

INSERT INTO BEBIDAS (ID, NOMBRE) VALUES
(1, "AGUA"),
(2, "CERVEZA"),
(3, "VINO"),
(4, "COCA COLA");

CREATE TABLE POSTRES (
    ID INT AUTO_INCREMENT,
    NOMBRE VARCHAR(200),
    PRIMARY KEY (ID)
);

INSERT INTO POSTRES (ID, NOMBRE) VALUES
(1, "MANZANA ASADA"),
(2, "PASTEL DE FRUTA"),
(3, "FLAN"),
(4, "HELADO");

CREATE TABLE MENU_PERSONA (
    ID INT AUTO_INCREMENT,
    PERSONA VARCHAR(200),
    PLATO_PRINCIPAL VARCHAR(200),
    PLATO_SECUNDARIO VARCHAR(200),
    BEBIDA VARCHAR(200),
    POSTRE VARCHAR(200),
    PRIMARY KEY (ID)
    /*
    FOREIGN KEY (PERSONA) REFERENCES PERSONAS(ID),
    FOREIGN KEY (PLATO_PRINCIPAL) REFERENCES PLATOS(ID),
    FOREIGN KEY (PLATO_SECUNDARIO) REFERENCES PLATOS(ID),
    FOREIGN KEY (BEBIDA) REFERENCES BEBIDAS(ID),
    FOREIGN KEY (POSTRE) REFERENCES POSTRES(ID)
    */
);