-- creation of the database

DROP DATABASE IF EXISTS employees_management;
CREATE DATABASE employees_management;
USE employees_management;

-- creation of the table department

CREATE TABLE dept (
  DEPTNO int(10) UNSIGNED NOT NULL,
  DNAME varchar(50) NOT NULL,
  LOC varchar(150) NOT NULL,
  CONSTRAINT PK_DEPTNO PRIMARY KEY(DEPTNO)
) ENGINE=InnoDB CHARSET=utf8mb4 COLLATE utf8mb4_general_ci;

-- creation of the table employees

CREATE TABLE emp (
  EMPNO int(10) UNSIGNED NOT NULL,
  ENAME varchar(50) NOT NULL,
  JOB varchar(50) NOT NULL,
  MGR int(10) UNSIGNED DEFAULT NULL,
  HIREDATE date NOT NULL,
  SAL decimal(8,2) NOT NULL,
  COMM int(11) DEFAULT NULL,
  DEPTNO int(10) UNSIGNED NOT NULL,
  CONSTRAINT FK_dept_to_emp FOREIGN KEY(DEPTNO) REFERENCES dept(DEPTNO),
  CONSTRAINT FK_emp_to_emp FOREIGN KEY(MGR) REFERENCES emp(EMPNO),
  CONSTRAINT PK_EMPNO PRIMARY KEY(EMPNO)
) ENGINE=InnoDB CHARSET=utf8mb4 COLLATE utf8mb4_general_ci;
