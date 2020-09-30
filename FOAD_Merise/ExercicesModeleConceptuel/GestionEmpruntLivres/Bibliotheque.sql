DROP DATABASE IF EXIST library
CREATE DATABASE library
USE library
CREATE TABLE Clients
(
Client_id INT PRIMARY KEY NOT NULL AUTO INCREMENT,
Client_firstname VARCHAR (50) NOT NULL,
Client_lastname VARCHAR (50) NOT NULL,
Client_deposit SMALLINT NOT NULL,
)
CREATE TABLE Books
(
Book_id INT PRIMARY KEY NOT NULL,
Book_name VARCHAR (128) NOT NULL,
Book_editor VARCHAR (50) NOT NULL,
Book_authors VARCHAR (100) NOT NULL,
Book_purchaseDate DATE NOT NULL,
Book_status VARCHAR (50) NOT NULL,
Book_copyNumber BYTE NULL,
)
CREATE TABLE LoanBooks
(
Client_id INT NOT NULL,
Book_id INT NOT NULL,
LoanBook_date DATETIME NOT NULL,
LoanBook_return DATETIME NOT NULL,
PRIMARY KEY (Client_id, Book_id),
)
