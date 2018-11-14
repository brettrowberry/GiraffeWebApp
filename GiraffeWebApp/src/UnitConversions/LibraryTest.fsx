#load @"../../.paket/load/netstandard2.0/FSharp.Data.fsx"
#load "Library.fs"
open UnitConversions

Length.convert 1000. "mm" "m"
Length.convert 1000. "m" "km"
Length.convert 5280. "ft" "km"
