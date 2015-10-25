define(['higherOrderFunctions'],
    function (higherOrderFunctions) {
        describe("Test suite for higher Order Functions", function () {
            describe("Filtering a list", function() {
                it("should return a list of items larger than 10", function() {
                    expect(higherOrderFunctions.filter(
                        [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15],
                        function (n) { return n > 10 }))
                    .toEqual([11, 12, 13, 14, 15]);
                });
            });
            describe("Mapping a list", function() {
                it("should return the a list with the products of the original list", function() {
                    expect(higherOrderFunctions.map(
                        [1, 2, 3, 4, 5],
                        function (n) { return n * 2 }))
                    .toEqual([2, 4, 6, 8, 10]);
                });
            });
            describe("Reducing a list", function () {
                it("should return the total products of all items in the list", function () {
                    expect(higherOrderFunctions.reduce(
                        [1, 2, 3, 4, 5],
                        function (total, n) { return total * n},
                        1))
                    .toEqual(120);
                });
            });
        });
    });

