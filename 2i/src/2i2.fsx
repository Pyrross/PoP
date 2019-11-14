printfn "hello\nworld\n"
printfn "hello\\nworld\\n"
printfn @"hello\nworld\n"
printfn """hello\nworld\n"""

(*
Det er altså tre måde hvorpå man kan lave strenge som ignorerer \. Først og fremmest kan man escape \, ved at lave to \\.
Derudover kan man sætte en modifier @ foran strengen. Tilsidst kan man lave triple quote string.
*)