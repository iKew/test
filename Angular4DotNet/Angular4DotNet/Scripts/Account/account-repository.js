'use strict';

registrationModule.factory("accountRepository", function ($http) {
    return {
        save: function (student) {
            $http.post('/Account/Save', student);
        }
    };
});