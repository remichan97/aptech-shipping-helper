// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var check = function () {
    if (document.getElementById('new').value ==
        document.getElementById('verify').value) {
        document.getElementById('error').innerHTML = '';
        return true;

    } else {
        document.getElementById('error').style.color = 'red';
        document.getElementById('error').innerHTML = 'Password does not match';
        return false;
    }
}