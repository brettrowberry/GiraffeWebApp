//$"{}"

type ID = ID of string
type Object = { Value : int }

let id = ID "hi"
let (ID inner) = id in printfn "%s" inner
printfn "%O" id //yucky

// Who cares about printf, like string interpolation better
let print thing = printfn "%O" thing
print 7
print {Value = 5}

let v = {Value = 5}
v.ToString()