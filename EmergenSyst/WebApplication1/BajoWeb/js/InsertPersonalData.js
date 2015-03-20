var acciones = (function () {
    "use strict";
    var jsonData;
    var persona = {};
    var _addHandlers = function () {
        $('#btnGuardar').on('click', function () { guardarNuevo(); });
    };

    var guardarNuevo = function () {
        var band = valForm();
        if (band) {
            jsonData = JSON.stringify(getDtPersonales());
            alert(jsonData);
            var url = "http://localhost:8020/api/PersonalData";
            $.ajax({
                type: "POST",
                url: url,
                data: jsonData,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: false,
                success: function (result) {
                    alert(result);
                },
                error: function (jqXHR, status, error) {
                    alert("Ajax" + error + "-" + jqXHR.responseText);
                }
            });
        }
    };

    var valForm = function () {
        if ($('#txtCed').val() !== "" && $('#txtNomb').val() !== "" && $('#txtApell').val() !== "" && $('#dttFecha').val() !== "" && $('#cbxSexo').val() !== "") {
            return true;
        } else { return false; }
    };

    var getDtPersonales = function () {
        persona.cedula = $('#txtCed').val();
        persona.nombres = $('#txtNomb').val();
        persona.apellidos = $('#txtApell').val();
        persona.fNacimiento = $('#dttFecha').val();
        persona.sexo = $('#cbxSexo').val();
        return persona;
    };

    return {
        init: function () {
            _addHandlers();
        },
        getRecord: function () {
            return dataRecord;
        }
    }
}());


$(document).ready(function () {
	acciones.init();
    //var url = "http://localhost:8020/api/PersonalData";
    //        $.ajax({
    //            type: "GET",
    //            url: url,
    //            contentType: "application/json; charset=utf-8",
    //            dataType: "json",
    //            async: true,
    //            success: function (result) {
    //                alert(result);
    //            },
    //            error: function (jqXHR, status, error) {
    //                alert("Ajax" + error + "-" + jqXHR.responseText+status);
    //            }
    //        });
});
