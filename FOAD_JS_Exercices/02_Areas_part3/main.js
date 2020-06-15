
const Door = require('./Models/02_Areas_Door.js');
const Goal = require('./Models/02_Areas_Goal.js');
const Path = require('./Models/02_Areas_Path.js');
const Wall = require('./Models/02_Areas_Wall.js');


let door1 = new Door(1, 5, "wood");*/
let goal1 = new Goal(10, 4, false);
let path1 = new Path(3, 5);
let wall1 = new Wall(6, 2, "marble");

//Test des classe hérité de Point
console.log("Type de door1 (Point):");
console.log(door1 instanceof Point);
console.log("Type de wall1 (Wall):");
console.log(door1 instanceof Wall);

console.log();
console.log("Type de goal1 :");
console.log(goal1 instanceof Point);
console.log();
console.log("Type de path1 :");
console.log(path1 instanceof Point);
console.log();
console.log("Type de wall1 :");
console.log(wall1 instanceof Point);
