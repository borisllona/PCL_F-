module Exercise2
//Exercise 2.1
    let x = 23
    let myName = "Bobby"
    let age = 25
    let country = "Canada"
    let y = 6 + 6

    let a = 5
    let b = let a = 10 in a + 5
    let c = a + b
//Exercise 2.2
    let myNumber = 15
    let addNum1 x = x + 1
    let addNum10 x = x + 10
    let addNum20 x =
        x
        |> addNum10
        |> addNum10
//Exercise 2.3
    let max2 x y =
        if x > y then x
        else y
    let evalMax2 = max2 10 5

    let isEvenOrOdd x = if x % 2 = 0 then true else false
    let evenOrOdd x =
        if isEvenOrOdd x = true then "Even Number"
        else "Odd Number"


    let isEven = evenOrOdd 8
    let isOdd = evenOrOdd 7

//Exercise 2.4
    let rec addNum_j j k =
        if k > 0 then
            let i = addNum10 j
            addNum_j i (k-1)
        else j
    let addNumFact = addNum_j 1 10
    