define(['niceCalculator'],
    function (niceCalculator) {
        describe("Test suite for the nice calculator", function () {

            describe("Adding two numbers", function() {
                it("should return the sum of them", function() {
                    expect(niceCalculator.add(1, 2)).toEqual(3);
                });
            });
            describe("Multiplying two numbers", function() {
                it("should return the product of them", function() {
                    expect(niceCalculator.multiply(7, 3)).toEqual(21);
                });
            });
            describe("Adding the elements in an array", function () {
                it("should return the sum of them", function () {
                    expect(niceCalculator.sum([1, 2, 3, 4, 5])).toEqual(15);
                });
            });
            describe("Adding the elements in an empty array", function () {
                it("should return zero", function () {
                    expect(niceCalculator.sum([])).toEqual(0);
                });
            });

        });
    });

