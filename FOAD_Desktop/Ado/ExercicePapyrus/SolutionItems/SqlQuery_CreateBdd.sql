USE master;
DROP DATABASE IF EXISTS PapyrusNicolas;
CREATE DATABASE PapyrusNicolas;
USE PapyrusNicolas;

CREATE TABLE Fournisseurs(
   NUMERO_FOURNISSEUR INT identity NOT NULL,
   NOM_FOURNISSEUR VARCHAR(50) NOT NULL,
   NUMERO_RUE_FOURNISSEUR TINYINT NULL,
   RUE_FOURNISSEUR VARCHAR(50) NOT NULL,
   CODE_POSTAL_FOURNISSEUR INT NOT NULL,
   VILLE_FOURNISSEUR VARCHAR(50) NOT NULL,
   CONTACT_FOURNISSEUR VARCHAR(50) NULL,
   SATISFACTION_FOURNISSEUR TINYINT NULL,
   CONSTRAINT PK_NUMERO_FOURNISSEUR PRIMARY KEY(NUMERO_FOURNISSEUR)
);

CREATE TABLE Clients(
   NUMERO_CLIENT INT identity NOT NULL,
   NOM_CLIENT VARCHAR(255) NOT NULL,
   NUMERO_RUE_CLIENT TINYINT NULL,
   RUE_CLIENT VARCHAR(50) NOT NULL,
   VILLE_CLIENT VARCHAR(50) NOT NULL,
   CODE_POSTAL_CLIENT INT NOT NULL,
   CONSTRAINT PK_NUMERO_CLIENT PRIMARY KEY(NUMERO_CLIENT),
);

CREATE TABLE Produits(
   CODE_ARTICLE CHAR(4) NOT NULL,
   LIBELLE_ARTICLE VARCHAR(128) NOT NULL,
   STOCK_ALERTE TINYINT NOT NULL,
   STOCK_PHYSIQUE SMALLINT NULL,
   QUANTITE_ANNUELLE SMALLINT NULL,
   UNITE_MESURE VARCHAR(5) NOT NULL,
   CONSTRAINT PK_CODE_ARTICLE PRIMARY KEY(CODE_ARTICLE)
);

CREATE TABLE Produits_a_Vendre(
   CODE_ARTICLE CHAR(4) NOT NULL,
   NUMERO_FOURNISSEUR INT NOT NULL,
   DELIVRER TINYINT NOT NULL,
   QUANTITE SMALLINT NOT NULL,
   PRIX DECIMAL(5,2) NOT NULL,
   CONSTRAINT PK_CODE_ARTICLE_NUMERO_FOURNISSEUR PRIMARY KEY(CODE_ARTICLE, NUMERO_FOURNISSEUR),
   CONSTRAINT FK_CODE_ARTICLE_TO_Produits_a_Vendre FOREIGN KEY(CODE_ARTICLE) REFERENCES Produits(CODE_ARTICLE),
   CONSTRAINT FK_NUMERO_FOURNISSEUR_TO_Produits_a_Vendre FOREIGN KEY(NUMERO_FOURNISSEUR) REFERENCES Fournisseurs(NUMERO_FOURNISSEUR)
);

CREATE TABLE Commandes(
   NUMERO_COMMANDE INT identity NOT NULL,
   OBSERVATION_COMMANDE VARCHAR(255) NULL,
   DATE_COMMANDE DATE NOT NULL,
   NUMERO_CLIENT INT NOT NULL,
   CONSTRAINT PK_NUMERO_COMMANDE PRIMARY KEY(NUMERO_COMMANDE),
   CONSTRAINT FK_NUMERO_CLIENT_TO_Clients FOREIGN KEY(NUMERO_CLIENT) REFERENCES Clients(NUMERO_CLIENT)
);

CREATE TABLE Liste_Commandes(
   CODE_ARTICLE CHAR(4) NOT NULL,
   NUMERO_COMMANDE INT NOT NULL,
   NUMERO_LIVRAISON INT NOT NULL,
   QUANTITE_COMMANDER SMALLINT NOT NULL,
   PRIX_UNITAIRE DECIMAL(5,2) NOT NULL,
   QUANTITE_DELIVRER SMALLINT NOT NULL,
   DERNIERE_LIVRAISON DATE NOT NULL,
   CONSTRAINT PK_CODE_ARTICLE_NUMERO_COMMANDE PRIMARY KEY(CODE_ARTICLE, NUMERO_COMMANDE),
   CONSTRAINT FK_CODE_ARTICLE_FROM_Produits FOREIGN KEY(CODE_ARTICLE) REFERENCES Produits(CODE_ARTICLE),
   CONSTRAINT FK_NUMERO_COMMANDE_TO_Liste_Commandes FOREIGN KEY(NUMERO_COMMANDE) REFERENCES Commandes(NUMERO_COMMANDE),
);
