module Exercise1
    let appendToTailMethod1 n list =
        list @ [n]
    let appendToTail n list =
        match list with
        | [] -> []
        |  _ ->  List.rev (n :: (List.rev list))

    let list1 = [2; 3; 5; 7]
    let newList1 = appendToTailMethod1 4 list1