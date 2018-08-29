// document
// .getElementById('some-btn')
// .addEventListener('click', function(){
//     var el = document.getElementById('super-p');
//     if (el.innerText == 'foo') {
//         el.innerText = 'bar';
//     } else {
//         el.innerText = 'foo';
//    }
// });


// jQuery('#some-btn')
// var aizstāt ar $
// $('#some-btn').click(function(){
//    if ($('.super-p').html() == 'foo') {
//        $('.super-p').html('bar');
//    } else {
//        $('.super-p').html('foo');
//    }

// });

// $('#some-btn').hover(function(){
//     if ($('.super-p').html() == 'foo') {
//         $('.super-p').html('bar');
//     } else {
//         $('.super-p').html('foo');
//     }
// });

$('#some-btn').click(function () {
    if ($('.super-p span').html() == 'foo') {
        $('.super-p span').html('bar');
    } else if ($('.super-p span').html() == 'bar') {
        $('.super-p span').html('baz');
    } else {
        $('.super-p span').html('foo');
    }
});

$('#some-other-btn').click(function () {
    // $('.super-p').hide(2000);
    $('.super-p').toggle(2000);
});

$('.add').click(function () {
    var action = $(this).attr('data-action');
    var currentNumber = $('#some-input').val();
    var newValue = parseInt(currentNumber) + parseInt(action);
    $('#some-input').val(newValue);
});
