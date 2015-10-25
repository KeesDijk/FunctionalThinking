namespace FSharpUnittests

open Xunit

module tests =

    let add x y = x + y 

    [<Fact>]   
    let ``adding 5 to 3 should be 8``() =
        let result = add 5 3
        Assert.Equal(8, result)