(function () {
    'use strict';

    angular
        .module('gridsearch.controllers')
        .controller('NearbyController', NearbyController);

    NearbyController.$inject = ['NearbyApi'];

    function NearbyController(NearbyApi) {

        var nearbyCtrl = this;

        nearbyCtrl.thoroughfare = 'TORPHIN ROAD';
        nearbyCtrl.postTown = 'EDINBURGH';
        nearbyCtrl.postCode = 'EH130HN';
        nearbyCtrl.squareSize = '2000';
        nearbyCtrl.nearbyAddresses = [];
        nearbyCtrl.errorMessage = '';

        nearbyCtrl.findNearby = function () {
            nearbyCtrl.errorMessage = '';

            NearbyApi.findNearby(
                nearbyCtrl.thoroughfare,
                nearbyCtrl.postTown,
                nearbyCtrl.postCode,
                nearbyCtrl.squareSize)
            .then(function (result) {
                nearbyCtrl.nearbyAddresses = result.Addresses;
            }, function (error) {
                nearbyCtrl.errorMessage = error.data.Message;
            });
        };

        nearbyCtrl.hasError = function () {
            return nearbyCtrl.errorMessage.length > 0;
        }
    }
})();