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

// 10/16
module Option = 
    let bind f m =
       match m with
       | None -> 
           None
       | Some x -> 
           x |> f 

// bind 
let words = [| "one"; "two"; "three"; null |]
let toChars (y:string) = if y = null then Array.empty else y.ToCharArray()
let chars = words |> Array.collect toChars

// JSON parsing
type Object = { Value : int }
type JsonResponse = { Values : Object[] }
let parse jsonResponse = jsonResponse.Values
let jsonResponses = 
    [| 
        {Values = [| {Value = 1} |] }
        { Values = [| {Value = 2}; { Value = 3 } |] } 
    |]
let getObjects jsonResponses =  jsonResponses |> Array.collect parse
getObjects jsonResponses

let options = [Some 1; None; Some 2]
options |> List.choose id
options |> List.choose (fun x -> x)
let s = Some 5
let t = id s

let singlePass options = options |> List.choose (fun o -> Option.map (fun i -> i + 1) o)

//2 passes
let doublePass options = 
    options
    |> List.map (Option.map (fun x -> x + 1))
    |> List.choose id

let composed loi = (Option.map >> List.map) (fun x -> x + 1) loi