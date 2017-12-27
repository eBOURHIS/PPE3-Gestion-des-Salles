-- -----------------------------------------------------------------------------
--             Génération d'une base de données pour
--                      Oracle Version 10g
--                        (1/12/2017 8:42:31)
-- -----------------------------------------------------------------------------
--      Nom de la base : Gestion_Salle
--      Projet : Espace de travail
--      Auteur : Charles de Foucauld
--      Date de dernière modification : 1/12/2017 8:40:35
-- -----------------------------------------------------------------------------

DROP TABLE ETAT CASCADE CONSTRAINTS;

DROP TABLE SALLE CASCADE CONSTRAINTS;

DROP TABLE EMPLOYE CASCADE CONSTRAINTS;

DROP TABLE RESERVATION CASCADE CONSTRAINTS;

-- -----------------------------------------------------------------------------
--       CREATION DE LA BASE 
-- -----------------------------------------------------------------------------

CREATE DATABASE Gestion_Salle;

-- -----------------------------------------------------------------------------
--       TABLE : ETAT
-- -----------------------------------------------------------------------------

CREATE TABLE ETAT
   (
    ID_ETAT NUMBER  NOT NULL,
    LIBELLE VARCHAR(32)  NOT NULL,
    CODE_COULEUR VARCHAR(32)  NOT NULL
,   CONSTRAINT PK_ETAT PRIMARY KEY (ID_ETAT)  
   ) ;

-- -----------------------------------------------------------------------------
--       TABLE : SALLE
-- -----------------------------------------------------------------------------

CREATE TABLE SALLE
   (
    ID_SALLE NUMBER(4)  NOT NULL,
    NOM_SALLE VARCHAR(32)  NOT NULL
,   CONSTRAINT PK_SALLE PRIMARY KEY (ID_SALLE)  
   ) ;

-- -----------------------------------------------------------------------------
--       TABLE : EMPLOYE
-- -----------------------------------------------------------------------------

CREATE TABLE EMPLOYE
   (
    ID_EMPLOYE NUMBER  NOT NULL,
    NOM VARCHAR(32)  NOT NULL,
    PRENOM VARCHAR(32)  NOT NULL,
	LOGIN VARCHAR(32)  NOT NULL,
	PASSWORD VARCHAR(32)  NOT NULL,
	CONSTRAINT PK_EMPLOYE PRIMARY KEY (ID_EMPLOYE)  
   ) ;

-- -----------------------------------------------------------------------------
--       TABLE : RESERVATION
-- -----------------------------------------------------------------------------

CREATE TABLE RESERVATION
   (
    ID_SALLE NUMBER  NOT NULL,
    ID_EMPLOYE NUMBER  NOT NULL,
    ID_ETAT NUMBER  NOT NULL,
    DATEFIN DATE  NULL,
    DATEDEBUT DATE  NOT NULL,
	LIBELLERESERVATION VARCHAR(128),
	CONSTRAINT PK_RESERVATION PRIMARY KEY (ID_SALLE, ID_EMPLOYE, ID_ETAT, DATEDEBUT)  
   ) ;

-- -----------------------------------------------------------------------------
--       INDEX DE LA TABLE RESERVATION
-- -----------------------------------------------------------------------------

CREATE  INDEX I_FK_RESERVATION_SALLE
     ON RESERVATION (ID_SALLE ASC)
    ;

CREATE  INDEX I_FK_RESERVATION_EMPLOYE
     ON RESERVATION (ID_EMPLOYE ASC)
    ;

CREATE  INDEX I_FK_RESERVATION_ETAT
     ON RESERVATION (ID_ETAT ASC)
    ;


-- -----------------------------------------------------------------------------
--       CREATION DES REFERENCES DE TABLE
-- -----------------------------------------------------------------------------


ALTER TABLE RESERVATION ADD (
     CONSTRAINT FK_RESERVATION_SALLE
          FOREIGN KEY (ID_SALLE)
               REFERENCES SALLE (ID_SALLE))   ;

ALTER TABLE RESERVATION ADD (
     CONSTRAINT FK_RESERVATION_EMPLOYE
          FOREIGN KEY (ID_EMPLOYE)
               REFERENCES EMPLOYE (ID_EMPLOYE))   ;

ALTER TABLE RESERVATION ADD (
     CONSTRAINT FK_RESERVATION_ETAT
          FOREIGN KEY (ID_ETAT)
               REFERENCES ETAT (ID_ETAT))   ;


-- -----------------------------------------------------------------------------
--                FIN DE GENERATION
-- -----------------------------------------------------------------------------