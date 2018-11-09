open System.IO
//http://blog.ploeh.dk/2016/09/26/decoupling-decisions-from-effects/

// public static string GetUpperText(string path)
// {
//     if (!File.Exists(path)) return "DEFAULT";
//     var text = File.ReadAllText(path);
//     return text.ToUpperInvariant();
// }

let GetUpperText path =
    if File.Exists path then "DEFAULT"
    else 
        let text = File.ReadAllText path
        text.ToUpperInvariant()

module String =
    let toUpper (str : string) = str.ToUpper()

let getUpper (text : string) = text.ToUpperInvariant () //why can't it infer it's a string???

type Action = ReadFromFile of string | UseDefault of string



let decide path fileExists =
    if fileExists
    then ReadFromFile path
    else UseDefault "DEFAULT"

let getValue f = function
    | ReadFromFile path -> f path
    | UseDefault value  -> value

let getUpperText path =
    path
    |> File.Exists
    |> decide path
    |> getValue (File.ReadAllText >> getUpper)

//either monad
type Result<'TSuccess, 'TFailure> =
    | Success of 'TSuccess
    | Failure of 'TFailure
    
module Result =
    let bind f = function
        | Success succ -> f succ
        | Failure fail -> Failure fail
 
    let map f = function
        | Success succ -> Success (f succ)
        | Failure fail -> Failure fail
 
    let split f x = if f x then Success x else Failure x
 
    let either f g = function
        | Success succ -> f succ
        | Failure fail -> g fail

let getUpperTextEither path =
    path
    |> Result.split File.Exists
    |> Result.either (File.ReadAllText >> getUpper) (fun _ -> "DEFAULT")

// maybe
module Option =
    let defaultIfNone def x = defaultArg x def

let getUpperTextMaybe path =
    path
    |> Some
    |> Option.filter File.Exists
    |> Option.map (File.ReadAllText >> getUpper)
    |> Option.defaultIfNone "DEFAULT"