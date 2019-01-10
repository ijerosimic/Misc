// JavaScript source code

var slika, indexTrenutneSlike, indexZadnjeSlike;

indexZadnjeSlike = 4;

window.onload = function () {
    indexTrenutneSlike = 1;

    strelicaLijevo = document
        .getElementById("strelicaLijevo")
        .addEventListener("click", PromijeniKlikomUlijevo)

    strelicaDesno = document
        .getElementById("strelicaDesno")
        .addEventListener("click", PromijeniKlikomUdesno)

    izbornik = document
        .getElementById("izbornik")
        .addEventListener("change", PromijeniPutemIzbornika)

    tipkovnica = document
        .addEventListener("keydown", PromijeniPutemTipkovnice)
}

function PromijeniKlikomUlijevo() {

    if (indexTrenutneSlike <= 1)
        indexTrenutneSlike = indexZadnjeSlike
    else if (indexTrenutneSlike > 1)
        indexTrenutneSlike--;

    slika = document
        .getElementById("slika")
        .setAttribute("src", "img/cvijece" + indexTrenutneSlike + ".jpg");
}

function PromijeniKlikomUdesno() {

    if (indexTrenutneSlike == indexZadnjeSlike)
        indexTrenutneSlike = 1;
    else indexTrenutneSlike++;

    slika = document
        .getElementById("slika")
        .setAttribute("src", "img/cvijece" + indexTrenutneSlike + ".jpg");
}

function PromijeniPutemIzbornika() {

    indexIzabraneSlike = document
        .getElementById("izbornik")
        .value

    if (isNaN(indexIzabraneSlike))
        indexIzabraneSlike = indexZadnjeSlike;

    slika = document
        .getElementById("slika")
        .setAttribute("src", "img/cvijece" + indexIzabraneSlike + ".jpg");

    indexTrenutneSlike = parseInt(indexIzabraneSlike);
}


function PromijeniPutemTipkovnice(pritisakGumba) {

    switch (pritisakGumba.key) {

        case "ArrowLeft":
            PromijeniKlikomUlijevo();
            break;

        case "ArrowRight":
            PromijeniKlikomUdesno();
            break;
    }
}
