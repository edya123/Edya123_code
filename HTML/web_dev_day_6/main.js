// isEven
// true / false

// function isEven(number) {
//     if (number % 2 == 0) {
//         return true;
//     } else {
//     return false;
//     console.log();
//     }
// }
// console.log('number 2 isEven' + isEven(2));
// console.log('number 3 isEven' + isEven(3));
// console.log('number 4 isEven' + isEven(4));
// console.log('number 5 isEven' + isEven(5));
// console.log('number 223452345 isEven' + isEven(2));

// // else var neizmantot, jo return atgriež uz funkcijas sākumu 
// function isEven(number) {
//     if (number % 2 == 0) {
//         return true;
//     } 
//     return false;
//     }

// console.log('number 2 isEven' + isEven(2));
// console.log('number 3 isEven' + isEven(3));
// console.log('number 4 isEven' + isEven(4));
// console.log('number 5 isEven' + isEven(5));
// console.log('number 223452345 isEven' + isEven(2));

// // īsāk
// function isEven(number) {
//         return number % 2 == 0;
//     } 
// console.log('number 2 isEven' + isEven(2));
// console.log('number 3 isEven' + isEven(3));
// console.log('number 4 isEven' + isEven(4));
// console.log('number 5 isEven' + isEven(5));
// console.log('number 223452345 isEven' + isEven(2));

// // īsāk
// function isEven(number) {
//     if (number % 2 == 0) {
//         return 'is even';
//     } else {
//     return 'is odd';
//     }
// }
// console.log('number 2 isEven' + isEven(2));
// console.log('number 3 isEven' + isEven(3));
// console.log('number 4 isEven' + isEven(4));
// console.log('number 5 isEven' + isEven(5));
// console.log('number 223452345 isEven' + isEven(2));

// // izvada tekstu
// function isEven(number) {
//     return number % 2 == 0 ? 'is even' : 'is odd';
// }
// console.log('number 2 isEven' + isEven(2));
// console.log('number 3 isEven' + isEven(3));
// console.log('number 4 isEven' + isEven(4));
// console.log('number 5 isEven' + isEven(5));
// console.log('number 223452345 isEven' + isEven(223452345));



// Ja skaitlis dalās bez atlikuma ar 2 (ir pāra skaitlis), tad izdrukā vārdu "Fizz"
// Ja skaitlis dalās bez atlikuma ar 3, tad izvada "Bazz"
// Ja bez atlikuma dalās ar abiem, tad izvada "Fizz Bazz"
// Ja nedalās bez atlikuma ar nevienu, tad izvada skaitli

// function fizzBuzz(number) {
//     var output = '';
//     if (number % 2 === 0) {
//         output = 'Fizz ';
//     }
//     if (number % 3 === 0) {
//         output += 'buzz';
//     }
//     if (output === '') {
//         output = number;
//     }
//     return output;
// }
// console.log(fizzBuzz(2))

// var isEven2 = function(number){
//     return number % 2 == 0 ? 'is even' : 'is odd';
// }
// console.log('number 2 ' + isEven2(2));
// console.log('number 3 ' + isEven2(3));
// console.log('number 4 ' + isEven2(4));
// console.log('number 5 ' + isEven2(5));
// console.log('number 223452345 ' + isEven2(223452345));


// var - objekts (kaķis)
// viss pārējais - īpašības
var cat = {
    name: 'Muris',
    hunger: 10,
    feed: function(){
        this.hunger--;
    }
}

// console.log(cat);
// cat.hunger += 2;
// cat.feed();
// cat.feed();
// cat.feed();
// cat.feed();
// cat.feed();
// console.log(cat);

console.log(Math.PI);

// new - mainīgs objekts
// rāda laiku, kas ir datorā
var now = new Date();
console.log(now);

var foo = 'bar';
console.log(foo.length);
console.log(foo.split(''))

// 1. jāuztaisa funkcija, kas kā parametru saņem vienu vārdu un atgriež šo vārdu spoguļrakstā.
// 2. uztaisīst funkciju, kas kā parametru saņem tekstu un atgirež true / false, vai šis teksts in palindroms


function reverseWord(word) {
var wordSplitted = word.split('');
console.log(wordSplitted);
var reversedArray = wordSplitted.reverse();
console.log(reversedArray);
var joinedArray = reversedArray.join('');
return joinedArray;
}

function isPolindrom(word) {
    return word == reverseWord(word);
}
// console.log(reverseWord('Jānis'));
// console.log(reverseWord('alus ari ira sula'));

console.log(isPalindrom('Jānis'));
console.log(isPalindrom('eye'));
console.log(isPalindrom('alus ari ira sula'));
console.log(isPalindrom('racecar'));

