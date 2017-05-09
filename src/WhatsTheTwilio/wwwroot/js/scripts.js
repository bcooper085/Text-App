$(document).ready(function () {
    console.log("HELLO");
    $('.new-contact').submit(function () {
        console.log("Its working");
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
});