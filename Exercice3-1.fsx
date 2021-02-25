open System

module exec3 = 

    //3.1
   
    let inputText = "Higher-order functions can take and return functions of any order"
    let vowels = ['a';'e';'i';'o';'u']

    //For each value in the list vowels checks if is contained in the list
    let isVowel =
        fun c -> vowels |> List.contains c
    
    let countVowels =
        String.filter isVowel
        >> String.length
    
    let contains n arr =
        List.contains n arr 
    
    isVowel 'a'
    contains 6 [1..10]

    //3.2
    
    let filt arr = List.filter (fun x -> for i in [x..0] do x % i = 0 ) arr
    filt [1; 2; 3; 4; 5; 6]
    
    //No idea

    //3.4
    let doubleNum x = x*2
    let sqrNum x = x*x
    let pclQuad x= doubleNum x * 2
