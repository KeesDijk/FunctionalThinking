namespace FSharpDomain

//interfaces
type IInterface1 =
    abstract member Method1 : int -> int

type IInterface2 =
    abstract member Method2 : int -> int

type IInterface3 =
    inherit IInterface1
    inherit IInterface2
    abstract member Method3 : int -> int
