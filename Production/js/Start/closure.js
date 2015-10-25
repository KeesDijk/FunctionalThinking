define('closure', function () {
    var counter = 0;
    var getCounterFunction = function () {
            console.log("getCounterFunction from Start");
            return function getCounter() {
                console.log("getCounter from Start");
                return counter++;
            };
        }
    return {
        getCounterFunction: getCounterFunction
    }
})