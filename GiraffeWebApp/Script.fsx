/// nameof
// https://stackoverflow.com/questions/48304398/is-there-an-equivalent-of-cs-nameof-in-f
open Microsoft.FSharp.Quotations

let nameof (q:Expr<_>) = 
  match q with 
  | Patterns.Let(_, _, DerivedPatterns.Lambdas(_, Patterns.Call(_, mi, _))) -> mi.Name
  | Patterns.PropertyGet(_, mi, _) -> mi.Name
  | DerivedPatterns.Lambdas(_, Patterns.Call(_, mi, _)) -> mi.Name
  | _ -> failwith "Unexpected format"

let any<'R> : 'R = failwith "!"

nameof <@ any<System.Random>.Next @>
nameof <@ System.Char.IsControl @>
nameof <@ System.Char.ToLower @>

///

let quote = <@ 
                let x = 5
                let y = x
                y
            @>

///map

/// bind: map followed flatten
/// collect = bind
/// collect with id is flatten
/// bind = map >> flatten
/// bind aka flatMap
let xs = [ 1 .. 3 ]
let ys = [ 4 .. 6 ]
let xAndYs = [xs; ys]

let flatXandYs = List.collect id xAndYs

let bindXandYs = List.collect (fun a 
                                -> a |> (List.map (fun x -> x |> string)) ) xAndYs

let option = Some 5
let none = None
let incrementOption = Option.map (fun o -> o + 1)

incrementOption option
incrementOption none

let incrementOption' value = Option.bind (fun a -> Some (a + 1) ) value
incrementOption' (Some 5)
incrementOption' None

let fancyFunc value = 
    match value with
    | 5 -> None
    | x -> Some (x + 1)

let incrementOption'' value = Option.bind fancyFunc value
incrementOption'' (Some 5)
incrementOption'' (Some 6)

//bad
let incrementOption''' value = Option.map fancyFunc value
incrementOption''' None
incrementOption''' (Some 5)

/// ROP
let validate1 x = 
    if x > 5 then (Ok x)
    else Error "less than 5"

let validate2 x = 
    if x % 2 = 0 then (Ok x)
    else Error "odd"

//short-circuit, return first failure
let validateAll = validate1 >> Result.bind validate2
validateAll 5
validateAll 7
validateAll 3