#r "vec2d.exe"
open System
open vec2d

printfn "White-box testing of vec2d.fsi"
printfn "\tUnit: len"
printfn "\t\tBranch: 0 - %b" (len (1.0, 1.0) = 2.0**0.5)

printfn "\tUnit: ang"
printfn "\t\tBranch: 0 - %b" (ang (10.0,10.0) = Math.PI / 4.0)

printfn "\tUnit: scale"
printfn "\t\tBranch: 0 - %b" (scale 3.0 (2.0, 3.0) = (6.0, 9.0))

printfn "\tUnit: add"
printfn "\t\tBranch: 0 - %b" (add (11.0, 2.0) (2.0, 11.0) = (13.0, 13.0))

printfn "\tUnit: dot"
printfn "\t\tBranch: 0 - %b" (dot (11.0, 2.0) (2.0, 11.0) = 22.0 + 22.0)
