open System.Net

let wc = new WebClient()
wc.UploadString("https://localhost:5001/p/Brett/Rowberry", "")
wc.UploadString("https://localhost:5001/p/Rowberry", "")