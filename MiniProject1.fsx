open System

type Sizes = 
    | Small = 0
    | Medium = 1
    | Large  = 2

type Drinks =
   | Coffe of drinktype: String * size: Sizes * price: float
   | Tea of drinktype: String * size: Sizes * price: float
   | Juice of drinktype: String * size: Sizes * price: float


let c1 = Coffe(drinktype = "Latte", size = Sizes.Medium, price = 3.14)
let c2 = Coffe(drinktype = "Cortado", size = Sizes.Small, price = 1.9)
let c3 = Coffe(drinktype = "Lungo", size = Sizes.Large, price = 2.5)

let t1 = Tea(drinktype = "Chai", size = Sizes.Medium, price = 5.0)
let t2 = Tea(drinktype = "Green tea", size = Sizes.Small, price = 6.0)
let t3 = Tea(drinktype = "Black tea", size = Sizes.Small, price = 5.5)

let j1 = Juice(drinktype = "Orange juice", size = Sizes.Large, price = 4.9)
let j2 = Juice(drinktype = "Apple juice", size = Sizes.Large, price = 5.1)
let j3 = Juice(drinktype = "Pineaple juice", size = Sizes.Medium, price = 3.2)


let price (s:Drinks):float =
   match s with
   | Coffe(t,s,p) -> if s=Sizes.Small then p + 30.0 elif s=Sizes.Medium then p + 20.0 else p + 40.0
   | Tea(t,s,p) -> if s=Sizes.Small then p + 30.0 elif s=Sizes.Medium then p + 20.0 else p + 40.0
   | Juice(t,s,p) -> if s=Sizes.Small then p + 30.0 elif s=Sizes.Medium then p + 20.0 else p + 40.0

price j1