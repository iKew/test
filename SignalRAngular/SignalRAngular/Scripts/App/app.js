(function () {
    angular.module('app',['toaster']);

    $(function(){
        $.connection.hub.logging = true;
        $.connection.hub.start();
    });

    $.connection.hub.error(function (err) {
        console.log('An error occurre : ' + err);
    });

    angular.module('app').value('chat',$.connection.chat);
})();