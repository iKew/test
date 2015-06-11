(function () {
    angular.module('app', []);

    var hub = $.connection.clientNotificationHub;

    $(function () {
        $.connection.hub.logging = true;
        $.connection.hub.start();
    });

    $.connection.hub.error(function (err) {
        console.log('An error occurred: ' + err);
    });

    angular.module('app')
        .value('chat', $.connection.chat);
})();