var app = angular.module('app', ['ui.grid', 'ui.grid.edit', 'ui.grid.rowEdit', 'ui.grid.cellNav', 'blockUI', 'ngCookies']);

var Objectos;

app.controller("MapsApi", ['$scope', '$http', 'uiGridConstants', 'blockUI', '$parse', '$cookies', '$cookieStore', '$timeout',
function ($scope, $http, uiGridConstants, blockUI, parse, $cookies, $cookieStore, $timeout) {

    Objectos = $scope;


    $scope.CadastroLatLng = function () {

        var path = window.location.origin;
             
             $http.get(path + '/api/webapi/IndexApi/GET_PLOTARPONTOS').then(function (data)
             {
                 var pontos = data.data;

                 var latlngbounds = new google.maps.LatLngBounds();

                 var markers = []

                 angular.forEach(pontos, function (dados)
                 {                    

                     //var location = new google.maps.LatLng(dados.Latitude, dados.Longitude);
                     //marker.setPosition(location);

                     var marker = new google.maps.Marker(
                     {
                         position: new google.maps.LatLng(dados.Latitude, dados.Longitude),
                         title: dados.Endereco + dados.DataCriacao,
                         map: map
                     });


                     latlngbounds.extend(marker.position);
                     markers.push(marker);
                    
                 });

                 var markerCluster = new MarkerClusterer(map, markers);

                 map.fitBounds(latlngbounds);     
                 //map.setCenter(location);
                // map.setZoom(16);

             });

         }
            
    $scope.CadastroLatLng();

}]);