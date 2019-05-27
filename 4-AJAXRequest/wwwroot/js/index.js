/*
 * Author: Lucas Ernesto Kindinger
 * Date: 2016-05-26
 * 
 * Exercice: Using Javascript or Jquery, when clicks in button, populate a selection box by Ajax request to a JSON file.
 */

// Assing callback to each button
$(document).ready(function () {
    $("#btnDoAjax").on("click", function () { LoadData() });
    $("#btnClear").on("click", function () { ClearData() });
})

// Clear selectbox except first element
function ClearData() {
    $('#selectBox').children('option:not(:first)').remove();
}

// Do a Ajax request to a test server and populate selectbox
function LoadData() {
    $.ajax({
        url: "js/json.json",
        success: function (data) {
            alert("oi");
            $.each(data, function (i, d) {
                $("#selectBox").append(`<option value = ${d.id}> ${d.name} </option>`);
            })
        }
    });
}   