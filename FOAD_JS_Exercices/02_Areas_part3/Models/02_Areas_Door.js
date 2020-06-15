const Point = require('./02_Areas_Point.js')
const Wall = require('./02_Areas_Wall.js');

/**
  * La classe "Door" représente la position d'une porte dans une zone à 2 dimensions
  * Ajoute les fonctions d'ouverture (et de fermeture) a la classe "Wall"
  */

class Door extends Wall {

	#isOpen;

	/**
	* Constructeur: Initialise une nouvelle instance de la classe "Door"
	* @param {int} _x Coordonnée horizontale du point (abscisse). Valeur négative acceptée
	* @param {int} _y Coordonnée verticale du point (ordonnée). Valeur négative acceptée
    * @param {string} _material matériel du 
    * @param {string} _material matériaux du Door
	*/
	constructor(_x, _y, _material, _isOpen) {
		super(_x, _y, _material) //On transfert les paramétres _x, _y et _material au constructeur de Wall
		if (typeof _isOpen == 'boolean') {
			this.#isOpen = _isOpen;
		} else {
			this.#isOpen = false;
		}
	}

	/**
	 Accesseur de l'attribut isOpen
     * @returns {boolean} isOpen
	 * */
	getIsOpen() {
		return this.#isOpen;
	}

	/**
	 * Inverse l'etat de la porte et  retourne le nouvel etat
	 * @returns {boolean} isOpen
	 * */
	openClose() {
		if (this.#isOpen) {
			this.#isOpen = false;
		} else {
			this.#isOpen = true;
		}
		return this.#isOpen;
    }
}