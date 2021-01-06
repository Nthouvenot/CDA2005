USE TrouveUnEmploiNicolas;
GO  

DROP PROCEDURE IF EXISTS InsertDiplome;
 GO

CREATE PROCEDURE InsertDiplome
    @id_diplome int,
    @id_demandeur int,
    @AnneeDeValidation DATETIME
AS
    INSERT INTO  DIPLOMESDUDEMANDEURDEMPLOI(IdDemandeurDEmploi, IdDuDiplomes, AnneeDeValidation) 
    VALUES(@id_diplome, @id_demandeur, @AnneeDeValidation);
GO