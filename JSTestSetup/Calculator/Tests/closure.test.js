define(['closure'],
    function (closure) {
        describe("Test suite closures", function () {
            describe("Calling getCounter 10 times", function() {
                it("should return 9", function () {
                    var result = 0;
                    for (var i = 0; i < 10; i++) {
                        var f = closure.getCounterFunction();
                        result = f();
                    }
                    console.log("result: " + result);
                    expect(result).toEqual(9);
                });
            });
        });
    });

