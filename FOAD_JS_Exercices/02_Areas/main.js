
const Point = require('./02_Areas_Point.js');
const Area = require('./02_Areas_part2.js');

//On créer une zone de 6 * 6
let area1 = new Area(6, 6);

//on Créer les point de la zone1
let point1 = new Point(1, 5);
let point2 = new Point(2, 3);
let point3 = new Point(8, 6);
let point4 = new Point(2, 6);
let point5 = new Point(4, 3);

let point6 = new Point(2, 5);
let point7 = new Point(4, 3);
let point8 = new Point(8, 6);
let point9 = new Point(2, 6);
let point10 = new Point(7, 3);

//On ajoute les points a la zone1

area1.addPoint(point1);
area1.addPoint(point2);
area1.addPoint(point3);
area1.addPoint(point4);
area1.addPoint(point5);
console.log(area1.getPointArea())
area1.addPoint(point6);
area1.addPoint(point7);
area1.addPoint(point8);
area1.addPoint(point9);
area1.addPoint(point10);
console.log(area1.getPointArea())
/*
area1.needAllInside();
console.log(area1.getPointArea());*/

area1.areaSort();
console.log(area1.getPointArea())