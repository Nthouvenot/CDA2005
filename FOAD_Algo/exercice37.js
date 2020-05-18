let name = ['agathe', 'berthe', 'chloé', 'cunégonde', 'olga', 'raymonde', 'sidonie']; nameSearch = 'agathe';
let middleName = 0, i = 0, compareResult = 0, lowIndex = 0, hightIndex = 0, position = -1;
hightIndex = name.length;
middleName = Math.ceil(name.length / 2)
console.log(name.length);
while (position == -1 && console.log(i < name.length - 1)) {
    compareResult = nameSearch.localeCompare(name[i]);
    if (compareResult < 0) {
        hightIndex = middleName;
        middleName = Math.ceil((hightIndex - lowIndex) / 2);
    } else if (compareResult > 0) {
        lowIndex = middleName;
        middleName += Math.ceil((hightIndex - lowIndex) / 2)
    } else {
        position = middleName;
    }
    i++;
    console.log(middleName);
}
if (position != -1) {
    console.log("Le nom " + nameSearch + " est en position n° " + position)
} else {
    console.log("Le nom n'a pas été trouvé")
}