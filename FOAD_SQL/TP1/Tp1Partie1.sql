USE employees_management;

-- 1. Donner nom, job, numéro et salaire de tous les employés, puis seulement des employés du département 10
SELECT ENAME, JOB, EMPNO, SAL FROM emp;
SELECT ENAME, JOB, EMPNO, SAL FROM emp WHERE DEPTNO=10;

-- 2. Donner nom, job et salaire des employés de type MANAGER dont le salaire est supérieur à 2800
SELECT ENAME, JOB, SAL FROM emp WHERE JOB='MANAGER' AND SAL>2800;

-- 3. Donner la liste des MANAGER n'appartenant pas au département 30
SELECT ENAME, JOB FROM emp WHERE JOB='MANAGER' AND DEPTNO != 30;

-- 4. Liste des employés de salaire compris entre 1200 et 1400
SELECT ENAME, JOB, SAL FROM emp WHERE SAL BETWEEN 1200 AND 1400;

-- 5. Liste des employés des départements 10 et 30 classés dans l'ordre alphabétique
SELECT ENAME, DEPTNO FROM emp WHERE DEPTNO IN(10,30) ORDER BY ENAME ASC;

-- 6. Liste des employés du département 30 classés dans l'ordre des salaires croissants
SELECT ENAME, DEPTNO, SAL FROM emp WHERE DEPTNO=30 ORDER BY SAL ASC;

-- 7. Liste de tous les employés classés par emploi et salaires décroissants
SELECT ENAME, JOB, SAL FROM emp ORDER BY JOB AND SAL DESC;

-- 8. Liste des différents emplois
SELECT DISTINCT JOB FROM emp ORDER BY JOB ASC;

-- 9. Donner le nom du département où travaille ALLEN
SELECT ENAME, DNAME FROM emp INNER JOIN dept ON emp.DEPTNO = dept.DEPTNO WHERE ENAME='ALLEN';

-- 10. Liste des employés avec nom du département, nom, job, salaire classés par noms de départements et par salaires décroissants.
SELECT DNAME, ENAME, JOB, SAL FROM dept INNER JOIN emp ON dept.DEPTNO = emp.DEPTNO ORDER BY DNAME, SAL DESC;

-- 11. Liste des employés vendeurs (SALESMAN) avec affichage de nom, salaire, commissions, salaire + commissions
SELECT ENAME, SAL, COMM, (SAL+COMM) AS Total_Gain FROM emp WHERE JOB='SALESMAN' ORDER BY ENAME ASC;

-- 12. Liste des employés du département 20: nom, job, date d'embauche sous forme VEN 28 FEV 1997'
SELECT ENAME, JOB, DATE_FORMAT(HIREDATE, '%a\ %d\ %b\ %Y') AS HIREDATE2 FROM emp ORDER BY ENAME ASC;

-- 13. Donner le salaire le plus élevé par département
SELECT DNAME, MAX(SAL) AS SALAIRE_MAX FROM emp INNER JOIN dept ON emp.DEPTNO = dept.DEPTNO GROUP BY DNAME ORDER BY DNAME ASC;

-- 14. Donner département par département masse salariale, nombre d'employés, salaire moyen par type d'emploi.
SELECT SUM(SAL + CASE WHEN COMM IS NULL THEN 0 ELSE COMM END) AS payroll, COUNT(ENAME) AS numbre_of_employees, AVG(SAL) AS salary_average, JOB, DNAME FROM emp INNER JOIN dept ON emp.DEPTNO = dept.DEPTNO GROUP BY JOB ORDER BY JOB ASC;
-- version Franck
select sum(sal + CASE WHEN comm IS NULL THEN 0 ELSE comm END), count(ename), avg(sal) from emp where ename < 2 group by deptno ORDER BY JOB ASC;

-- 15. Même question mais on se limite aux sous-ensembles d'au moins 2 employés
SELECT SUM(SAL + CASE WHEN COMM IS NULL THEN 0 ELSE COMM END) AS payroll, COUNT(ENAME) AS numbre_of_employees, AVG(SAL) AS salary_average, JOB, DNAME FROM emp INNER JOIN dept ON emp.DEPTNO = dept.DEPTNO GROUP BY JOB ORDER BY JOB ASC; -- reste a faire

-- 16. Liste des employés (Nom, département, salaire) de même emploi que JONES
SELECT ENAME, JOB, DNAME, SAL FROM emp INNER JOIN dept ON emp.DEPTNO = dept.DEPTNO WHERE JOB = (SELECT JOB FROM emp WHERE ENAME='JONES');

-- 17. Liste des employés (nom, salaire) dont le salaire est supérieur à la moyenne globale des salaires
-- SELECT AVG(SAL) FROM emp; -- calcul de la moyenne globale des salaires
SELECT ENAME, SAL FROM emp HAVING SAL > ALL (SELECT AVG(SAL) FROM emp);