
function somme(a, b) {
    if (b == 0) {
        return a;
    }
    else if (b > 0) {
        return somme(a + 1, b - 1);
    } else if (b < 0) {
        return somme(a - 1, b + 1);
    }  
}

let result = somme(5, 6); //On test la fonction recursive avec a > b
console.log("Le résultat de la somme de 5 et 6 est de " + result);

let result2 = somme(2, 4); //On test la fonction recursive avec a < b
console.log("Le résultat de la somme de 2 et 4 est de " + result2);

let result3 = somme(-4, 16); //On test la fonction recursive avec a négatif
console.log("Le résultat de la somme de -4 et 16 est de " + result3);

let result4 = somme(16, -5); //On test la fonction recursive avec b négatif
console.log("Le résultat de la somme de 16 et -5 est de " + result4);