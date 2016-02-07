(function () {
    'use strict';

    angular
        .module('gridsearch.services')
        .factory('NearbyApi', NearbyApi);

    NearbyApi.$inject = ['$resource'];

    function NearbyApi($resource) {

        var findNearby = function (thoroughfare, postTown, postCode, squareSize) {
            // returns a promise
            var nearbyResource = $resource('http://localhost:58428/api/nearby');

            return nearbyResource.get(
                {
                    thoroughfare: thoroughfare,
                    postTown: postTown,
                    postCode: postCode,
                    size: squareSize
                })
            .$promise;
        }

        return {
            findNearby: findNearby
        }
    }
})();