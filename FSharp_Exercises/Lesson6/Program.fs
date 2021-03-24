// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

//let stopWatch = new System.Diagnostics.Stopwatch()
//let ResetStopWatch() = stopWatch.Reset(); stopWatch.Start()
//let showTime() = printfn "it took %d ms" stopWatch.ElapsedMilliseconds


//let isPrimeNumber x =
//    let mutable i = 2
//    let mutable isFactorFound = false
//    while not isFactorFound do
//        if x % i =0 then
//            isFactorFound <- true
//        i <- i + 1
//    not isFactorFound

//let numbers = [| for i in 10000000..10004000 -> i|]
//let primeInfo =
//    numbers
//    |> Array.map (fun x -> (x, isPrimeNumber x))

//let primeInfo2 =
//    numbers
//    |> Array.Parallel.map (fun x -> (x, isPrimeNumber x))


[<EntryPoint>]
let main argv =
    //Not sure if I get correct result!
    (*ResetStopWatch()
    primeInfo
    showTime()

    //Check for performance values using Async parallel/concurrent library  

    ResetStopWatch()
    primeInfo2
    showTime()*)
    printfn "WORK ALREADY AAA"
    Exercises.printAgent.Post "Hello from somewhere"
    //Exercises.printAgent.Start()
    0 // return an integer exit code