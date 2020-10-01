use tp_agence_voyages;


-- Créer les vues répondant aux demandes suivantes :


-- 1) Afficher les informations de toutes les villes (informations du pays incluses)

CREATE VIEW city_info AS SELECT cities.city_code, cities.city_name, cities.country_code, countries.country_name FROM cities, countries WHERE countries.country_code = cities.country_code;
SELECT * FROM city_info ORDER BY city_code;

-- 2) Afficher les noms, prénoms, email de tous les clients qui ont réservé au moins 1 voyage.  
--    On a besoin de connaitre le titre du voyage ainsi que le pays de destination

CREATE VIEW clients_reservation AS SELECT clients.client_lastname, clients.client_firstname, clients.client_email, trips.trip_title, countries.country_name FROM clients, orders, trips, countries, cities  WHERE orders.client_id = clients.client_id AND trips.trip_code = orders.trip_code AND trips.city_code = cities.city_code AND countries.country_code = cities.country_code AND orders.order_quantity >= 1;
SELECT * FROM clients_reservation ORDER BY client_lastname ASC;

-- 3) Créer la vue permettant d'afficher :
--     Toutes les informations d'un client (sauf son mot de passe)
--     Le  nom de son commercial associé
--     Le nombre de voyages qu'il a commandé ET payé
--     La destination de son dernier voyage (ville + pays)

CREATE VIEW client_full_view AS SELECT clients.client_lastname, clients.client_firstname, clients.client_email, sales.com_name, cities.city_name, countries.country_name, COUNT(*) AS paid_travel_number, trips.trip_title FROM clients, sales, orders, trips, cities, countries WHERE orders.client_id = clients.client_id AND sales.com_code = clients.com_code AND trips.trip_code = orders.trip_code AND trips.city_code = cities.city_code AND countries.country_code = cities.country_code  AND order_paid=1 GROUP BY clients.client_id;
SELECT * FROM client_full_view ORDER BY client_lastname;
 
