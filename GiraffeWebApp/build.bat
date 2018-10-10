IF NOT EXIST paket.lock (
    START /WAIT .paket/paket.exe install
)
dotnet restore src/GiraffeWebApp
dotnet build src/GiraffeWebApp

dotnet restore tests/GiraffeWebApp.Tests
dotnet build tests/GiraffeWebApp.Tests
dotnet test tests/GiraffeWebApp.Tests
