const Point = require('./02_Areas_Point')


let point1 = new Point(1, 5);
let point2 = new Point(4, 2);

console.log("valeur du point 1 et du point2");
console.log("point1 :" + point1.toString());
console.log("point2 :" + point2.toString());

//Test de la méthode copy(Point)
point1.copy(point2);
console.log();
console.log("copie du point 1 dans point2");
console.log("point1 :" + point1.toString());
console.log("point2 :" + point2.toString());

//Test de la méthode move(integer, integer)
console.log();
console.log("copie coordonnées dans point2");
console.log("point2 avant :" + point1.toString());
point2.move(2, 6);
console.log("point2 aprés :" + point2.toString());

//Test de la methode duplicate()
let point3;
console.log();
console.log("Duplication de point2 dans point3");
console.log("point2 :" + point2.toString() + " (avant)");
console.log("point3 :" + point3 + " (avant)");
point3 = point2.duplicate();
console.log("point2 :" + point2.toString() + " (aprés)");
console.log("point3 :" + point3.toString() + " (aprés)");

//Test de la méthode Rabbit
console.log("Echange de point2 avec point1");
console.log("point2 :" + point2.toString() + " (avant)");
console.log("point1 :" + point1.toString() + " (avant)");
point2.rabbit(point1);
console.log("point2 :" + point2.toString() + " (aprés)");
console.log("point3 :" + point3.toString() + " (aprés)");