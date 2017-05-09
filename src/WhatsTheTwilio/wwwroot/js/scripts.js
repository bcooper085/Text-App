$(document).ready(function () {
    console.log("HELLO");
    $('.new-contact').submit(function () {
        event.preventDefault();
        console.log($(this).serialize());
        $.ajax({
            url: 'NewContact',
            type: 'POST',
            dataType: 'json',
            data: $(this).serialize(),
            success: function (result) {
                var string = "<h2>This Contact was added!</h2>";
                $(".contact-confirm").html(string)
            }
        })
    })

    $('.contact-list').submit(function () {
        console.log("Its working");
        $.ajax({
            url: 'ContactList',
            type: 'GET',
            data: $(this).serialize(),
            dataType: 'json',
            success: function (result) {
                var stringResult = '<ul>';
                for (var i = 0; i < result.length; i++) {
                    stringResult += '<li>' + result[i].name + ', ' + result[i].number + '</li>';
                }
                stringResult += '</ul>';
                $('#contact-list').html(result);
            }
        })
    })
});