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
    
    let primeNums num = [for value in 2..num-1 do if num%value = 0 then yield num]
    let primes num = [for value in 1..num do if primeNums value = [] then yield value]
    primes 50

    //3.4
    let doubleNum x = x*2
    let sqrNum x = x*x
    let pclQuad x= doubleNum x * 2
