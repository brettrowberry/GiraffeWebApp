namespace UnitConversions

open FSharp.Data

module Length =
    [<Literal>]
    let LengthFilePath = __SOURCE_DIRECTORY__ + "/Length.csv"

    let lengthProvider = CsvProvider<LengthFilePath, HasHeaders = true>.GetSample()
    
    type Unit = {
        Name : string
        Abbreviation : string
        Value : float
    }

    let rows =
        lengthProvider.Rows
        |> Seq.map (fun x -> 
            { Name = x.Name; Abbreviation = x.Abbreviation; Value = x.Value })
        |> Seq.toArray

    let predicates : (Unit -> string -> bool) list = 
        [
            fun u x -> x = u.Name
            fun u x -> x = u.Abbreviation
        ]

    let any u s = predicates |> Seq.exists (fun f -> f u s)        

    let valueFrom nameOrAbbreviation =
        rows
        |> Seq.tryFind (fun u -> any u nameOrAbbreviation)
        |> Option.map (fun u -> u.Value)

    let convert value source target : float option =
        (valueFrom source, valueFrom target) //extra allocation here if we're picky
        ||> Option.map2 (fun source target -> value * source / target)