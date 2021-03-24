// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

//Here we need stackframe to remember to add hd with sumList tl
let rec sumList lst =
    match lst with
    | [] -> 0
    | hd::tl -> hd + sumList tl

//Here we don't use stackframe, since we call next recursion without requiring to do some action later with the previous recursive function
let rec i_am_tail_recursive arg =
    //for completeness (base case)
    printfn("%d") arg
    if arg = 1000 then true
    else i_am_tail_recursive (arg+1)

let rec factorial n = 
    if n <= 1 then 1 //base case
    else n * factorial (n - 1)

let accFactorial x =
    // Keep track of both x and accumulator value (acc)
    let rec tailRecFactorial x acc =
        if x <= 1 then
            acc
        else
            tailRecFactorial (x-1) (acc * x)
    tailRecFactorial x 1

//Here we waste some heap size to save stack space
let sumListTR lst =
    let rec sumListHelper lst total =
        match lst with
        | [] -> total
        | hd::tl -> 
            let totalSum = hd + total
            sumListHelper tl totalSum
    sumListHelper lst 0

// function that prints a list of integers in reverse TWO METHODS:
// Method 1: Accumulator pattern
let getIntReverse lst =
    let rec helper lst reverseLst =
        match lst with
        | [] -> reverseLst
        | hd::tl ->
            let newLst = hd::reverseLst
            helper tl newLst
    helper lst []

// Method 2: Continuation Pattern
let printListReverse lst =
    let rec printListRevTR lst cont =
        match lst with
        // for an empty list, we execute continuation
        | [] -> cont()
        // for other lists, add printing of the current element as part of the continuation
        | hd::tl -> printListRevTR tl (fun() -> printf "%d " hd
                                                cont())
    printListRevTR lst (fun() -> printfn "Done")


// Factorial that uses continuation pattern
let contFactorial x =
    let rec contFactTR x cont =
        if x <= 1 then cont()
        else contFactTR (x - 1) (fun() -> x * cont())
    contFactTR x (fun() -> 1)

let seqOfNumbers = seq { 1..5 }

let comingEvents = [
    ("Event 1", "March 25");
    ("Event 2", "March 26");
    ("Event 3", "March 27");
    ("Event 4", "March 28");
    ("Event 5", "March 29")] |> Map.ofList 






[<EntryPoint>]
let main argv =
    printfn "sumList %i" (sumList [1..10])
    //i_am_tail_recursive 10
    printfn "list sum: %i" (sumListTR [1..10])
    printfn "reverse int: %A" (getIntReverse [10; 9; 8; 7; 6; 5])
    printListReverse [1..10]
    printfn "cont factorial %i " (contFactorial 5)
    //seqOfNumbers |> Seq.iter (printfn "%d")
    printfn "Key Value: %A %s" comingEvents comingEvents.["Event 1"]  
    0 // return an integer exit code