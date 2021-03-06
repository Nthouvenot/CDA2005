DROP DATABASE IF EXISTS editeur;
CREATE DATABASE editeur;
USE editeur;
CREATE TABLE Livre
(
isbn BIGINT UNSIGNED NOT NULL PRIMARY KEY,
titre VARCHAR(50) NOT NULL
);
CREATE TABLE Exemplaire
(
num_exemplaire INT UNSIGNED NOT NULL,
isbn BIGINT UNSIGNED NOT NULL,
etat CHAR(1) NOT NULL DEFAULT 'D',
CONSTRAINT FK_editeur FOREIGN KEY(isbn) REFERENCES Livre(isbn),
CONSTRAINT PK_Exemplaire PRIMARY KEY(num_exemplaire, isbn)
);