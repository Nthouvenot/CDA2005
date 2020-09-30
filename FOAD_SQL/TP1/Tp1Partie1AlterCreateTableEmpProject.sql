-- 18. Création d'une table PROJET avec comme colonnes numéro de projet (3 chiffres), nom de projet(5 caractères), budget. Entrez les valeurs suivantes:
-- 101, ALPHA, 96000
-- 102, BETA, 82000
-- 103, GAMMA, 15000
USE employees_management;
CREATE TABLE IF NOT EXISTS project
(
PROJECT_NUMBER SMALLINT UNSIGNED,
PROJECT_NAME CHAR(5),
BUDGET INT UNSIGNED,
CONSTRAINT PK_PROJECT_NUMBER PRIMARY KEY(PROJECT_NUMBER)
);
INSERT INTO project(PROJECT_NUMBER, PROJECT_NAME, BUDGET) VALUES(101, 'ALPHA', 96000);
INSERT INTO project(PROJECT_NUMBER, PROJECT_NAME, BUDGET) VALUES(102, 'BETA', 82000);
INSERT INTO project(PROJECT_NUMBER, PROJECT_NAME, BUDGET) VALUES(103, 'GAMMA', 15000);

-- 19. Ajouter l'attribut numéro de projet à la table EMP et affecter tous les vendeurs du département 30 au projet 101, et les autres au projet 102
ALTER TABLE emp ADD PROJECT_NUMBER SMALLINT UNSIGNED;
ALTER TABLE emp ADD CONSTRAINT FK_project_to_emp FOREIGN KEY(PROJECT_NUMBER) REFERENCES project(PROJECT_NUMBER);
UPDATE emp SET PROJECT_NUMBER = 101 WHERE JOB='SALESMAN' AND DEPTNO=30;
UPDATE emp SET PROJECT_NUMBER = 102 WHERE JOB != 'SALESMAN'  OR (JOB='SALESMAN' AND DEPTNO != 30);

-- 20. Créer une vue comportant tous les employés avec nom, job, nom de département et nom de projet
DROP VIEW IF EXISTS VW_employees_job;
CREATE VIEW VW_employees_job AS SELECT ENAME, JOB, DNAME, PROJECT_NAME FROM dept, emp, project WHERE emp.PROJECT_NUMBER = project.PROJECT_NUMBER AND emp.DEPTNO = dept.DEPTNO;

-- 21. A l'aide de la vue créée précédemment, lister tous les employés avec nom, job, nom de département et nom de projet triés sur nom de département et nom de projet
SELECT ENAME, JOB, DNAME, PROJECT_NAME FROM VW_employees_job ORDER BY DNAME AND PROJECT_NAME;

-- 22. Donner le nom du projet associé à chaque manager
SELECT ENAME, JOB, PROJECT_NAME FROM VW_employees_job WHERE JOB='MANAGER' ORDER BY ENAME;