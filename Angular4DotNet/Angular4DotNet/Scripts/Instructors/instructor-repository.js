registrationModule.factory('instructorRepository', function ($resource) {
    return {
        get: function () {
            return $resource('/Instructors').query();
        }
    }
})