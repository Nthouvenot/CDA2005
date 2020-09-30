DROP DATABASE IF EXISTS  tp_agence_voyages;

CREATE DATABASE IF NOT EXISTS tp_agence_voyages CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
use tp_agence_voyages; 


CREATE TABLE IF NOT EXISTS countries (
    country_code CHAR(2) PRIMARY KEY,
    country_name VARCHAR(128) NOT NULL
)engine=InnoDb CHARSET utf8mb4 COLLATE utf8mb4_unicode_ci;


CREATE TABLE IF NOT EXISTS cities (
    city_code INT PRIMARY KEY AUTO_INCREMENT,
    city_name VARCHAR(128) NOT NULL,
    country_code CHAR(2)
)engine=InnoDb CHARSET utf8mb4 COLLATE utf8mb4_unicode_ci;


CREATE TABLE IF NOT EXISTS themes (
    theme_code INT PRIMARY KEY AUTO_INCREMENT,
    theme_name VARCHAR(32),
    theme_description TEXT
)  ENGINE=INNODB CHARSET utf8mb4 COLLATE utf8mb4_unicode_ci;


CREATE TABLE IF NOT EXISTS services (
    service_code INT PRIMARY KEY AUTO_INCREMENT,
    service_name VARCHAR(32) NOT NULL,
    service_description TEXT
)engine=InnoDb CHARSET utf8mb4 COLLATE utf8mb4_unicode_ci;


CREATE TABLE IF NOT EXISTS sales (
    com_code CHAR(5) PRIMARY KEY,
    com_name VARCHAR(64) NOT NULL,
    com_password CHAR(60) NOT NULL,
    com_substitute CHAR(5) NULL
)engine=InnoDb CHARSET utf8mb4 COLLATE utf8mb4_unicode_ci;

        
CREATE TABLE IF NOT EXISTS clients (
    client_id INT PRIMARY KEY AUTO_INCREMENT,
    client_lastname VARCHAR(32) NOT NULL,
    client_firstname VARCHAR(32) NOT NULL,
    client_email VARCHAR(128) UNIQUE NOT NULL,
    client_phone CHAR(16) UNIQUE NOT NULL,
    client_added DATE NOT NULL,
    client_password CHAR(60) NOT NULL,
    com_code CHAR(5) NOT NULL
)engine=InnoDb CHARSET utf8mb4 COLLATE utf8mb4_unicode_ci;


CREATE TABLE IF NOT EXISTS trips (
    trip_code INT PRIMARY KEY AUTO_INCREMENT,
    trip_title VARCHAR(128),
    trip_available INT,
    trip_start DATETIME,
    trip_end DATETIME,
    trip_price DECIMAL(7 , 2 ),
    trip_overview TEXT,
    trip_description TEXT NULL,
    city_code INT NOT NULL
)engine=InnoDb CHARSET utf8mb4 COLLATE utf8mb4_unicode_ci;


CREATE TABLE IF NOT EXISTS orders (
    client_id INT AUTO_INCREMENT,
    trip_code INT,
    order_quantity TINYINT NOT NULL,
    order_paid TINYINT NOT NULL,
    PRIMARY KEY (client_id , trip_code)    
)engine=InnoDb CHARSET utf8mb4 COLLATE utf8mb4_unicode_ci;


CREATE TABLE IF NOT EXISTS steps (
    city_code INT,
    trip_code INT,
    step_start DATETIME,
    step_end DATETIME,
    PRIMARY KEY (city_code, trip_code)
)  ENGINE=INNODB CHARSET utf8mb4 COLLATE utf8mb4_unicode_ci;

    
CREATE TABLE IF NOT EXISTS suggests (
    trip_code INT,
    theme_code INT,
    PRIMARY KEY (trip_code, theme_code)
)engine=InnoDb CHARSET utf8mb4 COLLATE utf8mb4_unicode_ci;


CREATE TABLE IF NOT EXISTS notes (
    trip_code INT,
    service_code INT,
    client_id INT,
    service_score TINYINT,
    PRIMARY KEY (trip_code, service_code, client_id)
)engine=InnoDb CHARSET utf8mb4 COLLATE utf8mb4_unicode_ci;




ALTER TABLE cities 
	ADD CONSTRAINT fk_cities_country FOREIGN KEY (country_code) REFERENCES countries (country_code);

ALTER TABLE sales 
	ADD FOREIGN KEY (com_substitute) REFERENCES sales(com_code);

ALTER TABLE clients 
	ADD CONSTRAINT fk_client_com_code FOREIGN KEY (com_code) REFERENCES sales (com_code);

ALTER TABLE trips 
	ADD CONSTRAINT fk_trips_city FOREIGN KEY (city_code) REFERENCES cities (city_code);

ALTER TABLE orders 
	ADD CONSTRAINT fk_orders_client FOREIGN KEY (client_id) REFERENCES clients (client_id),
	ADD CONSTRAINT fk_orders_trip FOREIGN KEY (trip_code) REFERENCES trips (trip_code);

ALTER TABLE steps 
	ADD CONSTRAINT fk_steps_city FOREIGN KEY (city_code) REFERENCES cities (city_code),
    	ADD CONSTRAINT fk_steps_trip FOREIGN KEY (trip_code) REFERENCES trips (trip_code);

ALTER TABLE suggests 
	ADD CONSTRAINT fk_suggests_trip FOREIGN KEY (trip_code) REFERENCES trips (trip_code),
	ADD CONSTRAINT fk_suggests_theme FOREIGN KEY (theme_code) REFERENCES themes (theme_code);

ALTER TABLE notes 
	ADD CONSTRAINT fk_notes_trip FOREIGN KEY (trip_code) REFERENCES trips (trip_code),
	ADD CONSTRAINT fk_notes_service FOREIGN KEY (service_code) REFERENCES services (service_code),
	ADD CONSTRAINT fk_notes_client FOREIGN KEY (client_id) REFERENCES clients (client_id);