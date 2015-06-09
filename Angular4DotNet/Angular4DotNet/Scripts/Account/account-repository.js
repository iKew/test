'use strict';

registrationModule.factory("accountRepository", function ($http, $q) {
    return {
        save: function (student) {
            var defferred = $q.defer();
            $http.post('/Account/Save', student).success(function () { defferred.resolve(); }).error(function () { defferred.reject(); });
            return defferred.promise;
        }
    };
});