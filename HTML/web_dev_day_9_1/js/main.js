// $('#first-button').click(function(){
// $('p').toggle(1500);
// });

// $('#second-button').click(function(){
// $('#sss').toggle(1500);
// });

$('input').keyup(function(){
    if ($('#other-input').val() == $('#third-input').val()) {
        $('p').html('yay!');
    } else {
        $('p').html('oh no...');
    }
});