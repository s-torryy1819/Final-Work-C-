$(document).ready(function () {
});
var btnLogin = document.getElementById('do-login');
var idLogin = document.getElementById('login');
var username = document.getElementById('username');
btnLogin.onclick = function () {
    idLogin.innerHTML = '<p>We\'re happy to see you again, </p><h1>' + username.value + '</h1>';
}
function login_with_username() {
    var form = $(this);
    $.ajax({
        type: "POST",
        url: "/login_with_username",
        data: form.serialize(),
        dataType: "json",
        encode: true,
    }).done(function (data) {

    });
}