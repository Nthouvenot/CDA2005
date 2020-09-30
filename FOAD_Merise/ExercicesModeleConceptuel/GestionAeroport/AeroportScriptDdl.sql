DROP DATABASE IF EXISTS Aeroport;
CREATE DATABASE Aeroport;
USE Aeroport;
CREATE TABLE Planes_Type
(
Plane_Type_Name VARCHAR(10) NOT NULL,
Constructor_Name VARCHAR(50) NOT NULL,
Engine_Power SMALLINT UNSIGNED NOT NULL,
Number_Of_Place SMALLINT UNSIGNED NOT NULL,
CONSTRAINT PK_Plane_Type_Name PRIMARY KEY(Plane_Type_Name)
) ENGINE InnoDB CHARSET utf8mb4 COLLATE utf8mb4_general_ci;
CREATE TABLE Owners
(
Owner_Name VARCHAR(100) NOT NULL,
Owner_Type BOOLEAN NOT NULL,
Owner_City VARCHAR(50) NOT NULL,
Owner_Zip_Code MEDIUMINT NOT NULL,
Owner_Street VARCHAR(100) NOT NULL,
Owner_Street_Number SMALLINT UNSIGNED NOT NULL,
Owner_Phone_Number CHAR(12),
CONSTRAINT PK_Owner_Name PRIMARY KEY(Owner_Name),
CONSTRAINT CK_Owner_Zip_Code CHECK(Owner_Zip_Code < 96000)
) ENGINE InnoDB CHARSET utf8mb4 COLLATE utf8mb4_general_ci;
CREATE TABLE Planes
(
Registration_Number CHAR(11) NOT NULL,
Purchase_Date DATE NOT NULL,
Plane_Type_Name VARCHAR(10) NOT NULL,
Owner_Name VARCHAR(100) NOT NULL,
CONSTRAINT FK_Planes_Type_To_Plane FOREIGN KEY(Plane_Type_Name) REFERENCES Planes_Type(Plane_Type_Name),
CONSTRAINT FK_Owners_To_Plane FOREIGN KEY(Owner_Name) REFERENCES Owners(Owner_Name),
CONSTRAINT PK_Registration_Number PRIMARY KEY(Registration_Number)
) ENGINE InnoDB CHARSET utf8mb4 COLLATE utf8mb4_general_ci;
CREATE TABLE Mechanics
(
Mechanic_Lastname VARCHAR(50) NOT NULL,
Mechanic_Firstname VARCHAR(50) NOT NULL,
Mechanic_City VARCHAR(50) NOT NULL,
Mechanic_Zip_Code MEDIUMINT NOT NULL,
Mechanic_Street VARCHAR(100) NOT NULL,
Mechanic_Street_Number SMALLINT UNSIGNED NOT NULL,
Mechanic_Phone_Number CHAR(12),
CONSTRAINT PK_Mechanic_Lastname_Firstname PRIMARY KEY(Mechanic_Lastname, Mechanic_Firstname),
CONSTRAINT CK_Mechanic_Zip_Code CHECK(Mechanic_Zip_Code < 96000)
) ENGINE InnoDB CHARSET utf8mb4 COLLATE utf8mb4_general_ci;
CREATE TABLE Maintenance_Sheets
(
Registration_Number CHAR(11) NOT NULL,
Mechanic_Lastname VARCHAR(50) NOT NULL,
Mechanic_Firstname VARCHAR(50) NOT NULL,
Maintenance_Date DATETIME NOT NULL,
Maintenance_Object TEXT NOT NULL,
CONSTRAINT FK_Planes_To_Maintenance_Sheets FOREIGN KEY(Registration_Number) REFERENCES Planes(Registration_Number),
CONSTRAINT FK_Mechanics_To_Maintenance_Sheets FOREIGN KEY(Mechanic_Lastname, Mechanic_Firstname) REFERENCES Mechanics(Mechanic_Lastname, Mechanic_Firstname),
CONSTRAINT PK_Registration_Number_Mechanic_Lastname_Mechanic_Firstname PRIMARY KEY(Registration_Number, Mechanic_Lastname, Mechanic_Firstname)
) ENGINE InnoDB CHARSET utf8mb4 COLLATE utf8mb4_general_ci;
CREATE TABLE Pilots
(
License_Number CHAR(13) NOT NULL,
Pilot_Lastname VARCHAR(50) NOT NULL,
Pilot_Firstname VARCHAR(50) NOT NULL,
Pilot_City VARCHAR(50) NOT NULL,
Pilot_Zip_Code MEDIUMINT NOT NULL,
Pilot_Street VARCHAR(100) NOT NULL,
Pilote_Street_Number SMALLINT UNSIGNED NOT NULL,
Pilot_Phone_Number CHAR(12),
CONSTRAINT PK_License_Number PRIMARY KEY(License_Number),
CONSTRAINT CK_Pilot_Zip_Code CHECK(Pilot_Zip_Code < 96000)
) ENGINE InnoDB CHARSET utf8mb4 COLLATE utf8mb4_general_ci;
CREATE TABLE Pilots_Autorized_Plane
(
Plane_Type_Name VARCHAR(10) NOT NULL,
License_Number CHAR(13) NOT NULL,
Number_Of_Fly SMALLINT UNSIGNED NOT NULL,
CONSTRAINT FK_Planes_To_Pilots_Autorized_Plane FOREIGN KEY(Plane_Type_Name) REFERENCES Planes(Plane_Type_Name),
CONSTRAINT FK_Pilots_To_Pilots_Autorized_Plane FOREIGN KEY(License_Number) REFERENCES Pilots(License_Number),
CONSTRAINT PK_Planes_Type_Name_License_Number PRIMARY KEY(Plane_Type_Name, License_Number)
) ENGINE InnoDB CHARSET utf8mb4 COLLATE utf8mb4_general_ci;