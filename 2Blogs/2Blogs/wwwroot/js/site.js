// Write your JavaScript code.
const uri = "api/AdminApi";

$(document).ready(function () {
    getData();
});

function getData() {
    $.ajax({
        type: "GET",
        contentType: "application/json",
        url: uri,
        success: function (roles) {
            const tBody = $("#roletable");

            $(tBody).empty();


            $.each(roles, function (key, item) {
                const tr = $("<tr></tr>")
                    .append($("<td></td>").text(item.name)).append(
                        $("<td></td>").append(
                        $("<button class=\"btn btn-sm btn-danger\" >Delete</button>").on("click", function () {
                                deleteItem(item.id);
                            })
                        )
                    );

                tr.appendTo(tBody);
            });

            roletable = roles;
        }
    });
}

function deleteItem(id) {
    $.ajax({
        url: uri + "/" + id,
        type: "DELETE",
        success: function (result) {
            getData();
        }
    });
}
