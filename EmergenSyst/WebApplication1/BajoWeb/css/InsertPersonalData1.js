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
            jsonData = "{'p':" + JSON.stringify(getDtPersonales()) + "}";
            alert(jsonData)
            var serviceInsertar = "/wsEmergenSyst.asmx/InsertPersonalData";
            $.ajax({
                type: "POST",
                url: serviceInsertar,
                data: jsonData,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: true,
                success: function (result) {
                    alert(result.d);
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
});
