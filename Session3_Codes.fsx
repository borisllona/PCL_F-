// A list of one element = element::[] ===> [1]  ==> 1::[]
// Function calculate the length of a list
let rec pclLength lst =
    match lst with
    | [] -> 0
    | (lstHd::lstTail) -> 1 + pclLength lstTail


let rec sumList lst =
    match lst with
    | [] -> 0
    | (lsthd::lsttail) -> lsthd + sumList lsttail

// Type inference -- at work here
let rec incList ls = 
   match ls with 
       |[]     -> [] 
       | hd::tl ->  hd + 1 :: incList tl

let rec pclMap f = function
    | []  -> []
    | lsthd::lsttail -> f lsthd :: pclMap f lsttail

let incList2 ls = let inc n = n+1 in pclMap inc ls
(*
[1;2;3]
==>> lsthd ==> 1      lsttail [2;3]
inc(1)--> [2]
inc(2) -->  [2;3]
inc(3) -->  [2;3;4]
inc([]) --> result [2;3;4]
*)
(*
> 
val incList : ls:int list -> int list
> 
val pclMap : f:('a -> 'b) -> _arg1:'a list -> 'b list
> 
val pclMap : f:('a -> 'b) -> _arg1:'a list -> 'b list
> 
val incList2 : ls:int list -> int list
> incList2 [0;1;2;3;4];;
val it : int list = [1; 2; 3; 4; 5]
> 
*)

let negate n = -n
//pclMap negate [1..10]
// val it : int list = [-1; -2; -3; -4; -5; -6; -7; -8; -9; -10]

// pclFilter : ('a -> bool) -> 'a list -> 'a list
let rec pclFilter predicate lst =
    match lst with
    | [] -> []
    | x::xs -> if predicate x then x:: pclFilter predicate xs
                else pclFilter predicate xs

let isEven n = if n%2 = 0 then true else false

pclFilter isEven [0;1;2;3;4;5]

// fold and variants
// *****************
// sum of all numbers [1;2;3]
let rec pclFold f init lst =
    match lst with
    | []   -> init
    | x::xs -> pclFold f (f init x) xs
 
//pclFold (fun x y -> x+y) 0 [1;2;3]
//val pclFold : f:('a -> 'b -> 'a) -> init:'a -> lst:'b list -> 'a
// val it : int = 6

(*
let add n1 n2 = n1 + n2
pclFold add 0 [1;2;3]
(add 0 1) [2;3]
pclFold add 1 [2;3]
*)

let closureFun = 
   let multi x y = x * y
   let triple = multi 3 // partial application of multi
   // triple is a closure that takes one arg
   printfn "%d" (triple 5) 