if [ ! -e "paket.lock" ]
then
    exec mono .paket/paket.exe install
fi
dotnet restore src/GiraffeWebApp
dotnet build src/GiraffeWebApp

dotnet restore tests/GiraffeWebApp.Tests
dotnet build tests/GiraffeWebApp.Tests
dotnet test tests/GiraffeWebApp.Tests
