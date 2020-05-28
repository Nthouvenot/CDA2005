/**
 * JAVASCRIPT:  Exercices
 * 
 * Définition d'un "Point"
 * 
 * 
 * CONSIGNES : 
 * 1) Lisez la description et étudiez la classe "Point" ci-dessous (celle-ci est partiellement implémentée)
 * 2) Implémentez les méthodes suivantes:
 *  - move(int x, int y)    : définit de nouvelles coordonnées (x=abscisses, y=ordonnées)
 *  - duplicate()           : retourne une nouvelle instance de "Point" avec les mêmes coordonnées que l'instance actuelle
 *  - copy(Point _point)    : copie les coordonnées du "Point" fourni en argument dans l'instance actuelle
 *  - rabbit(Point _point)  : Les coordonnées de l'instance actuelle et du "Point" fourni en argument sont échangées
 * 
 * RESTRICTIONS :
 *  - Le corps de la méthode "rabbit" ne peut contenir que 3 instructions au maximum et ne doit pas impliquer la création d'autres fonctions !
 * 
 * Le petit programme qui suit la classe doit fonctionner en l'état (non modifié)
 */

 /**
  * La classe "Point" représente les coordonnées d'un point dans une zone à 2 dimensions
  */
class Point 
{
    /**
     * Constructeur: Initialise une nouvelle instance de la classe "Point"
     * @param int _x Coordonnée horizontale du point (abscisse). Valeur négative acceptée
     * @param int _y Coordonnée verticale du point (ordonnée). Valeur négative acceptée
     */
    constructor(_x, _y) {
        if (typeof _x == 'number' && typeof _y == 'number') {
            this.x = _x;
            this.y = _y;
        } else {
            this.x = 0;
            this.y = 0;
        }
    }

    /**
     * Retourne une représentation textuelle du Point
     * @return string Les coordonnées du Point
     */
    toString() {
        return "(" + this.x + "," + this.y + ")";
    }

    /**
     * Duplique le Point actuel dans une nouvelle instance
     * @returns Point La nouvelle instance de Point créée
     */
    duplicate() {
        return new Point(this.x, this.y);
    }

    /**
     * définit de nouvelles coordonnées (x=abscisses, y=ordonnées)
     * @param {integer} _x
     * @param {integer} _y
     */
    move(_x, _y) {
        if (typeof _x == 'number' && typeof _y == 'number') {
            this.x = _x;
            this.y = _y;
            return true;
        } else {
            return false;
        }
    }

   /**
    * copie les coordonnées du "Point" fourni en argument dans l'instance actuelle
    * @param {Point} _point
    */
    copy(_point) {
        if (typeof (_point == 'Point')) {
            this.x = _point.x;
            this.y = _point.y;
            return true;
        } else {
            return false;
        }
    }

    /**
     * Les coordonnées de l'instance actuelle et du "Point" fourni en argument sont échangées
     * @param {Point} _point
     */
    rabbit(_point) {
        if (typeof (_point == 'Point')) {
            let tmpX = _point.x;
            let tmpY = _point.y;
            _point.x = this.x;
            _point.y = this.y;
            this.x = tmpX;
            this.y = tmpY;
            return true;
        } else {
            return false;
        }
    }

}



/**
 * Programme "Point"
 * Décrivez ci-dessous en quelques lignes le programme suivant
 * (utilité, finalité)
 * 
 * Cette classe gére la représentation d'un point dans un espace bidimentionelle
 * 
 * 
 * 
 */

let p1 = new Point(0, 1);
let p2 = new Point(2, 3);
let p3 = new Point(4, 5);
let p4;
let p5;

console.log(p1);     // affiche: Point { x: 0, y: 1 }
console.log(p2);     // affiche: Point { x: 2, y: 3 }
console.log(p3);     // affiche: Point { x: 4, y: 5 }

p4 = p3.duplicate();
console.log(p3 !== p4);         // affiche: true
console.log(p3.toString());     // affiche (4,5)
console.log(p4.toString());     // affiche: (4,5)

p2.copy(p1);
console.log(p1 !== p2);         // affiche: true
console.log(p1.toString());     // affiche:  (0,1)
console.log(p2.toString());     // affiche:  (0,1)

p1.rabbit(p3);
console.log(p1 !== p3);         // affiche: true
console.log(p1.toString());     // affiche:  (4,5)
console.log(p3.toString());     // affiche:  (0,1)

