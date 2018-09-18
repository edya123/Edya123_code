// function buttonClick() {
//     alert('button was clicked')
// }

function buttonClick() {
    var element = document
    // .getElementById('some-paragraph')
    .querySelector('#some-paragraph')
// console.log(element.innerHTML);
// console.log(element.innerText);
    if(element.innerText == 'foo') {
        element.innerText = 'bar';
    } else {
        element.innerText = 'foo';
    }
}
// setTimeout(buttonClick, 2000);
// setInterval(buttonClick, 500);

// console.log(document.querySelector('.other-paragraph'));
// console.log(document.querySelectorAll('.other-paragraph'));
// function checkParagraphContent() {
//     alert(1);
//     var elements = document.querySelectorAll('.other-paragraph');
//     // console.log(elements);
//     for (var i = 0; i < elements.length; i++) {
//         var element = elements[i];
//         console.log(element);
//     } 
// }

function checkParagraphContent() {
    alert(1);
    var elements = document.querySelectorAll('.other-paragraph');
    // console.log(elements);
    for (var i = 0; i < elements.length; i++) {
        var element = elements[i];
        console.log(element);
        var number = i + 1;
        if(element.innerText == 'foo' + number) {
           element.innerText = 'bar' + number;
        } else {
            element.innerText = 'foo' + number;
        }
    }
}

function add(number) {
    var element = document
        .getElementById('number');
    var currentValue = parseInt(element.innerText);
    element.innerText = currentValue + number;
}

var count = 0;
function addCount() {
    count++;
    document
        .getElementById('counter')
        .innerText = count;
}

function button1Click() {
    var element = document.getElementById('text');
    if(element.innerText == 'foo') {
        element.innerText = 'bar'
    } else {
        element.innerText = 'foo'
    }
}


function onClick() {
    var element = document
    .querySelector('btn2')
    if(element.innerText == 'foo') {
        element.innerText = 'bar'
    if(element.innerText == 'bar') {
        element.innerText = 'baz'
    if(element.innerText == 'foo') {
        element.innerText = 'baz'
    } else {
        element.innerText = 'baz'
        }
    }
}
}
