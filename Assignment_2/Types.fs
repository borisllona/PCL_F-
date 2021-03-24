module Types =
    open System

    //Constants for base price of the cup
    let cupS = 0.5
    let cupM = 1.0
    let cupL = 1.5

    ///Drink sizes type allows to avoid manually entering a string to a Drink type and creates a comprehensive type
    type Size = 
        | Small
        | Medium
        | Large

    ///Drink with three types that define drink type, size of a cup and the price for the drink (cup price excluded)
    type DrinkType = {name: string; size:Size; price: float}
    type Drink =
       | Coffee of DrinkType
       | Tea of DrinkType
       | Juice of DrinkType

    let c1 = Coffee{name = "Latte"; size = Size.Medium; price = 3.14 }
    let c2 = Coffee{name = "Cortado"; size = Size.Small; price = 1.9}
    let c3 = Coffee{name = "Lungo"; size = Size.Large; price = 2.5}

    let t1 = Tea{name = "Chai"; size = Size.Medium; price = 5.0}
    let t2 = Tea{name = "Green tea"; size = Size.Small; price = 6.0}
    let t3 = Tea{name = "Black tea"; size = Size.Small; price = 5.5}

    let j1 = Juice{name = "Orange juice"; size = Size.Large; price = 4.9}
    let j2 = Juice{name = "Apple juice"; size = Size.Large; price = 5.1}
    let j3 = Juice{name = "Pineapple juice"; size = Size.Medium; price = 3.2}

    ///Calculates drink price by adding drink price with the cup price
    let calculateDrinkPrice s =
       let priceBySize v = if v.size=Size.Small then v.price + cupS
                           elif v.size=Size.Medium then v.price + cupM
                           else v.price + cupL
       match s with
       | Coffee v -> priceBySize v
       | Tea v -> priceBySize v
       | Juice v -> priceBySize v

    let tPrice1 = calculateDrinkPrice c1
    let tPrice2 = calculateDrinkPrice t1
    let tPrice3 = calculateDrinkPrice j1

    ;;
//printfn "c1: %f t1: %f j1: %f" tPrice1 tPrice2 tPrice3