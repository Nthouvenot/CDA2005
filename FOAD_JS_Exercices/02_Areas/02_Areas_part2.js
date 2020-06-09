/**
 * JAVASCRIPT:  Exercices
 * 
 * Coordonnées dans un espace à 2 dimensions type "fenêtre"
 * 
 * 
 * CONSIGNES : 
 * 1) Lisez la description de la classe "Area"
 * 2) Implémentez le code nécessaire à son bon fonctionnement en suivant les indications dans sa description
 * 3) Implémentez ensuite le programme suivant :
 *      a) Créer 2 "Area"
 *      b) Dans la 1ère "Area", ajouter 8 "Point"" (coordonnées au choix, 5 dans les limites de la zone et 3 hors limites)
 *      c) Dans la 2nde "Area", ajouter 6 "Point"" (coordonnées au choix, 4 dans les limites de la zone et 2 hors limites)
 *      d) Créer 2 "Point" distincts ayant les mêmes coordonnées
 *      e) Les ajouter dans chacune des zones (1 "Point" par zone)
 *      f) Pour chaque zone : 
 *          - Afficher tous les points qui se trouvent hors des limites de la zone
 *          - Déplacer ensuite les points hors limite vers le point le plus proche se trouvant dans les limites de la zone :D
 *          - Afficher tous les points en les triant les 
 * 
 */


/**
 * La classe "Area" représente une zone à 2 dimensions type "fenêtre".
 * La zone est définie par une largeur et une hauteur (width, height)
 * La zone peut accueillir des instances de la classe "Point" (dans un tableau ou autre)
 * On peut donc ajouter et supprimer des "Point" se trouvant dans la zone.
 * Particularités :
 * - Le "Point" d'origine de la zone (0,0) est situé au coin supérieur gauche de la zone
 * - Le "Point" d'origine existe toujours (créé dans le constructeur) et ne peut être supprimé
 * - A partir du "Point" d'origine, la zone s'étend vers la droite pour les abscisses et vers le bas pour les ordonnées
 * - 1 seul "Point" autorisé par coordonnée
 * - Les "Point" ajoutés peuvent se situer en dehors des limites de la zone
 * - Les "Point" situés sur la limite de la zone sont considérés "dans les limites de la zone" 
 * Aidez-vous des images "02_Points_***" présentes dans ce dossier pour vous faire une réprésentation
 */

const Point = require('./02_Areas_Point.js');

class Area {
    /**
     * Constructeur: Initialise une nouvelle instance de la classe "Area"
     * La largeur et la hauteur définissent les limites de la zone. 
     * @param int _width largeur de la zone
     * @param int _height hauteur de la zone
     */
    constructor(_width, _height) {
        // A vous de jouer
        if ((typeof _width == 'number') && (typeof _height == 'number')) {
            this.areaWidth = parseInt(_width);
            this.areaHeight = parseInt(_height);
            this.numberAreaCase = this.areaWidth * this.areaHeight;
            this.pointArea = [];
            this.pointArea.push(new Point(0, 0));
        }
    }


/**
 * méthode interne a la classe Area
 * trie la collection de Point avec x et y
 * */
    areaSort() {
        let sortBy = [{ prop: 'y', direction: 1 }, { prop: 'x', direction: 1 }];
        this.pointArea.sort((a, b) => {
            let i = 0, result = 0;
            while (i < sortBy.length && result === 0) {
                result = sortBy[i].direction * (a[sortBy[i].prop].toString() < b[sortBy[i].prop].toString() ? -1 : (a[sortBy[i].prop].toString() > b[sortBy[i].prop].toString() ? 1 : 0));
                i++;
            }
            return result;
        })
    }

    /**
     * Ajoute un "Point" dans la zone
     * Le "Point" peut se trouver hors des limites de la zone
     * @param Point _point 
     * @returns Boolean true en cas de succès, false si l'ajout est impossible 
     */
    addPoint(_point) {
        if (!(_point instanceof Point)) {
            return false;
        }
        if (this.pointArea.length + 1 > this.numberAreaCase) { // Si la zone est pleine on ajoute pas le point
            return false;
        }
        this.pointArea.push(new Point(_point.x, _point.y));
        this.areaSort(); //On trie le tableau aprés l'ajout d'un nouveau point
        return true;
    }

    /**
     * Vérifie la position de chaque "Point" enregistré
     * Chaque Point hors des limites est automatiquement déplacé vers une position "dans la zone"
     * Ce déplacement utilise les mêmes règles que l'ajout d'un "Point"
     */
    needAllInside(i) {
        if (i == undefined) { //Si on a pas de paramétre a la premiére execution de la récursive on initialise i a 0
            i = 0;
        }
        if (i == this.pointArea.length) {
            return true;
        }
        if (this.pointArea[i].x > this.areaWidth || this.pointArea[i].x < 0) {
            let i1 = 0;
            while (this.pointArea[i1].x + 1 > this.pointArea[i].x) {
                i1++;
            }
            this.pointArea[i].x = this.pointArea[i1].x += 1;
            this.areaSort();
            i = 0; //On repart du début pour vérifier qu'il n' a plus de point en dehors aprés le tri
        }
        if (this.pointArea[i].y > this.areaHeight || this.pointArea[i].y < 0) {
            //To do le point est mis dans la plus proche casse de libre
            
        }
        return this.needAllInside(i += 1);
    }

    getPointArea() {
        return Object.assign(this.pointArea);
    }
}

module.exports = Area;