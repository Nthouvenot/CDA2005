const Point = require('./02_Areas_Point.js')

/**
  * La classe "Wall" repr�sente la position d'un mur dans une zone � 2 dimensions
  * Ajoute le mat�rieaux a la classe "Point"
  */
class Wall extends Point {

    #material;

/**
  * Constructeur: Initialise une nouvelle instance de la classe "Wall"
  * @param {int} _x Coordonn�e horizontale du point (abscisse). Valeur n�gative accept�e
  * @param {int} _y Coordonn�e verticale du point (ordonn�e). Valeur n�gative accept�e
  * @param {string} _material mat�riaux du Wall
  */
    constructor(_x, _y, _material) {
        super(_x, _y); //on transfert les param�tres _x et _y au constructeur de Point
        if (typeof _materiel == 'string') {
            this.#material = _material;
        } else {
            this.#material = "default";
        }
    }

    /**
     * Accesseur de l'attribut material
     * @returns {string} material
     * */
    getMateriel() {
        return this.#material;
    }
}

module.exports = Wall;