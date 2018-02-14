var app = angular.module("app", ['ngSanitize']);//, 'ngRoute'

String.prototype.replaceAll = function (search, replacement) {

    var target = this;
    return target.replace(new RegExp(search, 'g'), replacement);
};

app.service('UIService', function () {

    this.replaceUrl = function (text) {

        var urlRegex = /(https?:\/\/[^\s]+)/g;
        var urls = urlRegex.exec(text);
        if (urls && urls.length > 0) {

            var url = urls[0];
            text = text.replaceAll(url, "<a href='" + url + "'>" + url + "</a>");
        }
        return text;
    }
});

app.directive('enterClick', function () {

    return function (scope, element, attrs) {
        element.bind("keydown keypress", function (event) {
            
            if (event.which === 13) {
                
                scope.$apply(function () {
                    scope.$eval(attrs.enterClick);
                });
                event.preventDefault();
            }
        });
    };
});

app.directive("scroll", function ($window) {

    return {
        restrict: "A",
        link: function (scope, element, attrs) {
            var visibleHeight = element.height();
            console.log("visibleHeight", visibleHeight);
            console.log("visibleHeight", $window);
            var threshold = 100;

            $window.scroll(function () {

                var scrollableHeight = element.prop('scrollHeight');
                var hiddenContentHeight = scrollableHeight - visibleHeight;
                console.log("SCROLL", scrollableHeight, hiddenContentHeight);
                if (hiddenContentHeight - element.scrollTop() <= threshold) {
                    // Scroll is almost at the bottom. Loading more rows
                    console.log("SCROLL END");
                    //scope.$apply(attrs.whenScrollEnds);
                }
            });
        }
    };
});


/********************Routing****************************/

//$routeProvider
//    .when('/items/computers', {
//        templateUrl: 'items/computers',
//        controller: "ItemListController as itemListCtrl",
//        resolve: {
//            async: ['ItemService', function (ItemService) {
//                return ItemService.fetchAllItems('computers');
//            }]
//        }
//    });

//App.factory('ItemService', ['$http', '$q', function ($http, $q) {

//    return {

//        fetchAllItems: function (category) {
//            return $http.get('<a class="vglnk" href="http://localhost:8080/Spring4MVCAngularJSRoutingExample/item/' + category" rel="nofollow"><span>http</span><span>://</span><span>localhost</span><span>:</span><span>8080</span><span>/</span><span>Spring4MVCAngularJSRoutingExample</span><span>/</span><span>item</span><span>/'+</span><span>category</span></a>)
//                .then(
//                function (response) {
//                    return response.data;
//                },
//                function (errResponse) {
//                    console.error('Error while fetching Items');
//                    return $q.reject(errResponse);
//                }
//                );
//        }
//    };

//}]);

//App.controller('ItemListController', ['async', function (async) {
//    var self = this;
//    self.items = async;
//}]);


/********************************************************/


//app.directive('scrollEnd', function () {

//    return function (scope, elm, attr) {
//        var raw = elm[0];

//        elm.bind('scroll', function () {
//            console.log("scroll down");
//            if (raw.scrollTop + raw.offsetHeight >= raw.scrollHeight) {
//                scope.$apply(attr.onScrollEnd);
//            }
//        });
//    };
//});


app.controller("index", ["$scope", "$http", "$timeout","UIService", function ($scope, $http, $timeout,$ui) {

    $scope.data = [];
    $scope.searchText = "Istanbul";
    $scope.progressDisplay = false;
    $scope.loadMessage = "Load more...";

    $scope.inData = function (arr,value) {

        for (let i = 0; i < arr.length; i++) {
            if (arr[i].IdStr == value) {
                return true;
            }
        }
        return false;
    };

    $scope.copyTweetsArray = function (arr,arrMain) {

        for (let i = 0; i < arrMain.length; i++) {

            if (!$scope.inData(arr, arrMain[i].IdStr)) {

                arr.push(arrMain[i]);
            }
        }
    };

    $scope.replaceUrls = function (arr) {

        for (let i = 0; i < arr.length; i++) {
            arr[i].Text = $ui.replaceUrl(arr[i].Text);
        }
    };

    $scope.getTweets = function (text,cb) {

        $scope.progressDisplay = true;
        $http.post('Home/GetTwittes',
            { searchText: text }
        ).then(function (res) {

                console.log("DATA", res.data);
                var data = res.data;
                if (data.Success) {

                    var result = res.data.Result;
                    var dataToShow = [];
                    //Results available.
                    if (result) {
                        $scope.copyTweetsArray(dataToShow, result.Statuses);
                        $scope.replaceUrls(dataToShow);
                    }
                    //New page existed, Add the data to the list.
                    if (data.NewPage) {
                        data = [];
                        $scope.copyTweetsArray(data, $scope.data);
                        $scope.copyTweetsArray(data, dataToShow);
                        $scope.data = data;
                    }
                    else {//Replace the whole data.
                        $scope.data = dataToShow;
                    }
                }
                else {
                    console.log("Unsuccessful result returned, please refresh the page.");
                }
                $scope.progressDisplay = false;
                if (cb) {
                    cb(res.data);
                }
            },
            function (res) {
                // failure callback
            }
        );
    };

    $scope.onScrollEnd = function (e) {

        console.log("END OF THE SCROLL",e);
    };

    $scope.onSearchChange = function () {

        $scope.getTweets($scope.searchText);
    };

    $scope.loadMore = function () {

        $scope.getTweets($scope.searchText, function (data) {

            if (!data.Result.Success) {
                $scope.loadMessage = "No new tweets available.";
                $timeout(function () {
                        $scope.loadMessage = "Load more...";
                }, 3000);
            }
        });
    };

    $timeout(function () {

        $scope.getTweets($scope.searchText);

    });

}]);