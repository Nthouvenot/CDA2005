let name = ['agathe', 'berthe', 'chloé', 'cunégonde', 'olga', 'raymonde', 'sidonie'], nameSearch = 'chloé';
let middleName = 0, i = 0, compareResult = 0, lowIndex = 0, hightIndex = 0, position = -1;
hightIndex = name.length;
middleName = Math.floor(name.length / 2);
while (position == -1 && i < name.length - 1) {
    compareResult = nameSearch.localeCompare(name[middleName]);
    if (compareResult < 0) {
        hightIndex = middleName;
        middleName = Math.floor((hightIndex - lowIndex) / 2);
    } else if (compareResult > 0) {
        lowIndex = middleName;
        middleName += Math.floor((hightIndex - lowIndex) / 2);
    } else {
        position = middleName;
    }
    i++;
}
if (position != -1) {
    console.log("Le nom " + nameSearch + " est en position n° " + position);
} else {
    console.log("Le nom n'a pas été trouvé");
}