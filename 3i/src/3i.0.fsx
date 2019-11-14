(**
3i.0 a		Funktion for summering
**)

/// Summen af naturlige tal fra 1 til n ved normal summering
/// <summary>Find summen s når der startes fra i = 1 og summeres til n = 1</summary>
/// <remark> </remark>
/// <param name="n">Input for funktionen der indikerer antallet af led i summeringen</param>
/// <param mutable name="i">Start-værdien for sum, kan ændres da det også er tælleværdi</param>
/// <param mutable name="s">Resultatet af summering gemmes her, for hver iteration</param>
/// <returns>Resultatet af summeringen s</returns>
let sum n : int =
   let mutable i = 1
   let mutable s = 0
   while i <= n do
      s <- s + i
      i <- i + 1
   s

(**
3i.0 b		Funktion for simplificering
**)
/// Summen af naturlige tal fra 1 til n ved omskrivelse
/// <summary>Find summen som funktion af simplificeringen n * (n + 1) / 2</summary>
/// <param name="n">Input for funktionen der benyttes til udregning af summen</param>
/// <returns>Resultatet af n * (n + 1) / 2 hvis n>=0, ellers 0</returns>
let simpleSum n : int =
   if n >= 0 then n * (n + 1) / 2 else 0

(**
3i.0 c		Input fra kommandoprompt
**)

/// Her benyttes System.Console til at få programmet til at kommunikere med kommandoprompten
/// <param name="n">Bundet til det tal der indtastes i kommandoprompten</param>
System.Console.WriteLine "Her udregnes sum_{i=1}^n i."
System.Console.Write " Indtast n: "
let n = int (System.Console.ReadLine ())

/// Der bliver printet med de to metoder for n
printfn "sum_{i=1}^%A i = %A" n (sum n)
printfn "%A * (%A + 1) / 2 = %A" n n (simpleSum n)

(**
3i.0 d		Tabel
**)
/// Udskriver blot tabellen. Ikke en funktion, men looper igennem fra 0 til 10
printfn "n          sum n          simpleSum n"
for i in 0..10 do
   printfn "\n%A          %A             %A" i (sum i) (simpleSum i)

(**

(**
3i.0 e		Her er koden til udvidelsen af programmet. Jeg har
		udkommenteret det, da det ellers ikke har samme navn.
		I må derfor selv udkommentere starten af dette program
		og fjerne min udkommentering af dette stykke! :)

Grundet den måde F# arbejdet med værdier på, vil metoden fra 3i.0(a)
gå op til det højeste antal. Her er der tale om n=65535, mens der ved metoden fra 3i.0(b) 
kun kan gå op til n*(n+1)<2147483647=> n=46340, hvor sum 65535=2147483647 og simpleSum 46340=2147483647. 
Det kan hermed klart ses at sum er mere effektiv. Vi kan modificere programmet ved at udvide rækkevidden af vores integer. 
Ved at gøre det til int64 går højeste værdi fra 2147483647 til 9223372036854775807. Vi kan dog udvide rækkevidden endnu 
mere (da vi alligevel kun arbejder med positive tal i simpleSum), ved at vælge unsigned: 
ved uint64} er rækkevidden 18446744073709551615.
**)

let sum n : uint64 =
   let mutable i = 1UL
   let mutable s = 0UL
   while i <= n do
      s <- s + i
      i <- i + 1UL
   s

let simpleSum n : uint64 =
   if n >= 0UL then n * (n + 1UL) / 2UL else 0UL

System.Console.WriteLine "Her udregnes sum_{i=1}^n i."
System.Console.Write " Indtast n: "
let n = uint64 (System.Console.ReadLine ())

printfn "sum_{i=1}^%A i = %A" n (sum n)
printfn "%A * (%A + 1) / 2 = %A" n n (simpleSum n)

**)