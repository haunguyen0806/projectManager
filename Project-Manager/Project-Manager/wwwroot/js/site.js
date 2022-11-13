// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $("#btnDelete").click(function () {
        var _id = $("#personID").val();

        $.ajax({
            type: "POST",
            url: "/Admin/Person/DeletePersonModal",
            data: { id: _id },
            success: function (result) {
                if (result) {
                    $("deleteModal").modal("hide");
                    $("personId").val(null);
                    window.location.href = "/Admin/Person";
                }
                else {
                    console.log("");
                }
            }
        })
    });
});

var Confirm = function (id) {
    $("#personID").val(id);
    $("#deleteModal").modal("show");
}