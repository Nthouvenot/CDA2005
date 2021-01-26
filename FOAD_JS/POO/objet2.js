
function testValeur(_message) {
	_message = "modifié";
}

var test = "non modifié";
testValeur(test);
console.log(test);

function testArray(_tableau) {
	_tableau = "b1";
}

var test2 = ['a1', 'a2'];
testArray(test2);
console.log(test2);

function testArrayItem(_tableau) {
	_tableau[0] = 'b1';
}

testArrayItem(test2);
console.log(test2);

function generateArray(_tableau) {
	let result = [];
	result.push(_tableau[1]);
	return result;
}

var test3 = generateArray(test2);
console.log(test3);
