(function () {
    'use strict';

    var app = angular
        .module('gridsearch', [
                'ngRoute',
                'gridsearch.controllers',
                'gridsearch.services'
        ]);

    app.config(['$routeProvider',
        function ($routeProvider) {
            $routeProvider
                .when('/', {
                    redirectTo: '/nearby'
                })
                .when('/nearby', {
                    templateUrl: 'search/search.partial.html',
                    controller: 'NearbyController',
                    controllerAs: 'nearbyCtrl'
                })
                .otherwise({
                    redirectTo: '/nearby'
            });
        }]);

    (function () {
        'use strict';
        angular
            .module('gridsearch.controllers', []);
        angular
            .module('gridsearch.services', ['ngResource']);
    })();
})();