// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let rec pclMap f = function
    | [] -> []
    | lsHd::lsTail -> f lsHd :: pclMap f lsTail

//let incList ls = let inc n = n + 1 in pclMap inc ls

//let negate n = -n

//pclFilter : ('a -> bool) -> 'a list -> 'a list
let rec pclFilter predicate lst =
    match lst with
    | [] -> []
    | x::xs -> if predicate x then x:: pclFilter predicate xs
                else pclFilter predicate xs

let isEven n = if n%2 = 0 then true else false
let a = pclFilter isEven [1..5]

//********fold and variants*********
// sum of all numbers [1;2;3]
let rec pclFold f init lst =
    match lst with
    | [] -> init
    | x::xs -> pclFold f (f init x) xs

let b_sum = pclFold (fun x y -> x + y) 0 [1..3] //Lambda function

let add n1 n2 = n1 + n2
let b_add = pclFold add 0 [1..3] //Same as b_sum

let passFive f = (f 5)
let passFiveSquare = passFive (fun x -> x * x)

//This returns a function if ls2 is not specified
let rec append =
    fun ls1 ->
        (fun ls2 ->
            match ls1 with
            | []->ls2
            | hls1::tls1 -> hls1 :: append tls1 ls2
        )
let newAppendedList = append [2 .. 2 .. 8] [5; 4]


(*
Revised slides again
*)

let squareFun n = n * n 
let myList = [1..2..10]
let sumOfSquares n = [1..n] |> List.map (fun n -> n * n) |> List.sum
let incList ls= let inc n = n+1 in List.map inc ls
let negate lst = List.map (fun x -> -x) lst
let rec filter predicate lst =
    match lst with
    | [] -> []
    | x::xs -> if predicate then x::filter predicate xs
               else filter predicate xs

let myFunc n =
    let firstAction = (fun x -> x * 2) n
    let secondAction = (fun x -> x * 3) n
    firstAction + secondAction

let appendedList = ["Test1"; "Test2"; "Test3"] |> List.map (fun x -> x + "_Subject")
let closureMult lst mult = List.map (fun x -> x * mult) lst
let complexClosure =
    let multi x y = x * y
    let triple = multi 3
    triple 3

[<EntryPoint>]
let main argv =
    printfn "incList: %A pclMap: %A" (incList [1; 2; 3; 4; 5]) (pclMap negate )
    printfn "pclFilter: %A" a
    printfn "pclFold b_sum: %A pclFold b_add: %A" b_sum b_add
    printfn "PassFiveSquare ans: %i" passFiveSquare
    printfn "Appended list: %A" newAppendedList

    sumOfSquares 5 |> printfn "Sum of 5 squared: %i"
    printfn "Initial list: %A\nModified list: %A" myList (incList myList)
    printfn "Negated list: %A" (negate myList)
    printfn "Lambda function testing: %i" (myFunc 5)
    printfn "Currying: %A" appendedList
    printfn "Complex closure: %i" complexClosure
    0 // return an integer exit code