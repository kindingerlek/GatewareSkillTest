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
        url: "https://jsonplaceholder.typicode.com/posts",
        success: function (data) {
            $.each(data, function (i, d) {
                $("#selectBox").append(`<option value = ${d.id}> ${d.title} </option>`);
            })
        }
    });
}   