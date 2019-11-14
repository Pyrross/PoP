//F# Compiler for F# 4.0 (Open Source Edition), Mono 4.2.1

open System
// tallet
let number = 20
printfn "Tallet er %d" number

// kalkulering fra heltal til binaer
let mutable value = number
let mutable rem = 3
let mutable binary = ""

while value > 0 do
  rem <- value % 2
  value <- value / 2
  binary <- string rem + binary

do printfn "i binaer: %s_2" binary

// kalkulering fra binaer til decimal
binary <- "10101"
let mutable i = 0.0
let mutable res = 0.0
let mutable c = 0.0
let mutable k = float binary.Length - 1.0

while int i < binary.Length do
  c <- (float binary.[int i] - 48.0) * (2.0 ** k)
  res <- res + c
  i <- i + 1.0
  k <- k - 1.0
let ex = int res
do printfn "%s konverteret tilbage til decimaltal: %d_10" binary ex


// kalkulering fra heltal til hexadecimal
value <- number
rem <- 100
let pos = "0123456789abcdef"
let mutable hexa = ""

while value > 0 do
  rem <- value % 16
  value <- value / 16
  hexa <- string pos.[rem] + hexa
    
do printfn "i hexadecimal: %s_16" hexa

// kalkulering fra hexadecimal til heltal
hexa <- "3f"
value <- int hexa.[0..hexa.Length-2] * 16
rem <- 0

while rem < 16 do
  if hexa.[hexa.Length-1] = pos.[rem]
    then value <- value + rem
  rem <- rem + 1
printfn "%s konverteret tilbage til decimaltal: %d_10" hexa value

// kalkulering af oktaler
value <- number
rem <- 100
let mutable oktal = ""

while value > 0 do
  rem <- value % 8
  value <- value / 8
  oktal <- string rem + oktal
  
do printfn "i oktal: %s_8" oktal

// kalkulering fra oktal til heltal
oktal <- "73"
i <- 0.0
c <- 0.0
res <- 0.0
k <- float oktal.Length - 1.0
while int i < oktal.Length do
  c <- (float oktal.[int i] - 48.0) * (8.0 ** k)
  res <- res + c
  i <- i + 1.0
  k <- k - 1.0

value <- int res
do printfn "%s konverteret tilbage til decimaltal: %d_10" oktal value



(**
Decimal		Binær		Hexadecimal		Oktal
10		1010		a			12
21		10101		15			25
63		111111		3f			77
59		111011		3b			73
**)