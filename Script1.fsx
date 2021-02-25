open System

module IntegersAndNumbers =
    let mutable exemple = 79
    exemple <- exemple + 1
    Console.WriteLine("An integer: {0}", exemple)

    /// A very simple constant integer 
    let i1 = 1
    let i2 = 2
    let i3 = i1 + i2
    let f x = 2*x*x-5*x+3
    let result= f (i3 + 4)

/// Compute the factorial of an integer recursively
    let rec factorial x = 
            if x <= 1 then
                1
            else
                x * factorial(x - 1);    
    
    
    //Add to the beggining of the list
    let listC= 1 :: [2; 3]
    //Add to the end of the list
    let newList = listC @ [4]

    let sumone (x:int) = x + 1
    Console.WriteLine("The sum is: {0}", sumone(2))

    let lis = [for a in 1 .. 5 do match a with 
            | 3 -> yield! ["p"; "c"; "l"]
            | _ -> yield a.ToString()]

    Console.WriteLine("AAAA")

    List.tail lis

    //Example of pipes with array and filter
    //List.filter (fun x -> x % 2 = 0) [1..10]
    [1..10] |> List.filter (fun n -> n%2 = 0)
    ;;