INSERT INTO SALLE (ID_SALLE, NOM_SALLE)
		VALUES (0 , 'D20');
		
INSERT INTO SALLE (ID_SALLE, NOM_SALLE)
		VALUES (0 , 'D21');

INSERT INTO SALLE (ID_SALLE, NOM_SALLE)
		VALUES (0 , 'D22');

INSERT INTO SALLE (ID_SALLE, NOM_SALLE)
		VALUES (0 , 'D23');
		
INSERT INTO SALLE (ID_SALLE, NOM_SALLE)
		VALUES (0 , 'D24');	

INSERT INTO SALLE (ID_SALLE, NOM_SALLE)
		VALUES (0 , 'D25');
		
INSERT INTO SALLE (ID_SALLE, NOM_SALLE)
		VALUES (0 , 'D26');
		
INSERT INTO SALLE (ID_SALLE, NOM_SALLE)
		VALUES (0 , 'D27');
		
INSERT INTO SALLE (ID_SALLE, NOM_SALLE)
		VALUES (0 , 'D28');
		
INSERT INTO SALLE (ID_SALLE, NOM_SALLE)
		VALUES (0 , 'D29');

INSERT INTO ETAT (ID_ETAT, LIBELLE, CODE_COULEUR)
		VALUES (0, 'réservée', 'rouge');
		
INSERT INTO ETAT (ID_ETAT, LIBELLE, CODE_COULEUR)
		VALUES (0, 'disponible', 'vert');
		

INSERT INTO RESERVATION (ID_SALLE,ID_EMPLOYE,ID_ETAT,DATEDEBUT)
VALUES (1, 1, 1, TO_DATE('07-04-2017 17:00:00','DD-MM-YYYY HH24:MI:SS'));

INSERT INTO EMPLOYE
VALUES (0, 'DUPONT', 'JEAN', 'Jeanlogin', 'Jeanmdp');


SELECT TO_CHAR(DATEDEBUT, 'DD-MM-YYYY HH24:MI'), TO_CHAR(DATEFIN, 'DD-MM-YYYY HH24:MI') 
FROM RESERVATION WHERE ID_SALLE = 1;

SELECT SALLE.NOM_SALLE FROM V_SALLE_DISPO, SALLE
WHERE v_salle_dispo.id_salle = SALLE.ID_SALLE;

