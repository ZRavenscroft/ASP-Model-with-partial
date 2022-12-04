
$(document).on("click", ".book-modal-btn", function (e) {
    e.preventDefault()

    let url = $(this).attr("href");

    fetch(url)
        //.then(response => response.json())
        .then(response => response.text())
        .then(data => {
            //$(".modal-content .product-title").text(data.name)
            $("#quickModal .modal-dialog").html(data)
        })

    $("#quickModal").modal("show")
})