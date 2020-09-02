DROP DATABASE IF EXISTS notes_etudiants02;
CREATE DATABASE notes_etudiants02;
USE notes_etudiants02;
CREATE TABLE Etudiants
(
id_etudiant INT UNSIGNED NOT NULL PRIMARY KEY,
nom VARCHAR(50) NOT NULL,
prenom VARCHAR(50) NOT NULL,
date_e DATE NOT NULL
);
CREATE TABLE Matieres
(
id_matiere INT UNSIGNED NOT NULL PRIMARY KEY,
lib_matiere VARCHAR(20) NOT NULL UNIQUE,
coefficient TINYINT NOT NULL,
CONSTRAINT coefficient CHECK(coefficient<10)
);
CREATE TABLE Controles
(
id_etudiant INT UNSIGNED NOT NULL,
id_matiere INT UNSIGNED NOT NULL,
date_controle DATE NOT NULL,
note TINYINT NOT NULL,
CONSTRAINT FK_etudiants FOREIGN KEY(id_etudiant) REFERENCES Etudiants(id_etudiant),
CONSTRAINT FK_matieres FOREIGN KEY(id_matiere) REFERENCES Matieres(id_matiere),
CONSTRAINT note CHECK(note<20)
);