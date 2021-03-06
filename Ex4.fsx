open System

// Define a function to construct a message to print
let from whom =
   sprintf "from %s" whom

type PclShape =
   | Rectangle of width: float * height: float
   | RightTriangle of width: float * height: float

let rect = Rectangle(width = 5.0, height = 5.0)
let triangle = RightTriangle(width = 2.0, height = 3.0)

let pclArea (s:PclShape):float =
   match s with
   | Rectangle(w, h) -> w * h
   | RightTriangle(w, h) -> (w * h) / 2.0

let pclPerimeter s =
   match s with
   | Rectangle(w, h) -> 2.0*w + 2.0*h
   | RightTriangle(w, h) -> w + h + sqrt (w*w + h*h)

[<EntryPoint>]
let main argv =
   printfn "Rect Area: %f Triangle Area: %f" (pclArea rect) (pclArea triangle)
   printfn "Rect Perimeter: %f Triangle Perimeter: %f" (pclPerimeter rect) (pclPerimeter triangle)
   0 // return an integer exit code