
// formule m*n=m+m*(n-1)
function produit(a, b) {
    if (a == 0) {
        return a;
    } else if (b == 0) {
        return false;
    } else if (b == 1) {
        return a;
    } else if (a > b) {
        if (b - 1 == 1) {
            b -= 1;
        }
        return produit(a += a, b -= 1);
    } else if (a < b) {
        return produit(a += a, b -= 1);
    }
}

/*result1 = produit(0, 3); //On teste la division par un numérateur a 0
console.log("Le résultat du produit de 0 et 3 est de " + result1);

result2 = produit(3, 0); //On teste ladivision par 0
console.log("Le résultat du produit de 3 et 0 est de " + result2);*/

result3 = produit(5, 3); //On teste la division classique a > b
console.log("Le résultat du produit de 5 et 3 est de " + result3);
/*
result4 = produit(3, 5); //On teste la division classique b > a
console.log("Le résultat du produit de 5 et 3 est de " + result4);*/