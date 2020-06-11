/**
  * La classe "Point" représente les coordonnées d'un point dans une zone à 2 dimensions
  */
class Point {

    #x;
    #y;

    /**
     * Constructeur: Initialise une nouvelle instance de la classe "Point"
     * @param int _x Coordonnée horizontale du point (abscisse). Valeur négative acceptée
     * @param int _y Coordonnée verticale du point (ordonnée). Valeur négative acceptée
     */
    constructor(_x, _y) {
        if (typeof _x == 'number' && typeof _y == 'number') {
            this.#x = _x;
            this.#y = _y;
        } else {
            this.#x = 0;
            this.#y = 0;
        }
    }

    /**
     * Accesseur de l'attribut x
     * @returns {integer} retourne la coordonne x du point
     * */
    getX() {
        return this.#x;
    }

    /**
     * Mutateur de l'attribut x
     * @param {integer} _x set la coordonne x du point
     */
    setX(_x) {
        if(typeof _x != 'integer') {
            return false;
        }
        this.#x = _x
    }
/**
 * Accesseur de l'attribut y
 * @returns {integer} retourne la coordonne y du point
 * */
    getY() {
        return this.#y;
    }

    /**
     * Mutateur de l'attribut y
     * @param {integer} _y set la coordonne y du point
     */
    setY(_y) {
        if (typeof _y != 'integer') {
            return false;
        }
        this.#y = _y;
    }

    /**
     * Retourne une représentation textuelle du Point
     * @return {string} Les coordonnées du Point
     */
    toString() {
        return "(" + this.#x + "," + this.#y + ")";
    }

    /**
     * Duplique le Point actuel dans une nouvelle instance
     * @returns {Point} La nouvelle instance de Point créée
     */
    duplicate() {
        return new Point(this.#x, this.#y);
    }

    /**
     * définit de nouvelles coordonnées (x=abscisses, y=ordonnées)
     * @param {integer} _x
     * @param {integer} _y
     * @returns {boolean} retourne true si les type passé en argument sont des entier
     */
    move(_x, _y) {
        if (!(typeof _x == 'number' && typeof _y == 'number')) {
            return false;  
        }
        this.#x = _x;
        this.#y = _y;
        return true;
    }

    /**
     * copie les coordonnées du "Point" fourni en argument dans l'instance actuelle
     * @param {Point} _point
     * @returns {boolean} retourne true si le type passé en argument est un Point
     */
    copy(_point) {
        if (!(_point instanceof 'Point')) {
            return false;
        }
        this.#x = _point.x;
        this.#y = _point.y;
        return true;
    }

    /**
     * Les coordonnées de l'instance actuelle et du "Point" fourni en argument sont échangées
     * @param {Point} _point
     * @returns {boolean} retourne true si le type passé en argument est un Point
     */
    rabbit(_point) {
        if (!(_point instanceof 'Point')) {
            return false;  
        }
        let tempo = this.duplicate();
        this.copy(_point);
        _point.copy(tempo);
        return true;
    }

}

module.exports = Point;