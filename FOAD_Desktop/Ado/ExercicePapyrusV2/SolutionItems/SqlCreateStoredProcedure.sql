USE PapyrusNicolas;
GO  

 DROP PROCEDURE IF EXISTS GetCommandeBySuplier;
 GO

CREATE PROCEDURE GetCommandeBySuplier  
    @suplier_number int   
AS   
    SELECT Commandes.NUMERO_COMMANDE ,Commandes.DATE_COMMANDE, Commandes.OBSERVATION_COMMANDE
    FROM Liste_Commandes, Produits_a_Vendre, Fournisseurs, Commandes
    WHERE Fournisseurs.NUMERO_FOURNISSEUR = Produits_a_Vendre.NUMERO_FOURNISSEUR AND Liste_Commandes.CODE_ARTICLE = Produits_a_Vendre.CODE_ARTICLE AND Liste_Commandes.NUMERO_COMMANDE = Commandes.NUMERO_COMMANDE AND Fournisseurs.NUMERO_FOURNISSEUR = @suplier_number;
GO  

DROP PROCEDURE IF EXISTS WriteSuplierTable;
 GO

CREATE PROCEDURE WriteSuplierTable
    @id_suplier int output,
    @name varchar(50),
    @street_number int,
    @street varchar(50),
    @zip_code int,
    @city varchar(50),
    @contact varchar(50),
    @satisfaction int
AS
    INSERT INTO Fournisseurs(NOM_FOURNISSEUR, NUMERO_RUE_FOURNISSEUR, RUE_FOURNISSEUR, CODE_POSTAL_FOURNISSEUR, VILLE_FOURNISSEUR, CONTACT_FOURNISSEUR, SATISFACTION_FOURNISSEUR)
    VALUES (@name, @street_number, @street, @zip_code, @city, @contact, @satisfaction);
    SET @id_suplier = @@identity
GO