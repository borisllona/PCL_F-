// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open Types

//-------Assignment code-------
type DTGCafeMessage =
    | OrderDrink of Drink * int // e.g. (Coffe, 5)
    | LeaveAComment of string

let dtgVAT (price:float, vat:float):float = price + price * vat //not sure how can we have n or x as float, since n is VAT (0.2 == 20%) and x is total price? which is a float

let getDrinkName drink =
    match drink with
    | Coffee d -> d.name
    | Juice d -> d.name
    | Tea d -> d.name

let dtgCafeAgent = MailboxProcessor.Start(fun inbox ->
    printfn "Initializing Drink to Go Cafe Agent\n"
    let rec loop() = async {
        let! msg = inbox.Receive()
        match msg with
        | OrderDrink(drink, qty) ->
            let initialPrice = (calculateDrinkPrice drink) * float(qty)
            let vatPrice = dtgVAT(initialPrice, 0.2)
            printfn "Please pay %f EUR for your two %s drinks. Thanks!" vatPrice (getDrinkName drink)
        | LeaveAComment(comment) -> printfn "%s" comment
        return! loop()
    }
    loop()
)

[<EntryPoint>]
let main argv =
    printfn "Welcome to DTG Cafe\n"
    dtgCafeAgent.Post(OrderDrink(Tea{name="AmazingTea"; size=Size.Small; price = 5.0}, 5))
    dtgCafeAgent.Post(OrderDrink(Coffee{name="Latte"; size=Size.Small; price = 2.0}, 2))
    dtgCafeAgent.Post(OrderDrink(Juice{name="Fanta"; size=Size.Small; price = 3.0}, 10))
    dtgCafeAgent.Post(LeaveAComment("Didn't like the coffee"))
   
    0 // return an integer exit code