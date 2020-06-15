const Point = require('./02_Areas_Point.js')

/**
  * La classe "Wall" représente la position d'un mur dans une zone à 2 dimensions
  * Ajoute le matérieaux a la classe "Point"
  */
class Wall extends Point {

    #material;

/**
  * Constructeur: Initialise une nouvelle instance de la classe "Wall"
  * @param {int} _x Coordonnée horizontale du point (abscisse). Valeur négative acceptée
  * @param {int} _y Coordonnée verticale du point (ordonnée). Valeur négative acceptée
  * @param {string} _material matériaux du Wall
  */
    constructor(_x, _y, _material) {
        super(_x, _y); //on transfert les paramétres _x et _y au constructeur de Point
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