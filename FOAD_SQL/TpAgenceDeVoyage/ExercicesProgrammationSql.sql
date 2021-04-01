use tp_agence_voyages;


-- Créer les procédures et/ou déclencheurs répondant aux cas suivants :



-- 1) Modifier les informations d'un client :
-- 		Le mot de passe ainsi que la date d'ajout du client ne peuvent pas être modifiés sur cette procédure
DROP PROCEDURE IF EXISTS update_client;
DELIMITER $$
CREATE PROCEDURE
update_client(IN id_in INT, IN lastname_in VARCHAR(32), IN firstname_in VARCHAR(32), IN email_in VARCHAR(128), IN phone_in CHAR(16), IN com_code_in CHAR(5))
BEGIN
DECLARE id_exists INT;
SELECT count(*) FROM clients WHERE clients.client_id = id_in INTO id_exists; -- on verifie que le client existe avant de mettre a jour le client
IF id_exists=1
THEN
	UPDATE clients SET client_lastname = lastname_in, client_firstname = firstname_in, client_email = email_in, client_phone = phone_in, com_code = com_code_in WHERE client_id = id_in;
ELSE
	SELECT "Erreur" AS message_type, CONCAT("client numero d'identifiant ",  id_in, " inconnu") AS message; -- si le client n'existe pas on envoie un message d'erreur
END IF;
END$$
DELIMITER ;

-- on test si la procedure fonctionne avec des donnees valide
CALL update_client(1, 'Goldman', 'Gabriel', 'goldman.gabriel@mail.com', '+33612345678', 'HC123');
SELECT * FROM clients WHERE client_id = 1;
-- on test si la procedure fonctionne avec un id client invalide
CALL update_client(8, 'Goldman', 'Gabriel', 'goldman.gabriel@mail.com', '+33612345678', 'HC123');

-- 2) Modifier le mot de passe d'un client (sans chiffrement pour l'exercice)
-- 		La procédure accepte 3 paramètres :  Le mot de passe actuel | Le nouveau mot de passe | Le nouveau mot de passe (pour confirmation)
-- 		Gérer les cas d'erreur
DROP PROCEDURE IF EXISTS update_password;
DELIMITER $$
CREATE PROCEDURE
update_password(IN id_in INT, IN last_password_in CHAR(60), IN new_password_in CHAR(60), IN new_password_confirm_in CHAR(60))
BEGIN
DECLARE id_exists INT;
SELECT COUNT(*) FROM clients WHERE client_id = id_in INTO id_exists; 
IF id_exists = 1 AND new_password_in = new_password_confirm_in -- on verifie que le client existe et que les password concorde avant de mettre a jour
THEN
	UPDATE clients SET client_password = new_password_in WHERE client_id = id_in;
ELSE
	IF id_exists != 1
    THEN
		SELECT "Erreur" AS message_type, CONCAT("client numero ",  id_in, " inconnu") AS message; -- si le client n'existe pas on envoie un message d'erreur
	END IF;
    IF new_password_in = new_password_confirm_in
    THEN
		SELECT "Erreur" AS message_type, "mot de passe différents"  AS message; -- si les mots de passe ne concorde on envoie un message d'erreur
	END IF;
    IF id_exists = 1 AND new_password_in = new_password_confirm_in
    THEN
		SELECT "Erreur" AS message_type, "mot de passe différents et client inconnu"  AS message; -- si les mots de passe ne concorde on envoie un message d'erreur
	END IF;
END IF;
END$$
DELIMITER ;

-- on test si la procedure fonctionne avec des donnees valide
CALL update_password(2, "", "monmotdepasse", "monmotdepasse");
SELECT * FROM clients WHERE client_id = 2;

-- on test si la procedure fonctionne avec un id invalide
CALL update_password(8, "", "monmotdepasse", "monmotdepasse");

-- on test si la procedure fonctionne avec mot de passe différent
CALL update_password(2, "", "monmotdepasse", "monmotdepasse2");
SELECT * FROM clients WHERE client_id = 2;

-- on test si la procedure fonctionne avec mot de passe différent et id invalide
CALL update_password(8, "", "monmotdepasse", "monmotdepasse2");

-- 3) si une étape est ajoutée à un voyage, vérifier que la ville étape n'est pas identique à la ville de départ du voyage.


-- 4) Un service ne peut pas porter le même nom qu'un thème et inversement.


-- 5) Lors de l'ajout ou la modification d'un voyage, le prix doit etre supérieur à 50 et la date de départ doit être inférieure à la date de retour


