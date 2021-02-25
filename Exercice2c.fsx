open System

//Functions on lists
module ex2c =

    //Could be refered from another file with open Module

    let numbers = [ 19 ; 52 ; 35 ; 27]

    //Fold applies a function to the values of a list
    numbers
    |> List.fold (fun num acc -> num + acc) 0 //fun param (definition of the function)
    |> printfn "%A"    // 133

    //2nd approach

    let pclFoldBack arr =
       arr |> List.fold (fun num acc -> num + acc) 0

    pclFoldBack numbers 
    
    // function Could be referenced from another file with open File, but have to be in the same project
    let rec pclSum ls =
       match ls with
       | head :: tail -> head + pclSum tail
       | [] -> 0


    let list1 = [ 1; 5; 100; 450; 788 ];
    let deconstruct values=
        for i in list1 do
            printfn "%d" i