USE PapyrusNicolas;
GO  
CREATE PROCEDURE GetCommandeBySuplier  
    @suplier_number int   
AS   
    SELECT Commandes.NUMERO_COMMANDE ,Commandes.DATE_COMMANDE, Commandes.OBSERVATION_COMMANDE
    FROM Liste_Commandes, Produits_a_Vendre, Fournisseurs, Commandes
    WHERE Fournisseurs.NUMERO_FOURNISSEUR = Produits_a_Vendre.NUMERO_FOURNISSEUR AND Liste_Commandes.CODE_ARTICLE = Produits_a_Vendre.CODE_ARTICLE AND Liste_Commandes.NUMERO_COMMANDE = Commandes.NUMERO_COMMANDE AND Fournisseurs.NUMERO_FOURNISSEUR = @suplier_number;
GO  