/// <reference path="../angular.intellisense.js" />

//The Module Declaration
var app = angular.module('ngmodule', []);
var apiPath = "/jobsearch/api";
var jobSearch = "/jobsearch";
var account = "/account";
//Declaring Service
app.service('ngservice', function ($http) {
    var apiJobsURI = apiPath + jobSearch + "/jobs/";
    //The function to read all Orders
    this.getOrders = function () {
        var res = $http.get(apiJobsURI);
        return res;
    };
    //The function to read Orders based on filter and its value
    //The function reads all records if value is not entered
    //Else based on the filter and its value, the Orders will be returned
    this.getfilteredData = function (filterValue) {
        var res;
        if (filterValue.length == 0) {
            res = $http.get(apiJobsURI);
            return res;
        } else {
            res = $http.get(apiJobsURI + filterValue);
            return res;
        }

    };
    var registerURI = apiPath + account + "/register/";
    var LoginURI = "/JobSearch/token";
    this.register = function (userInfo) {
        var resp = $http({
            url: registerURI,
            method: "POST",
            data: userInfo,
        });
        return resp;
    };

    this.login = function (userlogin) {
        var data = "grant_type=password&username=" + userlogin.email + "&password=" + userlogin.password;
        var resp = $http({
            url: LoginURI,
            method: "POST",
            data: data,
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
        });
        return resp;
    };
});

//Declaring the Controller
app.controller('ngcontroller', function ($scope, ngservice) {
   
    $scope.filterValue = ""; //The object used to read value entered into textbox for filtering information from table

   
    //Function  to Load all jobs
    function loadOrders() {
        var promise = ngservice.getOrders();
        promise.then(function (resp) {
            $scope.jobs = resp.data;
            $scope.Message = "Call is Completed Successfully";
        }, function (err) {
            $scope.Message = "Call Failed " + err.status;
        });
    };

    //Function to Load jobs based on keyword
    $scope.getFilteredData = function () {
        var promise = ngservice.getfilteredData($scope.filterValue);
        promise.then(function (resp) {
            $scope.jobs = resp.data;
            $scope.Message = "Call is Completed Successfully";
        }, function (err) {
            $scope.Message = "Call Failed " + err.status;
        });
    };

    $scope.register = function (userData)
    {
        
        var userInfo = {
            Email: userData.Email,
            Password: userData.Password,
            ConfirmPassword: userData.ConfirmPassword
        };
        var registerResule = ngservice.register(userInfo)
    }
    $scope.login = function () {

        var userInfo = {
            email: "shiva.koundinya@gmail.com",
            password: "Moukhthi@9",
            grant_type: "password"
        };
        
        ngservice.login(userInfo).success(function (response) {

            var token = response.access_token;
            //if (loginData.useRefreshTokens) {
            //    //localStorageService.set('authorizationData', { token: response.access_token, userName: loginData.userName, refreshToken: response.refresh_token, useRefreshTokens: true });
            //}
            //else {

            //    //localStorageService.set('authorizationData', { token: response.access_token, userName: loginData.userName, refreshToken: "", useRefreshTokens: false });
            //}
            //_authentication.isAuth = true;
            //_authentication.userName = loginData.userName;
            //_authentication.useRefreshTokens = loginData.useRefreshTokens;

            //deferred.resolve(response);

        }).error(function (err, status) {
            //_logOut();
            //deferred.reject(err);
        });

    }
});

app.directive("passwordVerify", function () {
    return {
        require: "ngModel",
        scope: {
            passwordVerify: '='
        },
        link: function (scope, element, attrs, ctrl) {
            scope.$watch(function () {
                var combined;

                if (scope.passwordVerify || ctrl.$viewValue) {
                    combined = scope.passwordVerify + '_' + ctrl.$viewValue;
                }
                return combined;
            }, function (value) {
                if (value) {
                    ctrl.$parsers.unshift(function (viewValue) {
                        var origin = scope.passwordVerify;
                        if (origin !== viewValue) {
                            ctrl.$setValidity("passwordVerify", false);
                            return undefined;
                        } else {
                            ctrl.$setValidity("passwordVerify", true);
                            return viewValue;
                        }
                    });
                }
            });
        }
    };
});