USE employees_management;

-- 1. Afficher la liste des managers des départements 20 et 30
SELECT ENAME, JOB FROM emp WHERE JOB='MANAGER' AND DEPTNO IN(20,30) ORDER BY ENAME ASC;

-- 2. Afficher la liste des employés qui ne sont pas manager et qui ont été embauchés en 81
SELECT ENAME, JOB, HIREDATE FROM emp WHERE JOB != 'MANAGER' AND HIREDATE LIKE('1981%') ORDER BY HIREDATE;

-- 3. Afficher la liste des employés ayant une commission
SELECT ENAME, COMM FROM emp WHERE COMM != 0 ORDER BY COMM ASC;

-- 4. Afficher la liste des noms, numéros de département, jobs et date d'embauche triés par Numero de Département et JOB les derniers embauches d'abord.
SELECT ENAME, DEPTNO, JOB, HIREDATE FROM emp ORDER BY HIREDATE DESC, JOB ASC, DEPTNO ASC;

-- 5. Afficher la liste des employés travaillant à DALLAS
SELECT ENAME, LOC FROM emp INNER JOIN dept ON emp.DEPTNO = dept.DEPTNO WHERE LOC='DALLAS' ORDER  BY ENAME ASC;
-- autre syntaxe
SELECT ENAME, LOC FROM emp, dept WHERE emp.DEPTNO = dept.DEPTNO and LOC='DALLAS';

-- 6. Afficher les noms et dates d'embauche des employés embauchés avant leur manager, avec le nom et date d'embauche du manager.
-- aucune idée de la marche a suivre

-- 7. Lister les numéros des employés n'ayant pas de subordonné.
-- aucune idée de la marche a suivre

-- 8. Afficher les noms et dates d'embauche des employés embauchés avant BLAKE
SELECT ENAME, HIREDATE FROM emp WHERE HIREDATE <= (SELECT HIREDATE FROM emp WHERE ENAME='BLAKE') ORDER BY HIREDATE DESC;

-- 9. Afficher les employés embauchés le même jour que FORD.
SELECT ENAME, HIREDATE FROM emp WHERE (SELECT DATE_FORMAT(HIREDATE, '%d') FROM emp WHERE ENAME='FORD') = DAYOFMONTH(HIREDATE);

-- 10. Lister les employés ayant le même manager que CLARK.
SELECT * FROM emp WHERE MGR = (SELECT MGR FROM emp WHERE ENAME='CLARK') ORDER BY EMPNO ASC;

-- 11. Lister les employés ayant même job et même manager que TURNER.
SELECT * FROM emp WHERE JOB=(SELECT JOB FROM emp WHERE ENAME='TURNER') AND MGR=(SELECT MGR FROM emp WHERE ENAME='TURNER') ORDER BY EMPNO;

-- 12. Lister les employés du département RESEARCH embauchés le même jour que quelqu'un du département SALES.
SELECT * FROM emp WHERE (SELECT DAYOFMONTH(HIREDATE) FROM emp WHERE DEPTNO = (SELECT DEPTNO FROM dept WHERE DNAME='RESEARCH')) = (SELECT DAYOFMONTH(HIREDATE) FROM emp WHERE DEPTNO = (SELECT DEPTNO FROM dept WHERE DNAME='SALES'));
-- a terminer

-- 13. Lister le nom des employés et également le nom du jour de la semaine correspondant à leur date d'embauche.
SELECT ENAME, DATE_FORMAT(HIREDATE, '%W') AS HIREDATE_DAY FROM emp ORDER BY ENAME ASC;

-- 14. Donner, pour chaque employé, le nombre de mois qui s'est écoulé entre leur date d'embauche et la date actuelle.
SELECT ENAME, ROUND((DATEDIFF(CURRENT_DATE, HIREDATE)/30)) AS NUMBER_OF_MONTH FROM emp ORDER BY ENAME;

-- 15. Afficher la liste des employés ayant un M et un A dans leur nom.
SELECT * FROM emp WHERE LOCATE ('A', ENAME) AND LOCATE ('M', ENAME);

-- 16. Afficher la liste des employés ayant deux 'A' dans leur nom.
SELECT * FROM emp WHERE ENAME LIKE '%a%a%';

-- 17. Afficher les employés embauchés avant tous les employés du département 10.
SELECT * FROM emp WHERE HIREDATE < ALL (SELECT HIREDATE FROM emp WHERE DEPTNO=10);

-- 18. Sélectionner le métier où le salaire moyen est le plus faible.
SELECT JOB, AVG(SAL) AS SAL_AVERAGE FROM emp GROUP BY JOB; -- salaire moyen par JOB
