(function () {

    var app = angular.module("DatabaseApp", []);

    app.controller("DatabaseController", function ($scope, $http) {

        $scope.message = "Try!";

        var onComplete = function (response) {
            $scope.user = response.data;
        };


        $scope.RetrieveDetails = function (Id, searchCriteria)
        {
            $scope.message = "Clicked";
            $http.get("Home/RetrieveData/" + Id + "?" + searchCriteria).then(onComplete);
        };



    });


    app.controller("DatabaseController", [$scope, $http, DatabaseController]);


}());