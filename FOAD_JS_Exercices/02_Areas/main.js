
const Point = require('./02_Areas_Point.js');
const Area = require('./02_Areas_part2.js');

//On cr�er une zone de 6 * 6
let area1 = new Area(6, 6);
//on Cr�er les point de la zone1
let point1 = new Point(1, 5);
let point2 = new Point(3, 2);
let point3 = new Point(1, 6);
let point4 = new Point(4, 3);
//On ajoute les points a la zone1
area1.addPoint(point1);
area1.addPoint(point2);
area1.addPoint(point3);
area1.addPoint(point4);



console.log(area1);
