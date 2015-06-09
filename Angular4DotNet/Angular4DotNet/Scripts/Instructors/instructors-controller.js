'use strict'

registrationModule.controller("InstructorsController", function ($scope, bootstrappedInstrustors) {
    $scope.instructors = bootstrappedInstrustors.instructors;
});