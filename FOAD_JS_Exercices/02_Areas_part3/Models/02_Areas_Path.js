const Point = require('./02_Areas_Point.js');


class Path extends Point {

    #player;
    #nbPassages;

    /**
  * Constructeur: Initialise une nouvelle instance de la classe "Path"
  * @param {int} _x Coordonn�e horizontale du point (abscisse). Valeur n�gative accept�e
  * @param {int} _y Coordonn�e verticale du point (ordonn�e). Valeur n�gative accept�e
  * @param {string} _material mat�riaux du Wall
  */
    constructor(_x, _y, _player, _nbPassages) {
        super(_x, _y); //on transfert les param�tres _x et _y au constructeur de Point
        if (typeof _player == 'boolean') {
            this.#player = _player;
        } else {
        this.#player = false;
        }
        if (typeof _nbPassages == 'integer') {
            this.#nbPassages = _nbPassages;
        } else {
            this.#nbPassages = 0;
        }
    }

    /**
     * Accesseur de l'attribut player
     * @returns {boolean} player
     * */
    getPlayer() {
        return this.#player;
    }

    /**
     * Mutateur de l'attribut player
     * @param {boolean} _player
    * @returns {boolean} player si succes undefined si echec
         * */
    setPlayer(_player) {
        if (typeof _player != 'boolean') {
            return undefined;
        }
        this.#player = _player;
        return this.#player;
    }

    /**
     * Accesseur de l'attribut nbPassages
     * @returns {int} nbPassages
     * */
    getNbPassages() {
        return this.#nbPassages;
    }

    /**
    * Mutateur de l'attribut nbPassages
    * @param {int} _nbPassages
    * @returns undefined si echec
    * */
    setNbPassages(_nbPassages) {
        if (typeof _nbPassages != 'integer') {
            return undefined;
        }
        this.#nbPassages = _nbPassages;
    }
}