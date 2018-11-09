open System.Net

let wc = new WebClient()
wc.Headers.Add(HttpRequestHeader.ContentType, "application/json")

//GET
wc.DownloadString("https://localhost:5001/")
wc.DownloadString("https://localhost:5001/helloPage/Brett")
wc.DownloadString("https://localhost:5001/hello/Brett")

//POST
wc.UploadString("https://localhost:5001/person/Brett/Rowberry", "")
wc.UploadString("https://localhost:5001/person", 
    """{FirstName:"Brett", LastName:"Rowberry"}""")