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

function highlight() {

    // Get the button element
    const button = document.querySelector('.buton');
    const h6 = document.querySelector(".pay");

    // Add a mouseover event listener
    button.addEventListener('mouseover', () => {
        // Change the button's background color
        h6.style.color = '#2a2f43';
        h6.style.transition = "1s";
    });
}

function highout() {

    // Get the button element
    const button = document.querySelector('.buton');
    const h6 = document.querySelector(".pay");

    // Add a mouseout event listener
    button.addEventListener('mouseout', () => {
        // Change the button's background color back to its original color
        h6.style.color = '#f5f5f5';
    });
}