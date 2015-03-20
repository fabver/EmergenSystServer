var acciones = (function () {
    //jQuery.ajaxSettings.traditional = true;
    "use strict";
    var jsonData;
    var persona = {};
    var _addHandlers = function () {
        $('#btnGuardar').on('click', function () { guardarNuevo(); });
    };

    var guardarNuevo = function () {
            jsonData = "{'lstDC':" + JSON.stringify(getDtClinicos()) + "}";
            alert(jsonData)
            var serviceInsertar = "/wsEmergenSyst.asmx/InsertClinicalData";
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
    };

    var getDtClinicos = function () {
        var band;
        //var dtClinicos = {};
        var dtClinicos = new Array();
        band = $('#bAlg').val();
        if (band === 'true') {
            var alergias = { cedula: $('#txtCed').val(), descripcion: $('#algs').val(), tipo: 'Alergias' };
            //dtClinicos.alergias = alergias;
            dtClinicos.push(alergias);
        }
        band = $('#bAnt').val();
        if (band === 'true') {
            var antecedentes = { cedula: $('#txtCed').val(), descripcion: $('#ants').val(), tipo: 'Antecedentes'};
            //dtClinicos.antecedentes = antecedentes;
            dtClinicos.push(antecedentes);
        }
        band = $('#bCir').val();
        if (band === 'true') {
            var cirugias = { cedula: $('#txtCed').val(), descripcion: $('#cirs').val(), tipo: 'Cirugias' };
            //dtClinicos.cirugias = cirugias;
            dtClinicos.push(cirugias);
        }
        band = $('#bEnf').val();
        if (band === 'true') {
            var enfermedades = { cedula: $('#txtCed').val(), descripcion: $('#enfs').val(), tipo: 'Enfermedades' };
            //dtClinicos.enfermedades = enfermedades;
            dtClinicos.push(enfermedades);
        }
        band = $('#bMed').val();
        if (band === 'true') {
            var medicamentos = { cedula: $('#txtCed').val(), descripcion: $('#meds').val(), tipo: 'Medicamentos' };
            //dtClinicos.medicamentos = medicamentos;
            dtClinicos.push(medicamentos);
        }

        return dtClinicos;
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
