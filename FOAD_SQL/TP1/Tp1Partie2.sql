USE employees_management;

-- 1. Afficher la liste des managers (liste des résponsable hiérachique) des départements 20 et 30 
-- SELECT ENAME, JOB FROM emp WHERE JOB='MANAGER' AND DEPTNO IN(20,30) ORDER BY ENAME ASC;
SELECT ENAME, JOB FROM emp WHERE DEPTNO IN(20, 30) AND EMPNO IN (SELECT DISTINCT MGR FROM emp);

-- 2. Afficher la liste des employés qui ne sont pas manager (liste qui ne sont pas responsable hiérachique) et qui ont été embauchés en 81
-- SELECT ENAME, JOB, HIREDATE FROM emp WHERE JOB != 'MANAGER' AND HIREDATE LIKE('1981%') ORDER BY HIREDATE;
SELECT * FROM emp WHERE EMPNO NOT IN (SELECT DISTINCT MGR FROM emp WHERE MGR IS NOT NULL) AND DATE_FORMAT(HIREDATE, '%Y') = 1981;

-- 3. Afficher la liste des employés ayant une commission
SELECT ENAME, COMM FROM emp WHERE COMM != 0 ORDER BY COMM ASC;

-- 4. Afficher la liste des noms, numéros de département, jobs et date d'embauche triés par Numero de Département et JOB les derniers embauches d'abord.
SELECT ENAME, DEPTNO, JOB, HIREDATE FROM emp ORDER BY HIREDATE DESC, JOB ASC, DEPTNO ASC;

-- 5. Afficher la liste des employés travaillant à DALLAS
SELECT ENAME, LOC FROM emp INNER JOIN dept ON emp.DEPTNO = dept.DEPTNO WHERE LOC='DALLAS' ORDER  BY ENAME ASC;
-- autre syntaxe
SELECT ENAME, LOC FROM emp, dept WHERE emp.DEPTNO = dept.DEPTNO and LOC='DALLAS';

-- 6. Afficher les noms et dates d'embauche des employés embauchés avant leur manager, avec le nom et date d'embauche du manager.
-- SELECT DISTINCT MGR FROM emp; -- requête de recherche des manager
select e.ename,e.hiredate,m.ename as 'nom manager',m.hiredate as 'date embauche manager' from emp e,emp m where e.MGR = m.EMPNO and e.HIREDATE < m.HIREDATE and e.EMPNO NOT IN (SELECT DISTINCT emp.MGR from emp where emp.MGR IS NOT NULL) ORDER BY e.deptno;

SELECT ENAME, HIREDATE FROM emp WHERE EMPNO != ANY (SELECT DISTINCT MGR FROM emp) AND emp.EMPNO != emp.MGR;
-- 7. Lister les numéros des employés n'ayant pas de subordonné.
SELECT * FROM emp WHERE EMPNO NOT IN (SELECT DISTINCT MGR FROM emp WHERE MGR IS NOT NULL);

-- 8. Afficher les noms et dates d'embauche des employés embauchés avant BLAKE
SELECT ENAME, HIREDATE FROM emp WHERE HIREDATE <= (SELECT HIREDATE FROM emp WHERE ENAME='BLAKE') AND ENAME != 'BLAKE' ORDER BY HIREDATE DESC;

-- 9. Afficher les employés embauchés le même jour que FORD.
SELECT ENAME, HIREDATE FROM emp WHERE DATE_FORMAT(HIREDATE, '%d') = (SELECT DATE_FORMAT(HIREDATE, '%d') FROM emp WHERE ENAME='FORD') AND ENAME != 'FORD';

-- 10. Lister les employés ayant le même manager que CLARK.
SELECT * FROM emp WHERE MGR = (SELECT MGR FROM emp WHERE ENAME='CLARK') ORDER BY EMPNO ASC;

