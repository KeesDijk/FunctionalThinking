define('higherOrderFunctions', ['lodash'], function (_) {
    var
        filter = function (data, func) {
            console.log("filter function from KeesDijk folder, using lodash filter");
            return _.filter(data, func);
        },
        map = function (data, func) {
            console.log("map function from KeesDijk folder, using lodash map");
            return _.map(data, func);
        },
        reduce = function (data, func, seed) {
            console.log("reduce function from KeesDijk folder, using lodash reduce");
            return _.reduce(data, func, seed);
        }
    return {
        filter: filter,
        map: map,
        reduce: reduce
    }
})