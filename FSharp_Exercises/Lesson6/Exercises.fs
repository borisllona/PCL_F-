module Exercises

type IntegerTree =
    | Tip
    | Node of int * IntegerTree * IntegerTree


//let treeA = IntegerTree.Node(5, IntegerTree.Node(2, IntegerTree.Node(3), 0), IntegerTree.Node(3, IntegerTree.Node(3), 9))
//let tree1 = IntegerTree.Node(5, IntegerTree(2,IntegerTree(3),Tree(4,Tree(3),Tree(5)))

(*let sumIntegerTree tree =
    let rec sumTreeNodes tree sum =
        match tree with
        | 
    sumTreeNodes tree 0*)

// DU type
type IntBinTree =
    | Empty
    | Node of int * IntBinTree * IntBinTree

let rec sumBinTree tree=
    match tree with
    | Empty -> 0
    | Node(value, left, right) -> value + sumBinTree left + sumBinTree right

//First MessageQueue thingie example from the slides!
let printAgent =
    MailboxProcessor.Start(fun inbox ->
        let rec msgLoop() = async {
            let! msg = inbox.Receive()
            printfn "message is: %s" msg
            return! msgLoop()
        }
        msgLoop()
    )