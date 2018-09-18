// var someNumber = 123; // integer
// var someDecimal = 3.14; // float
// var someWord = 'Hello World'; //string '' "" ``
// var someTrue = true; // true or false - boolean (bool)
// var someNothing = null;  // mainīgais bez vērtības - null (nil)

// var someArray = [
//     'vaz',
//     'zaz',
//     'gaz',
//     'maz',
//     'bmw',
//      1,
//      3.14,
//      true
//     ]; // array (masīvs, tikai objekts)
//     var i = 1;
//     //console.log(i);
  

//     var johnny = {
//         name: 'Johnny',
//         surname: 'Doe',
//         fullName: 'Johnny Doe',
//         age: '21',
//     }; // object (atslēga un vērtība)
//     //console.log(johnny);

    //var i = 1;
    //console.log(i);
    //i = 2;
   // console.log(i);
   // i = 'foo';
   // console.log(i);

//    var i = 'foo';
//    console.log(i);
//    i = 'bar';
//    console.log(i);
//    i = 'baz';
//    console.log(i);
//    i = 1;
//    console.log(i);
//    i = 2;
//    console.log(i);
//    i = 3;
//    console.log(i);

// +
// -
// *
// /
// %
// var number1 = 2;
// var number2 = 4;
// console.log(1 + 1);
// console.log(2 + 2 * 2);
// console.log(number1 + number2);
// console.log(number1 + 3);
// var number3 = number1 - number2;
// console.log(number3);
// console.log((2 + 2) * 2); // 8
// number1 = number1 + 1;
// number1 += 2;
// number1++;
// console.log(number1);
// console.log(1 / 0); // Infinity (bezgalība)

// console.log(5 % 2);

// console.log('foo ' + 'bar');
// console.log(1 + '1');
// console.log('1' + 1); // visu ustver kā tekstu


//  ==  - ir vienāds
//  !=  - nav vienāds
//  >
//  <
//  >=
//  <=
//  ===  - strict comparison (eaqual)
//  !==  - strict comparison (not eaqual)

// if (1 == '1') {
//     console.log('was true');
//     } else {
//         console.log('was not true');
//     }

// var name = 'Kārlis';
// if (name == 'Anna') {
//     console.log('Čau Anna');
// } else if(name == 'Jānis') {
//     console.log('Whatts up Jānis')
// } else {
//     console.log('Nepazīstu tevi');
//     }
//  Anna => Čau Anna, Jānis => Whatts up Jānis, anything else => Nepazīstu tevi

// var a = 1;
// var b = 2;
// var c = 3;

// // && - and
// // || - or (stiprāks par and)

// if (a == 2 && (b == 3 || c == 3)) {

// }

// var name = 'Kārlis';

// Jānis, Kārlis vai Zane -> Čau zināmais cilcēk
// else -> Nepazīstu tevi

// if (
//     name == 'Jānis' 
//     || name == 'Kārlis' 
//     || name == 'Zane'
// ) {
// console.log('Čau zināmais cilvēk')
// } else {
//     console.log('Nepazīstu tevi')
// }

// var name = 'Kārlis';
// switch (name) {
//     case 'Jānis':
//         console.log('Čau zināmais cilvēk')
//         break;
//     case 'Kārlis':
//         console.log('Čau zināmais cilvēk')
//         break;
//     case 'Zane':
//         console.log('Čau zināmais cilvēk')
//         break;
//     default:
//         console.log('nepazīstu tevi')
// }
// switch - var salikt vairākus parametrus

// var i = 0;
// while (i < 10) {
//     console.log(i);
//     i++;
// }
// šādi saskaita līdz 10

// var i = 0;
// while (i < 10) {
//     if (i < 5) {
//         console.log(i);
//     }
// }
// console.log(i);


// izskaitīt 0-20, attēlot katru pāra skaitli

// var i = 0;
// while (i < 20) {
//     if (i % 2 == 0) {
//         console.log(i);
//     }
//     i++;
// }

