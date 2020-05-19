let collection1 = ['a1', 'a2', 'a3', 'a4']; //déclaration litérale
let collection2 = Array('a1', 'a2', 'a3', 'a4'); //déclaration procédurale
let collection3 = new Array('a1', 'a2', 'a3', 'a4'); //déclaration objet
let collection4 = new Array(10); //déclarer un tableau de longeur 10

/*console.log(collection1);
console.log(collection2);
console.log(collection3);
console.log(collection4);*/

console.log('collection =  ' + collection1);
console.log('collection =  ', collection1); //afiche le tableau au complet

collection1[2] = 'b1';
console.log('collection =  ', collection1);

console.log(collection[02]);

let collection5 = ['a1', 'a2', 'a3', 'a4']; //déclaration litérale
collection5.length = 10; //change dynamiquement la longeur du tableau

//parcourir un tableau
console.log('--- FOR CLASSIQUE');
for (let i = 0; i < collection5.length; i++) {
    console.log(collection5[i]);
}

console.log('--- FOR IN');
for (item in collection5) {
    console.log(collection5[i]);
}

console.log('--- FOR OF')
for (item of collection5) {
    console.log(collection5[i]);
}
