// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let aData = ("Andrei", "No Specialization")
let drinkData = ("Coffee", ("Karla", "Cappuccino", 1))
let drinkData2 = ("Karla", "Coffee", "Cappuccino", 1)

//Vector operations
let vectorAdd (x1, y1) (x2, y2) = (x1+x2, y1+y2)
let vect1 = (2.5, 3.5)
let vect2 = (2.5, 2.0)
//let tupledAdd(x: float*float, y:float*float) = x + y
let numbersNearValue x = [
    x - 1
    x
    x + 1
]

[<EntryPoint>]
let main argv =
    let myList = numbersNearValue 3
    let newVect = vectorAdd vect1 vect2
    let vowels = "AinisPauBorisaAaAeEeEuUuUiIiI"
    let updatedVowels = Exercise2.vowelStringToUpper vowels
    let list = [1; 2; 3; 4]
    let stringList = ["Ain"; "Test"; "Lol"; "Hello"; "Hey"]
    let ls = Exercise2.listLength list
    let sum = Exercise2.listSum list
    let takenList = Exercise2.takeItems2 2 stringList
    //let reversedList = Exercise2.pclFoldBack list

    printfn ("My new vector: %f %f") (fst newVect) (snd newVect)
    printfn ("My list %A") myList
    printfn ("Exercise 2.1: Updated vowels %s") updatedVowels
    printfn ("Exercise 2.2a: %i 2.2b: %i 2.2c: %A") ls sum takenList
    //printfn ("Exercise 2.3a: %i 2.3b: %i") (Exercise2.pclFold list) (Exercise2.pclWithFoldSum list)
    //printfn ("Ex. 2.4: %A") Exercise2.pclFoldBack list

    //TEST EXERCISES
    let myTuple = (266756, "Ainis", "Lithuania")
    let print3DTuple tupleThree =
        match tupleThree with
        | (a, b, c) -> printfn "ID: %i Name: %s Country: %s" a b c

    print3DTuple myTuple

    let myString = "four"
    let myStringLength = Exercise2.listLengthString2 myString
    printfn "Length of \"%s\" is %i" myString myStringLength

    //NEW TEST EXERCISES
    //Q1
    let triple1 = (8, 29, "AM")
    let triple2 = (11, 50, "AM")
    //Q2
    let isBefore (tpl1: (int * int * string)) (tpl2: int * int * string) =
        match tpl1 with
        | (a, b, c) -> printfn("%i %i %s") a b c
      
    isBefore triple1 triple2

    //Q3
    let rec isNthChar (str: string) n c =
        match str with
        | "" -> false
        | str -> if str.[n] = c then true else isNthChar str.[1..] n c
        //Working method
    let rec newIsNthChar (str: string) n c = if str.[n] = c then true else false
    let nth = "ACTG"
    let isWorking = newIsNthChar nth 2 'C'
    printfn "isWorking %b" isWorking

    //Q4
    let rec removeOdd fltCond (lst: int list) =
        match lst with
        | [] -> []
        | x::xs -> if fltCond x then x:: removeOdd fltCond xs
                    else removeOdd fltCond xs

    let isOdd x = if x % 2 = 0 then false else true
    let testRemoveOdd = removeOdd isOdd [1..10]
    0 // return an integer exit code