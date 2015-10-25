define('higherOrderFunctions', function () {
    var
        filter = function (data, func) {
            console.log("filter function from Start, using native filter");
            return data.filter(func) ;
        },
        map = function (data, func) {
            console.log("map function from Start, using native map");
            return data.map(func);
        },
        reduce = function (data, func, seed) {
            console.log("reduce function from Start, using native reduce");
            return data.reduce(func, seed);
        }
    return {
        filter: filter,
        map: map,
        reduce: reduce
    }
})