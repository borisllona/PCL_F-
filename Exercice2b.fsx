open System

//Functions on lists
module ex2b =
   
   //with head you select the first element and with tail the rest of the list

    let rec pmLength ls = 
        match ls with
        // head::tail means that there are elements in the list
        | head :: tail -> 1 + pmLength tail
        | [] -> 0
    
    pmLength(['x';'y';'z'])

    let rec pclSum ls =
       match ls with
       | head :: tail -> head + pclSum tail
       | [] -> 0

    pclSum([2;3;5;8])

    let rec takeSome n xs =
        match (n,xs) with
             | (0,_) -> []
             | (_,[]) -> failwith "taking too many elements"
             | (_,x::xs) -> x :: takeSome (n-1) xs

    takeSome 1 ['a';'b';'c';'d']