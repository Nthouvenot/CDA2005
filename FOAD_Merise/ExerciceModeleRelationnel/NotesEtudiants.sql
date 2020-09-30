DROP DATABASE IF EXISTS notes_etudiants;
CREATE DATABASE notes_etudiants;
USE notes_etudiants;
CREATE TABLE Etudiants
(
id_etudiant INT UNSIGNED NOT NULL PRIMARY KEY,
nom VARCHAR(50) NOT NULL,
prenom VARCHAR(50) NOT NULL,
date_E DATE NOT NULL
);
CREATE TABLE Matieres
(
id_matiere INT NOT NULL PRIMARY KEY,
lib_matiere VARCHAR(20) UNIQUE NOT NULL,
coefficient TINYINT UNSIGNED NOT NULL
);
CREATE TABLE Controles
(
id_etudiant INT UNSIGNED NOT NULL, 
id_matiere INT NOT NULL ,
Note TINYINT UNSIGNED NULL,
CONSTRAINT FK_etudiants_matieres FOREIGN KEY (id_etudiant) REFERENCES Etudiants(id_etudiant),
CONSTRAINT FK_matieres FOREIGN KEY (id_matiere) REFERENCES Matieres(id_matiere),
CONSTRAINT PK_etudiants_matieres PRIMARY KEY (id_etudiant, id_matiere)
);