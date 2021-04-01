-- DML : Manipulation des données 
-- INSERT 
-- UPDATE 
-- DELETE 

-- INSERTION DU JEU D'ESSAI DANS LA BASE DE DONNEES db_trips 
-- Jeu d'essai = 	données factices pour tester le système 	et/ou	 données par défaut du système 

USE tp_agence_voyages;

INSERT INTO countries 
(country_code, country_name)
VALUES
('DE', 'Allemagne'),
('BE', 'Belgique'),
('FR', 'France'),
('IT', 'Italie');


INSERT INTO cities 
(city_name, country_code)
VALUES
('Mulhouse', 'FR'),
('Bruxelles', 'BE'),
('Milan', 'IT'),
('Liège', 'BE'),
('Cologne', 'DE'),
('Agen', 'FR');

INSERT INTO themes 
(theme_name, theme_description) 
VALUES 
('Culture', 'Activités culturelles'),
('Aventure', 'Stages d\'aventure et de survie accessibles'),
('Montagne', 'Panorama à couper le souffle'),
('Sports nautiques', 'Sports nautiques à proximité'),
('Repos', 'Situation calme propice au repos'),
('Enfants', 'Activités pour jeunes enfants disponibles'),
('Hiver', 'Sports d\'hiver');


INSERT INTO services 
(service_name, service_description) 
VALUES
('All inclusive', 'Pension complète et boissons à volonté'),
('Room Service', 'Service d\'étage 24h/24'),
('Coach Sportif', 'Activités sportives avec un coach'),
('Piscine chauffée', 'Piscine chauffée dans l\'hôtel');


INSERT INTO sales
(com_code, com_name, com_password, com_substitute) 
VALUES 
('HC123', 'Holems Cathy', '', NULL),
('ML282', 'Mannheim Luc', '', 'HC123'),
('KA326', 'Kipré Abdou', '', 'ML282'),
('BT517', 'Bahl Tarik', '', 'BT517'),
('AE742', 'Armanetti Estelle', '', 'HC123');



INSERT INTO clients 
(client_lastname, client_firstname, client_email, client_phone, client_added, client_password, com_code) 
VALUES
('Goldman', 'Gabriel', 'ggoldman@example.fr', '+33612345678', '2020-07-01', '', 'HC123'),
('Morel', 'Audrey', 'audrey68100@domain.com', '+33389123456', '2020-07-12', '', 'HC123'),
('Sharif', 'Sonia', 'sonia.sharif@example.fr', '+33676543210', '2020-07-23', '', 'ML282'),
('Mac Dowel', 'Jordan', 'mcjordan@mdj.fr', '+33388987654', '2020-08-09', '', 'KA326'),
('Lefebvre', 'Hugo', 'tartampion@site.fr', '+33787654321', '2020-08-11', '', 'AE742');


INSERT INTO trips
(trip_title, trip_available, trip_start, trip_end, trip_price, trip_overview, trip_description, city_code) 
VALUES 
('Ski à Mulhouse', 101, '2021-01-02', '2021-01-07', 999.99, 'Les pistes de Mulhouse vous attendent', NULL, 1),
('Gastronomie Belge', 23, '2021-04-16', '2021-04-18', 345.50, 'Au coeur de la zone où il fait bon de manger', NULL, 2),
('Culture à Milan', 17, '2021-04-17', '2021-01-23', 1300, 'Au coeur de Navigli, redécouvrez les beaux-arts', NULL, 3);


INSERT INTO suggests 
(trip_code, theme_code) 
VALUES 
(1, 3),
(1, 7),
(2, 1),
(2, 6),
(3, 1),
(3, 4),
(3, 6);


INSERT INTO orders 
(client_id, trip_code, order_quantity, order_paid) 
VALUES 
(1, 1, 1, 1),
(2, 3, 5, 1),
(3, 1, 5, 0),
(4, 2, 2, 0);

