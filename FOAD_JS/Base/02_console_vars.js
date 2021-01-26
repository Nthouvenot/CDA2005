{
    let entier = 1;
    const constante = "hop!";
    var chaine = "hello world";
    {
        entier = 2;
        chaine = "bonjour";
        //constante = "!!!" constante ne peu pas être modifié !!!
        console.log(chaine);
        consolelog(constante);
    }
}


//consolelog(constante); inaccessible !!!
//console.log(entier);
console.log(chaine);

let booleen = true;
let typeBooleen = typeof booleen;
let str = ""
// test du type de variable
if (typeof booleen == "boolean") {

}
else if (typeof booleen == "integer") {

}
else if (typeof booleen == "float") {

}

console.log(typeBooleen);
console.log(booleen);