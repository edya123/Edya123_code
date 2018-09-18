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