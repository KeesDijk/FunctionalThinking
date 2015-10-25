namespace FSharpDomain

//Types
type DEFAULTInterface3() =
    interface IInterface3 with
        member this.Method1(n) = 2 * n
        member this.Method2(n) = n + 100
        member this.Method3(n) = n / 10
