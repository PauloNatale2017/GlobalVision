var app = angular.module('app', ['ui.grid', 'ui.grid.edit', 'ui.grid.rowEdit', 'ui.grid.cellNav', 'blockUI', 'ngCookies']);

var Objectos;

app.controller("IndexApi", ['$scope', '$http', 'uiGridConstants', 'blockUI', '$parse', '$cookies', '$cookieStore', '$timeout',
function ($scope, $http, uiGridConstants, blockUI, parse, $cookies, $cookieStore, $timeout)
{

    Objectos = $scope;
    
    $scope.Estado = ["SP"];

    $scope.Cidade = ["ATIBAIA", "MAIRIPORAN", "JUNIAI", "CAMPINAS"];

    //blockUIConfig.requestFilter = function (config)
    //{
    //    var message;
    //    switch (config.method)
    //    {
    //        case 'GET':
    //            message = 'Getting ...';
    //            break;

    //        case 'POST':
    //            message = 'Posting ...';
    //            break;

    //        case 'DELETE':
    //            message = 'Deleting ...';
    //            break;

    //        case 'PUT':
    //            message = 'Putting ...';
    //            break;
    //    }        
    //    return message;
    //};
    
    $scope.Cadastro = function()
    {
        var path = window.location.origin;       

        blockUI.start();

        $http.post(path + '/api/webapi/IndexApi/post', $scope.CadastroEndereco).then(function (data)
        {
            blockUI.stop();
        });
    }

    $scope.CadastroLatLng = function ()
    {
        var path = window.location.origin;

        var endereco = $scope.CadastroEndereco.Endereco;

        $scope.CadastroLatLng.Endereco = endereco;

        blockUI.start("CADASTRANDO DADOS DE LONGITUDE E LATITUDE");

        geocoder.geocode({ 'address': endereco + ', Brasil', 'region': 'BR' },
        function (results, status)
        {
            if (status == google.maps.GeocoderStatus.OK)
            {

                if (results[0])
                {

                    var data = {'Endereco':results[0].formatted_address,
                                'Longitude':results[0].geometry.location.lng(),
                                'latitude': results[0].geometry.location.lat()
                    }

                    $scope.CadastroLatLng.Endereco = results[0].formatted_address;
                    $scope.CadastroLatLng.Longitude = results[0].geometry.location.lng();
                    $scope.CadastroLatLng.latitude = results[0].geometry.location.lat();
                   
                    var location = new google.maps.LatLng(data.Latitude, data.Longitude);

                    var marker = new google.maps.Marker({
                        position: new google.maps.LatLng(data.Latitude, data.Longitude),
                        title: data.Endereco + data.DataCriacao,
                        map: map
                    });

                    marker.setPosition(location);



                    $http.post(path + '/api/webapi/IndexApi/PostLatLng', data).then(function (data)
                    {
                        blockUI.stop("DADOS CADASTRADOS COM SUCESSO");
                    });

                    //$http.get(path + '/api/webapi/IndexApi/GET_PLOTARPONTOS').then(function (data)
                    //{
                    //    var pontos = data.data;
                        
                    //    angular.forEach(pontos, function (dados)
                    //    {
                    //        //var location = new google.maps.LatLng(dados.Latitude, dados.Longitude);
                    //        //marker.setPosition(location);

                    //        var marker = new google.maps.Marker({
                    //            position: new google.maps.LatLng(dados.Latitude, dados.Longitude),
                    //            title: dados.Endereco + dados.DataCriacao,
                    //            map: map
                    //        });

                    //    });
                       
                    //    map.setCenter(location);
                    //    map.setZoom(16);

                    //});
                     
                       }
                   }
               });

       
    }

}]);