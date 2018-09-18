// function button1Click() {
//     var element = document.getElementById('text');
//     if(element.innerText == 'foo') {
//         element.innerText = 'bar'
//     } else {
//         element.innerText = 'foo'
//     }
// }

function add(number) {
    element = document
    .getElementById('input');
    var currentValue = parseInt(element.value);
   element.value = currentValue + number;
}

function goodButton() {
    var element = document
    .querySelector('#crazyButton');
    if(element.innerText == 'foo') {
        element.innerText = 'bar';
    } else if (element.innerText == 'bar') {
        element.innerText = 'baz';
    } else
        element.innerText = 'foo';
    }

function niceButton() {
   var elements = document.querySelectorAll('.some-paragraph');
    for (var i = 0; i < elements.length; i ++) {
       var element = elements[i];
       console.log(element);
       var number = i + 1;
if(element.innerHTML == 'Foo' + number) {
    element.innerHTML = 'Bar' + number;
    } else
    element.innerHTML = 'Foo' + number;
    }
}
 

