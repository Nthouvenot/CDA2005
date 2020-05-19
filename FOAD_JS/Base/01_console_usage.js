// JavaScript source code

//type des messages
console.log('Hello World');
console.info('information');
console.warn('avertissement');
console.error('erreur');

// groupe et sous groupe
console.group('groupe 1');
console.log('item 1');
console.group('item 2')
console.group('sous groupe 1');
console.log('item 1');
console.log('item 2')
console.groupEnd;
console.groupEnd;