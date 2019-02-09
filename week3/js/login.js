function initializeLogin() {

    $('#error').hide();

    $('#submit-btn').click(function(event) {
         if (validateLogin()) {
            alert("Attempting Login");
         }
    });
}

function validateLogin() {
    if($('#username').val.length == 0){
        return false;
    };
    
    if ($('#password').val().length == 0) {
        return false;
    }
    return true;
}

function displayError(error) {
    $('#error').text(error);
    $('#error').show();
}