//Iterate through fields of class

type Fields = { 
    Name: string
    Id: int
}

let f = { Name = "John"; Id = 5}

let getProperties f =
    f.GetType().GetProperties()
    |> Seq.map (fun p -> p.Name, p.GetValue(f) )

getProperties f