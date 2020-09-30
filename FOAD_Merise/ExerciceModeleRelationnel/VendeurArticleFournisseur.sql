DROP DATABASE IF EXISTS vendeur_article_fournisseur;
CREATE DATABASE vendeur_article_fournisseur;
USE vendeur_article_fournisseur;
CREATE TABLE Rayon
(
nomRayon VARCHAR(50) NOT NULL PRIMARY KEY,
etage TINYINT NOT NULL
);
CREATE TABLE Employe
(
codeE INT NOT NULL PRIMARY KEY,
nom VARCHAR(100) NOT NULL,
salaire DECIMAL(6,2) NOT NULL,
nomRayon VARCHAR(50) NULL,
codeE_chef INT NULL,
CONSTRAINT FK_codeE_chef FOREIGN KEY(codeE_chef) REFERENCES Employe(codeE),
CONSTRAINT FK_nomRayon_Employe FOREIGN KEY(nomRayon) REFERENCES Rayon(nomRayon)
);
CREATE TABLE Article
(
codeA INT NOT NULL PRIMARY KEY,
nomA VARCHAR(128) NOT NULL,
typeA VARCHAR(50) NOT NULL,
nomRayon VARCHAR(50) NULL,
CONSTRAINT FK_nomRayon_Article FOREIGN KEY(nomRayon) REFERENCES Rayon(nomRayon)
);
CREATE TABLE Fournisseur
(
codeF INT NOT NULL PRIMARY KEY,
adresse VARCHAR(128) NOT NULL,
nomF VARCHAR(50) NOT NULL
);
CREATE TABLE Livraison
(
codeF INT UNIQUE,
codeA INT NOT NULL,
quantite MEDIUMINT NOT NULL,
CONSTRAINT FK_codeA FOREIGN KEY(codeA) REFERENCES Article(codeA),
CONSTRAINT FK_codeF FOREIGN KEY(codeF) REFERENCES Fournisseur(codeF),
CONSTRAINT PK_Livraison PRIMARY KEY(codeF, codeA)
);
CREATE INDEX IX_Employe_nom ON Employe(nom);
CREATE INDEX IX_Article_type ON Article(typeA);