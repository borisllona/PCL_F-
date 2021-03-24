// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

let rec factorial4 n =
    match n with
    | 0 | 1 -> 1
    | _ -> if n > 0 then n * (factorial4(n-1))
                    else failwith "Can't put negative numbers!"

[<EntryPoint>]
let main argv =
    printfn "Exercise 1 %A" Exercise1.newList1
    printfn "Exercise 2.1 a: %i b: %i" Exercise2.b Exercise2.c
    printfn "Exercise 2.3 max2: %i isEven: %s isOdd: %s " Exercise2.evalMax2 Exercise2.isEven Exercise2.isOdd
    printfn "Exercise 2.4 addNum_j 3 5 = %i" Exercise2.addNumFact
    printfn $"Exercise1 2.2 addNum1 {Exercise2.addNum20 Exercise2.myNumber}"
    printfn $"Factorial 4 {factorial4 -1}"
     
    0 // return an integer exit code