-- 11. Lister les employés ayant même job et même manager que TURNER.
SELECT * FROM emp WHERE JOB=(SELECT JOB FROM emp WHERE ENAME='TURNER') AND MGR=(SELECT MGR FROM emp WHERE ENAME='TURNER') ORDER BY EMPNO;

-- 12. Lister les employés du département RESEARCH embauchés le même jour que quelqu'un du département SALES.
SELECT * FROM emp, dept WHERE emp.DEPTNO = dept.DEPTNO AND DNAME ='RESEARCH' AND DATE_FORMAT(HIREDATE, '%d') = ANY (SELECT DATE_FORMAT(HIREDATE, '%d') FROM emp, dept WHERE emp.DEPTNO = dept.DEPTNO AND DNAME='SALES');

-- 13. Lister le nom des employés et également le nom du jour de la semaine correspondant à leur date d'embauche.
SELECT ENAME, DATE_FORMAT(HIREDATE, '%W') AS HIREDATE_DAY FROM emp ORDER BY ENAME ASC;

-- 14. Donner, pour chaque employé, le nombre de mois qui s'est écoulé entre leur date d'embauche et la date actuelle.
SELECT ENAME, ROUND((DATEDIFF(CURRENT_DATE, HIREDATE)/30)) AS NUMBER_OF_MONTH FROM emp ORDER BY ENAME;

-- 15. Afficher la liste des employés ayant un M et un A dans leur nom
SELECT * FROM emp WHERE LOCATE ('A', ENAME) AND LOCATE ('M', ENAME);

-- 16. Afficher la liste des employés ayant deux 'A' dans leur nom.
SELECT * FROM emp WHERE ENAME LIKE '%a%a%';

-- 17. Afficher les employés embauchés avant tous les employés du département 10.
SELECT * FROM emp WHERE HIREDATE < ALL (SELECT HIREDATE FROM emp WHERE DEPTNO=10);

-- 18. Sélectionner le métier où le salaire moyen est le plus faible.
-- SELECT JOB, AVG(SAL) AS AVERAGE_SAL FROM emp GROUP BY JOB; -- moyenne des salaire par job
-- SELECT JOB, MIN(AVERAGE_SAL) FROM (SELECT JOB, AVG(SAL) AS AVERAGE_SAL FROM emp GROUP BY JOB) AS grp; -- avec table temporaire
SELECT JOB, AVG(SAL) FROM emp GROUP BY JOB HAVING AVG(SAL) <= ALL (SELECT AVG(SAL) FROM emp GROUP BY JOB);

-- 19. Sélectionner le département ayant le plus d'employes.
-- SELECT COUNT(EMPNO) AS NUMBER_OF_EMPLOYEES, dept.DNAME FROM emp INNER JOIN dept ON emp.DEPTNO = dept.DEPTNO GROUP BY dept.DNAME; -- nombre d'employé par département avec recuperation du nom du département
SELECT COUNT(EMPNO) AS NUMBER_OF_EMPLOYEES, dept.DNAME FROM emp INNER JOIN dept ON emp.DEPTNO = dept.DEPTNO GROUP BY dept.DNAME HAVING COUNT(EMPNO) >= ALL (SELECT COUNT(EMPNO) FROM emp INNER JOIN dept ON emp.DEPTNO = dept.DEPTNO GROUP BY dept.DNAME);

-- 20. Donner la répartition en pourcentage du nombre d'employés par département selon le modèle ci-dessous
-- Département Répartition en %
-- ----------- ----------------
-- 10 21.43
-- 20 35.71
-- 30 42.86
-- SELECT COUNT(EMPNO) AS NUMBER_OF_EMPLOYEES FROM emp GROUP BY DEPTNO; -- calcul du nombre d'employé par département
-- SELECT COUNT(*) FROM emp; -- calcul du nombre total d'employé
SELECT DEPTNO, ROUND((COUNT(EMPNO)*100)/(SELECT COUNT(*) FROM emp), 2) AS PERCENT_NUMBER_OF_EMPLOYEES FROM emp GROUP BY DEPTNO;