// JavaScript source code

$(document).ready(function () {


    function funk() {

        var lista = [];

        for (var i = 1; i < 6; i++) {
            lista[i] = Array.from(document.getElementsByTagName("h" + i));

            for (var j = 0; j < lista[i].length; j++)
                lista[i][j].append(" [h" + i + "]");
        }
    }
    funk();
});

