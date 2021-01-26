
const semver = require('semver');
// import semver from 'semver'; Deuxi�me syntaxe (plus r�cente)


console.log("Hello world !");


let version = "2.0.0";

let testVersion = semver.parse(version);

//Permet de v�rifier que la version du module est compatible avec la version actuel
let testVersion2 = [
    semver.satisfies('7.3.99', '~7.3.2'), // true
    semver.satisfies('7.4.0', '~7.3.2'), // false
    semver.satisfies('8.0.0', '~7.3.2'), // false

    semver.satisfies('7.3.99', '^7.3.2'), // true
    semver.satisfies('7.4.0', '^7.3.2'), // true
    semver.satisfies('8.0.0', '^7.3.2'), // false

    semver.satisfies('7.3.99', '>7.2.3'), // true
    semver.satisfies('8.3.99', '>7.0'), // true
    semver.satisfies('7.4.0', '>=7.1'), // true
    semver.satisfies('8.0.0', '>7.2 && <7.7'), // true
];

console.log();