namespace FSharpDomain

//Types
type DIJKKEESInterface3() =
    interface IInterface3 with
        member this.Method1(n) = 2 * n
        member this.Method2(n) = n + 100
        member this.Method3(n) = n / 10

type SimpleClass() = 
    member this.X = "F#"

/// The class's constructor takes two arguments: dx and dy, both of type 'float'. 
type Vector2D(dx : float, dy : float) = 
    /// The length of the vector, computed when the object is constructed
    let length = sqrt (dx*dx + dy*dy)

    // 'this' specifies a name for the object's self identifier.
    // In instance methods, it must appear before the member name.
    member this.DX = dx  

    member this.DY = dy

    member this.Length = length

    member this.Scale(k) = Vector2D(k * this.DX, k * this.DY)
