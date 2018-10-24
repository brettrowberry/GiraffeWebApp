let funcs = 
            [
                (fun x -> x % 2 = 0)
                (fun x -> x % 3 = 0)
                (fun x -> x % 5 = 0)
            ]

let any x = funcs |> List.exists (fun f -> f x)
any 2 //T
any 3 //T
any 7 //F

let all x = funcs |> List.forall (fun f -> f x)
all 2 //F
all 3 //F
all 30 //T

//reduce
// let values = [ true; true; true]
let values = [ true; false; true]
let reduceAllValues = values |> List.reduce (&&)
let reduceAllFuncs x =
    funcs
    |> List.map (fun f -> f x)
    |> List.reduce (&&) //reduce throws on empty list

reduceAllFuncs 3
reduceAllFuncs 30

let reduceAnyFuncs x = 
    funcs
    |> List.map (fun f -> f x)
    |> List.reduce (||)

reduceAnyFuncs 3
reduceAnyFuncs 7

//fold
let foldAllValues = values |> List.fold (&&) true
let foldAllFuncs x =
    funcs
    |> List.map (fun f -> f x)
    |> List.fold (&&) true  //empty of && is true

foldAllFuncs 3
foldAllFuncs 30

let foldAnyFuncs x =
    funcs
    |> List.map (fun f -> f x)
    |> List.fold (||) false //empty of || is false

foldAnyFuncs 7
foldAnyFuncs 3

let foldAnyFuncs' x =
    funcs
    |> List.fold (fun state f -> state || f x) false

foldAnyFuncs' 3
foldAnyFuncs' 7

let generateFolder x = (fun state f -> state || f x)
let generateFolderObfuscated x state f = state || f x

let foldAnyFuncs'' x =
    funcs
    |> List.fold (generateFolder x) false

let foldAnyFuncs''' x =
    funcs
    |> List.fold (generateFolderObfuscated x) false

foldAnyFuncs'' 3
foldAnyFuncs'' 7