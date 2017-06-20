$("#submitFormBtn").click(onClickSubmit);

function onClickSubmit() {
    $("#propiedadFrm").submit();
}

function OnSuccessPropiedadFrm(IdPropiedad) {
    $("#PublicacionIdPropiedad").val(IdPropiedad);
    $("#PublicacionIdPropiedad").val(IdPropiedad);
    $("#publicacionFrm").submit();
    $("#ubicacionFrm").submit();
}

function OnSuccessPublicacion(data) {
    
}

function OnSuccessUbicacionFrm(data) {
    
}