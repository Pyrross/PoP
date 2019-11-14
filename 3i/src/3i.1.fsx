open System.Text

(**
3i.1 (a)	mulTable
**)
// Vi laver en funktion som kan tage n som input (antallet af rækker), og som outputter string
/// <summary>Lav string med tabel med n rækker i en gangetabel ved udtrækning</summary>
/// <remarks>Fejler ved n < 0, og ville fejle ved n > 10 hvis ikke det var for if-statement til sidst</remark>
/// <example>
/// 	Følgende kode:
///	<code>
///	   let n = 1
///	   let table = mulTable n
/// 	   printf "%s" table
///	</code>
/// 	printer <c>  1        1        2        3        4        5        6        7        8        9       10</c> til prompten
/// </example>
/// <param type="int" name="n">Antal rækker i tabellen</param>
/// <param type="string" name="s">Den fulde streng for n=10</param>
/// <returns>Den del af tabellen som består af rækkerne 1..n</returns>

let mulTable (n : int) : string =
   let s = """  1        1        2        3        4        5        6        7        8        9       10
  2        2        4        6        8       10       12       14       16       18       20
  3        3        6        9       12       15       18       21       24       27       30
  4        4        8       12       16       20       24       28       32       36       40
  5        5       10       15       20       25       30       35       40       45       50
  6        6       12       18       24       30       36       42       48       54       60
  7        7       14       21       28       35       42       49       56       63       70
  8        8       16       24       32       40       48       56       64       72       80
  9        9       18       27       36       45       54       63       72       81       90
 10       10       20       30       40       50       60       70       80       90      100
"""
   // Da tabellen er af et specielt format, hvor længden af hver række ganges med n.
   // Fordi vi senere laver en tabel som sammenligner mulTable og loopMulTable, skal outputtet
   // af denne funktion være tilsvarende længden af loopMulTable. Vi benytter String.replicate til
   // at lave et vist antal mellemrum, så når n>10 blot består af tomme rækker. Vi laver altså et if-statement:
   if n > 10 then s.[0..10*95-1] + String.replicate (95 * (n - 10)) " " else s.[0..n*95-1]


// Afprøvning af mulTable funktionen
printfn "Afprøver mulTable-funktion"
let mul1 = mulTable 1
let mul2 = mulTable 2
let mul3 = mulTable 3
let mul10 = mulTable 10 // svarer til hele s-strengen

printfn "mulTable for n=1: \n%s" mul1 // returnerer det rigtige for n=1
printfn "mulTable for n=2: \n%s" mul2 // returnerer det rigtige for n=2
printfn "mulTable for n=3: \n%s" mul3 // returnerer det rigtige for n=3
printfn "mulTable for n=10: \n%s" mul10 // returnerer det rigtige for n=10


(**
3i.1 (b)	loopMulTable
**)
// Vi laver en funktion som kan tage n som input (antallet af rækker), og som outputter string
/// <summary>Lav string med tabel med n rækker i en gangetabel ved for-loops</summary>
/// <example>
/// 	Følgende kode:
///	<code>
///	   let n = 1
///	   let table = loopMulTable n
/// 	   printf "%s" table
///	</code>
/// 	printer <c>  1        1        2        3        4        5        6        7        8        9       10</c> til prompten
/// </example>
/// <param type="int" name="n">Antal rækker i tabel</param>
/// <param mutable type="string" name="s">Variabel der tillægges ny værdi for hver iteration, og til sidst udgør den fulde streng som returneres</param>
/// <param type="int" name="row">Tællevariabel som tæller række fra 1 til n</param>
/// <param type="int" name="col">Tællevariabel som tæller kolonne fra 1 til 10</param>
/// <returns>s, som er alle rækker fra 1 til n</returns>

let loopMulTable (n : int) : string =
   let mutable s = ""
   for row = 1 to n do
      s <- s + sprintf" %2d" row
      for col = 1 to 10 do
          s <- s + sprintf" %8d" (col * row)
      s <- s + sprintf "\n"
   s



// Afprøvning af loopMulTable funktionen
printfn "Afprøver loopMulTable-funktion"
let lmul1 = loopMulTable 1
let lmul2 = loopMulTable 2
let lmul3 = loopMulTable 3
let lmul10 = loopMulTable 10

printfn "loopMulTable for n=1: \n%s" lmul1 // returnerer det rigtige for n=1
printfn "loopMulTable for n=2: \n%s" lmul2 // returnerer det rigtige for n=2
printfn "loopMulTable for n=3: \n%s" lmul3 // returnerer det rigtige for n=3
printfn "loopMulTable for n=10: \n%s" lmul10 // returnerer det rigtige for n=10


(**
3i.1 (c)	Tabel med sammenligning
**)
/// <summary>Lav string med tabel hvor hver række af resultaterne af mulTable og loopMulTable sammenlignes</summary>
/// <remarks>Når n>10 er mulTable n = loopMulTable n: false</remark>
/// <example>
/// 	Følgende kode:
///	<code>
///	   let comparison = compareTableValue 12
///	   printf "%s" comparison
///	</code>
/// 	printer <c>  n     mulTable n = loopMulTable n
///	 	     1      true
///		     2      true
///		     3      true
///		     4      true
///		     5      true
/// 		     6      true
///		     7      true
///		     8      true
///		     9      true
///		    10      true
///		    11     false
///		    12     false
///	</c> til prompten
/// </example>
/// <param type="int" name="n">Antal rækker i tabellen</param>
/// <param type="string" name="muln">Resultatet af mulTable n</param>
/// <param type="string" name="lmuln">Resultatet af loopMulTable n</param>
/// <param type="int" name="row">Tællevariabel for rækker fra 1 til n</param>
/// <returns>En tabel med n og sammenligning af muln og lmuln</returns>

let compareTableValue (n : int) : string =
   let muln = mulTable n
   let lmuln = loopMulTable n
   let mutable s = "  n     mulTable n = loopMulTable n\n"
   for row = 1 to n do
      s <- s + sprintf"%3d %9b\n" row (muln.[(row-1)*95..(row*95)-3] = lmuln.[(row-1)*94..(row*94)-2])
   s

printfn "%s" (compareTableValue 20)


(**
3i.1 (d)	Forskel på "%s" og "%A"
###
	Både printf "%s" og printf "%A" kan printe strenge, men %s er en type-specifik formatering
	hvor der indikeres at det som skal formateres er en streng, hvorimod %A fungerer som et 
	wildcard, hvor enhver type værdi kan repræsenteres. Der er desuden en forskel rent æstetisk,
	da %s er mere clean når der printes, hvorimod %A inkluderer "" rundt om strengen.
###
**)