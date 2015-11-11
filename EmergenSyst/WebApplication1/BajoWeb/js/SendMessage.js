$(document).ready(function () {


    var hub = $.connection.emergencyCallHub;
    $.connection.hub.start().done(function () {
        console.log("Entró");
    }).fail(function (error) {
        console.log('Invocation of start failed. Error: ' + error)
    });


    $('#btnSendMsg').click(function () {
        var data = $('#txtMessage').val();
        var jsonData = JSON.stringify(data);
        hub.server.sendMessage(data);
        //alert(jsonData);
    });

    hub.client.newCall = function (data) {
        $('#messages').append('<p>' + data + '</p>');
    };

});