// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Se crea función de retorno a url base
function Redirect(){

    return window.location.href = "http://localhost:5002/"
}

// Se llama al elemento onclick para el caso el boton que realizará la acción de retornar a la url base
document.getElementById("backBtn").onclick = function(){
    Redirect();
}