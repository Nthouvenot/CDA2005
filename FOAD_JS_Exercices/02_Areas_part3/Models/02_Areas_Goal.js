const Point = require('./02_Areas_Point.js');

/**
  * La classe "Goal" repr�sente la position de l'arrive dans une zone � 2 dimensions
  * Ajoute un attribut success et un accesseur a la classe "Point"
  */

class Goal extends Point {

    #success;

    /**
    * Constructeur: Initialise une nouvelle instance de la classe "Path"
    * @param {int} _x Coordonn�e horizontale du point (abscisse). Valeur n�gative accept�e
    * @param {int} _y Coordonn�e verticale du point (ordonn�e). Valeur n�gative accept�e
    **/
    constructor(_x, _y, _succes) {
        super(_x, _y); //On transfert les param�tres _x, _y au constructeur de Point
        if (typeof _succes == 'boolean') {
            this.#success = _succes;
        } else {
            this.#success = false;
		}
    }

    /**
     * Accesseur de l'attribut success
     * @returns {boolean} succes
     * */
    getSuccess() {
        return this.#success;
	}

}

module.exports = Goal;