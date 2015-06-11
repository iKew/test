'use strict'

angular.module('app').controller('MainController', function ($scope, $http, chat, toaster) {
    $scope.messages = [];
    $http.get("GetLoginUserID").then(function (response) {
        $scope.LogonUserID = response.data;
    });

    $scope.sendMessage = function onNewMessage() {
        toaster.pop('warning', "please read message!", message);

        $scope.messages.push({ message: message });
        $scope.$apply();

        console.log(message);
    };
});