// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let btns = document.querySelector(".outterContainer").children;

function appearSection() {

    //for (let btn of btns) {
    //    let btnChildLength = btn.childNodes.length;
    //    let partial = btn.childNodes[btnChildLength - 1];
    //    if (partial.style.display == "block") {

    //        partial.style.display = "none";
    //    }
    //    else partial.style.display = "block";
    //}

    for (var i = 0; i < btns.length; i++) {
        let partial = document.querySelector(`Appearing${i}`)
        if (partial.style.display == "block") {

            partial.style.display = "none";
        }
        else partial.style.display = "block";
    }
}