// skaitīt no 20 līdz 1
// var i3 = 20;
// while (i3 >= 0) {
//     console.log(i3);
//     i3--;
// }
// -- samazina;
// ++ palielina

// skaita no 0 - 20, ierobežo ar 5
// var i = 0;
// while (i < 20) {
//     if (i == 5) {
//         break;
//     }
//     console.log(i);
//     i++;
// }
// console.log(i);

// var i = 0;
// while (i < 20) {
//     i++;
//     if (i == 5) {
//         continue;
//     }
//     console.log(i); 
// }


// nosacījumu pārbauda beigās ar 'do while'
// var i = 20;
// do {
//     console.log(i);
//     i++;
// } while (i < 20);

// skaitīt no - līdz
// for (var i = 0; i < 20; i++) {
//     console.log(i);
// }

// kā izskaitīt no 20 - 0

// for (var i = 20; i >0; i--) {
//     console.log(i);
// }

// var cars = ['vaz', 'gaz', 'zaz', 'maz', 'uaz', 'bmw'];
// for (var index = 0; index < cars.length; index++) {
//     var car = cars[index];
//     console.log(car);
// }
// length - masīva garums

// tikai 'maz'

// var cars = ['vaz', 'gaz', 'zaz', 'maz', 'uaz', 'bmw'];
// for (var index = 3; index < cars.length; index)
// break
// {
//     var car = cars[index];
//     console.log(car);
// }
//  izvadīt vienu elementu
// var cars = ['vaz', 'gaz', 'zaz', 'maz', 'uaz', 'bmw'];
// for (var index = 0; index < cars.length; index++) {
//     var car = cars[index];
//     if (index == 2) {}
//     console.log(car);
// }



// visi, izņemot 'maz'

// var cars = ['vaz', 'gaz', 'zaz', 'maz', 'uaz', 'bmw'];
// var superCar = 'gaz';
// for (var index = 0; index < cars.length; index++) {
//     console.log(car);
//     var car = cars[index];
//     if (index == superCar) {
//     console.log(car);
//     }
// }

// Funkcijas


// function addTwoNumbers(number1, number2) {
//     return number1 + number2;
//     console.log(sum);
//     // ar return atgriež vērtību
// }
// addTwoNumbers(2, 3)
// // console.log(addTwoNumbers(2, 3));


// funkcija paņem 2 parametrus - cilvēka vārdu un vecumu.
// Kārlis, 50
// Čau, Kārli, tev ir 50 gadi!

// function greetPerson(name, age) {
// console.log('Čau ' + name + ' tev ir ' + age + ' gadi!');
// }
// greetPerson('Anna', 20);
// greetPerson('Kārlis', 50);
// greetPerson('Līga', 40);

// Fizz Bazz
// Uzrakstīt programmu, kas izskaita no 0 līdz 30.
// Ja skaitlis dalās bez atlikuma ar 2 (ir pāra skaitlis), tad izdrukā vārdu "Fizz"
// Ja skaitlis dalās bez atlikuma ar 3, tad izvada "Bazz"
// Ja bez atlikuma dalās ar abiem, tad izvada "Fizz Bazz"
// Ja nedalās bez atlikuma ar nevienu, tad izvada skaitli

// for (var i = 0; i<= 30; i++) {
//     if (i % 2 == 0 && i % 3 == 0) {
//         console.log('Fizz Bazz');
//     }else if (i % 3 == 0)  {
//         console.log('Bazz');
//     }else if (i % 2 == 0)  {
//         console.log('Fizz');
//     } else {
//         console.log(i)
//     }
// }


// for (var i = 0; i <= 30; i++) {
//     var output = '';
//     // nodefinē tukšu mainīgo
//     if (i % 2 === 0) {
//         output = 'Fizz ';
//         }
//         if (i % 3 === 0) {
//             output += 'Bazz';
//         }
//         if (output === '') {
//             output = i;
//         }
//         console.log(output);
//     }


