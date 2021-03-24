module Exercise2

//2.1 a)
let charToUpper c = char ((int c) - 32)
let vowelToUpper c =
    match c with
        | 'a' -> charToUpper c
        | 'e' -> charToUpper c
        | 'i' -> charToUpper c
        | 'o' -> charToUpper c
        | 'u' -> charToUpper c
        |  _  -> c

//2.1 b)

// let string = "Joseph";; string.[0..2] = "Jos"
//let test = "Test".Length

let rec vowelStringToUpper (c:string) =
    match c.Length with
    | 0 -> ""
    | _ -> string (vowelToUpper c.[0]) + vowelStringToUpper c.[1..c.Length - 1]


//2.2 a) Define function that calculates list length

let rec listLength l =
    match l with
    | [] -> 0
    | _  -> 1 + listLength l.Tail

//First approach to find length of a string
let rec listLengthString (l:string):int =
        match Seq.toList l with
        | [] -> 0
        | _  -> 1 + listLengthString l.[1..]

//Improved second approach to find length of a string
let rec listLengthString2 l =
    match l with
    | "" -> 0 //Here l is inferred as a string
    | _  -> 1 + listLengthString2 l.[1..] //Here and in base case return type is infered as int

//2.2 b) Define a function that sums all numbers in a list

let rec listSum l =
    match l with
    | [] -> 0
    | _  -> l.[0] + listSum l.[1..l.Length - 1]
    // This can also be written as | (head::tail) -> head + listSum tail

//2.3 c) Define a function that takes first n items from the list

let takeItems (n:int) (ls: int list) =
    if n - 1 < 0 then
        failwith "Index out of bound"
    else
        ls.[0..n-1]

let takeItems2 n ls =
    if n - 1 < 0 then
        failwith "Index out of bound"
    else 
        match ls with
        | [] -> []
        | _ -> ls.[0..n-1]

//2.4 a) & b)

(*let rec pclFold l =
    match l with
    | [] -> 0
    | (head::tail) -> head + pclFold tail

let pclWithFoldSum l = List.fold (+) 0 l*)

//let rec pclFold f acc lst =
//    match lst with
//    | [] -> 

//2.5 a) & b)
    
