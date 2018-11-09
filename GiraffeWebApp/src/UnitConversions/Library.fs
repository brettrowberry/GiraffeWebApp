namespace UnitConversions

module Say =
    let hello name =
        sprintf "Hello %s" name

module Length =
    [<Literal>]
    let LengthFilePath = __SOURCE_DIRECTORY__ + "/Length.csv"
    open FSharp.Data
    let lengthProvider = CsvProvider<LengthFilePath>.GetSample()
    let rows = lengthProvider.Rows

    //TODO convert a Length to a Length