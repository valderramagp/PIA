$(document).ready(function () {
    $(".property-th").on("click", function () {
        let $idPublicacion = $(this).data("idPublicacion");
        window.location.href = "/Home/Detalle/" + $idPublicacion;
    })
});