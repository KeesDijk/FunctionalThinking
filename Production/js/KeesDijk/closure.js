define('closure', function () {
    var counter = 0;
    var getCounterFunction = function () {
            console.log("getCounterFunction from KeesDijk");
            return function getCounter() {
                console.log("getCounter from KeesDijk");
                return counter++;
            };
        }
    return {
        getCounterFunction: getCounterFunction
    }
})