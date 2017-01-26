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

    var postJobURI = "/JobSearch.WebAPI/api/jobsearch/PostJob";
    this.postJob = function (postData) {
        var resp = $http({
            url: postJobURI,
            method: "POST",
            data: postData,
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

        //var userInfo = {
        //    email: "shiva.koundinya@gmail.com",
        //    password: "Moukhthi@9",
        //    grant_type: "password"
        //};
        
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
    $scope.availableTags = [
    "ActionScript",
    "AppleScript",
    "Asp",
    "BASIC",
    "C",
    "C++",
    "C#",
    "Clojure",
    "COBOL",
    "ColdFusion",
    "Erlang",
    "Fortran",
    "Groovy",
    "Haskell",
    "Java",
    "JavaScript",
    "Lisp",
    "Perl",
    "PHP",
    "Python",
    "Ruby",
    "Scala",
    "Scheme"
    ];
    function split(val) {
        return val.split(/,\s*/);
    }
    function extractLast(term) {
        return split(term).pop();
    }
    $scope.postJob = function (postData) {

        //var userInfo = {
        //    email: "shiva.koundinya@gmail.com",
        //    password: "Moukhthi@9",
        //    grant_type: "password"
        //};
        //alert(JSON.stringify(postData))
        ngservice.postJob(postData).success(function (response) {

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
    $scope.autoComplete = function (e) {
        $('#'+e.srcElement.id)
        .bind("keydown", function (event) {
            if (event.keyCode === 9 //$.ui.keyCode.TAB 
                    &&
              $(this).autocomplete("instance").menu.active) {
                event.preventDefault();
            }
        })
        .autocomplete({
            minLength: 0,
            source: function (request, response) {
                response($.ui.autocomplete.filter(
                $scope.availableTags, extractLast(request.term)));
            },
            focus: function () {
                return false;
            },
            select: function (event, ui) {
                var terms = split(this.value);
                terms.pop();
                terms.push(ui.item.value);
                terms.push("");
                this.value = terms.join(", ");
                return false;
            }
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

app.controller('jobcontroller', function ($scope, jobservice) {

    $scope.filterValue = ""; //The object used to read value entered into textbox for filtering information from table
    var promise = jobservice.getPostedJobs();
    promise.then(function (resp) {
        $scope.jobs = resp.data;
        $scope.Message = "Call is Completed Successfully";
    }, function (err) {
        $scope.Message = "Call Failed " + err.status;
    });
   
    
});

app.service('jobservice', function ($http) {
    var apiJobsURI = "/JobSearch.WebAPI/api/jobsearch/GetPostedJobs";
    //The function to read all Orders
    this.getPostedJobs = function () {
        var res = $http.get(apiJobsURI);
        return res;
    };
   

    var postJobURI = "/JobSearch.WebAPI/api/jobsearch/PostJob";
    this.postJob = function (postData) {
        var resp = $http({
            url: postJobURI,
            method: "POST",
            data: postData,
        });
        return resp;
    };
});
