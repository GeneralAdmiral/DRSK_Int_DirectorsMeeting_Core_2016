//angular.module('userApp', ['ngRoute'])
//      .config(['$routeProvider', '$locationProvider',
//      function($routeProvider, $locationProvider) {
//          $routeProvider
//            .when('/template', {
//                templateUrl: 'create.html',
//                controller: 'userCtrl',
//            }),
           
//          $locationProvider.html5Mode(true);
//      }])

//    .controller('userCtrl', ['$route', $scope, '$routeParams', '$location',
//      function ($route, $routeParams, $location) {
//          this.$route = $route;
//          this.$location = $location;
//          this.$routeParams = $routeParams;
//      }])


//------


//var userAppServices = angular.module('userAppServices', ['ngResource']);

//userAppServices.factory('User', ['$resource',
//  function ($resource) {
//      return $resource('api/UsersApi', {}, {
//          query: { method: 'GET', isArray: true }
//      });
//  }]);


//angular.module('userApp', ['ngRoute'])
//    .controller('userCtrl', ['$route', '$scope', '$routeParams', '$location',
//      function ($scope, User) {
//          $scope.users = User.query();
//          $scope.getApi = function () {
//              $scope.users = User.query();
//          }
//      }]);


//-------

var phonecatApp = angular.module('userApp', []);

phonecatApp.controller('userCtrl', function ($scope, $http) {
    $http.get('api/UsersApi').success(function (data) {
        $scope.users = data;
    });

    $scope.getApi = function () {
        $scope.users = User.query();
    }
});