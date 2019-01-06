/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module('myModule', []);

myApp.controller("schoolController", schoolController);

myApp.directive("shopDirective", shopDirective);

myApp.service("validatorService", validatorService);

schoolController.$inject = ['$scope', 'validatorService'];

//declare
function schoolController($scope, validatorService) {

    $scope.checkNumber = function() {
        $scope.message = validatorService.checkNumber($scope.num);
    }
      
   
}

//service
function validatorService($window) {
    return {
        checkNumber: checkNumber
    }
    function checkNumber(input) {
        if (input % 2 == 0) {
            return  'this is even';
        }
        else
            return 'this is odd';
    }
}

//new directive
function shopDirective() {
    return {
        restrict: "A",
        templateUrl: "/Scripts/spa/shopDirective.html"
    }
}
