open System

//Constants for base price of the cup
let cupS = 0.5
let cupM = 1.0
let cupL = 1.5

///Drink sizes type allows to avoid manually entering a string to a Drink type and creates a comprehensive type
type Size = 
    | Small = 0
    | Medium = 1
    | Large  = 2

///Drink with three types that define drink type, size of a cup and the price for the drink (cup price excluded)
type Drink =
   | Coffee of drinkType: String * size: Size * price: float
   | Tea of drinkType: String * size: Size * price: float
   | Juice of drinkType: String * size: Size * price: float


let c1 = Coffee(drinkType = "Latte", size = Size.Medium, price = 3.14)
let c2 = Coffee(drinkType = "Cortado", size = Size.Small, price = 1.9)
let c3 = Coffee(drinkType = "Lungo", size = Size.Large, price = 2.5)

let t1 = Tea(drinkType = "Chai", size = Size.Medium, price = 5.0)
let t2 = Tea(drinkType = "Green tea", size = Size.Small, price = 6.0)
let t3 = Tea(drinkType = "Black tea", size = Size.Small, price = 5.5)

let j1 = Juice(drinkType = "Orange juice", size = Size.Large, price = 4.9)
let j2 = Juice(drinkType = "Apple juice", size = Size.Large, price = 5.1)
let j3 = Juice(drinkType = "Pineaple juice", size = Size.Medium, price = 3.2)


///Calculates drink price by adding drink price with the cup price
let calculateDrinkPrice s =
   match s with
   | Coffee(t,s,p) -> if s=Size.Small then p + cupS elif s=Size.Medium then p + cupM else p + cupL
   | Tea(t,s,p) -> if s=Size.Small then p + cupS elif s=Size.Medium then p + cupM else p + cupL
   | Juice(t,s,p) -> if s=Size.Small then p + cupS elif s=Size.Medium then p + cupM else p + cupL

let testPrice = calculateDrinkPrice j1