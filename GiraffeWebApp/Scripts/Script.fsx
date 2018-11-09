//DSL

type PutPreposition =
    | In
    | Under
    | Behind

type GetPreposition =
    | From

let put item preposition place = printfn "Put %s %A %s" item preposition place

let Put item preposition place = function
    | In -> put item place
    | Under -> put item place
    | Behind -> put item place

let Get item preposition place = function
    | From -> put item place

Put "Can" Behind "Pantry"