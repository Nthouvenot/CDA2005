DROP DATABASE IF EXISTS vin_negoce;
CREATE DATABASE vin_negoce;
USE vin_negoce;
CREATE TABLE Vigneron
(
Num_Vigneron INT NOT NULL PRIMARY KEY,
Nom_Vigneron VARCHAR(50) NOT NULL,
Prenom_Vigneron VARCHAR(50) NOT NULL,
Ville_Vigneron VARCHAR(128) NOT NULL,
CONSTRAINT UQ_Nom_Prenom UNIQUE(Nom_Vigneron, Prenom_Vigneron)
);
CREATE TABLE Appreciation
(
Num_Vigneron_Appreciateur INT NOT NULL,
Num_Vigneron_Apprecie INT NOT NULL,
Note DECIMAL(4,2) NOT NULL,
CONSTRAINT FK_Num_Vigneron_Appreciateur FOREIGN KEY(Num_Vigneron_Appreciateur) REFERENCES Vigneron(Num_Vigneron),
CONSTRAINT FK_Num_Vigneron_Apprecie FOREIGN KEY(Num_Vigneron_Apprecie) REFERENCES Vigneron(Num_Vigneron),
CONSTRAINT PK_Appreciation PRIMARY KEY(Num_Vigneron_Appreciateur, Num_Vigneron_Apprecie)
);
CREATE TABLE Vin
(
Num_Vin INT NOT NULL PRIMARY KEY,
Cru VARCHAR(50) NOT NULL,
Millesime DATE NOT NULL,
Num_Vigneron INT NOT NULL,
CONSTRAINT FK_Num_Vigneron_Vin FOREIGN KEY(Num_Vigneron) REFERENCES Vigneron(Num_Vigneron)
);
CREATE TABLE Buveur
(
Num_Buveur INT NOT NULL PRIMARY KEY,
Nom_Buveur VARCHAR(50) NOT NULL,
Prenom_Buveur VARCHAR(50) NOT NULL,
Ville VARCHAR(255) NOT NULL
);
CREATE TABLE Commande
(
Num_Commande INT NOT NULL PRIMARY KEY,
Date_Commande DATETIME NOT NULL,
Num_Buveur INT NOT NULL,
CONSTRAINT FK_Num_Buveur FOREIGN KEY(Num_Buveur) REFERENCES Buveur(Num_Buveur)
);
CREATE TABLE Vin_Commande
(
Num_Vigneron INT NOT NULL,
Num_Commande INT NOT NULL,
Qantite MEDIUMINT NOT NULL,
CONSTRAINT FK_Num_Vigneron_Commande FOREIGN KEY(Num_Vigneron) REFERENCES Vigneron(Num_Vigneron),
CONSTRAINT FK_Num_Commande FOREIGN KEY(Num_Commande) REFERENCES Commande(Num_Commande),
CONSTRAINT PK_Vin_Commande PRIMARY KEY(Num_Vigneron, Num_Commande)
);
CREATE INDEX IX_Nom_Prenom_Buveur ON Buveur(Nom_Buveur, Prenom_Buveur);
CREATE VIEW Représentant AS SELECT *  FROM Buveur;