(function () {

    var app = angular.module("DatabaseApp", []);

    app.controller("DatabaseController", function ($scope, $http) {

        $scope.message = "Try!";

        var onComplete = function (response) {
            $scope.user = response.data;
        };


        $scope.RetrieveDetails = function (Id)
        {
            $scope.message = "Clicked";
            $http.post("Home/RetrieveData", Id).then(onComplete);
        };



    });


    app.controller("DatabaseController", [$scope, $http, DatabaseController]);


}());