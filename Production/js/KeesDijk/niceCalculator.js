define('niceCalculator', ['lodash'], function (_) {
    var 
        add = function(a, b) {
            return a + b;
        },
        multiply = function(a, b) {
            return a * b;
        },
        sum = function(x) {
            return _.reduce(x, function(i, acc) { return i + acc; }, 0);
        }
    return {
        add: add,
        multiply: multiply,
        sum: sum
    }
    
})