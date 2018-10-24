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

