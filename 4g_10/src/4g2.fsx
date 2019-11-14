#r "vec2d.exe"
open System
open vec2d

let polyLen (n : int) : float =
   let mutable sum = 0.0
   let theta = (2.0 * Math.PI) / (float n)
   for i = 0 to n - 1 do
      let pointDiff = (cos (theta * float (i + 1)) - cos (theta * float i), sin (theta * float (i + 1)) - sin (theta * float i))
      sum <- sum + (len pointDiff)
   sum

let mutable x = 4.0
let mutable i = 1
while x < 6.283185 do
   x <- polyLen i
   printfn "%5i: %f" i x
   i <- i * 2