module continuedFraction
/// <summary> Udregning af kædebrøk givet ved en heltalsliste </summary>
/// <param name="lst"> En heltalsliste </param>
/// <returns> En float, som repræsenterer resultatet af kædebrøken </summary>
let rec cfrac2float (lst: int list) : float =
   if lst.Length = 1 then float lst.Head
   else float lst.Head + 1.0 / (cfrac2float lst.Tail)

/// <summary> Finder kædebrøkens repræsentative liste ved en given float </summary>
/// <param name="x"> En float, som repræsenterer resultatet af kædebrøken </param>
/// <returns> En heltalsliste </summary>
let rec float2cfrac (x: float) : int list =
   let qi = floor (System.Math.Round(x,5))
   let ri = x - qi
   if System.Math.Round(ri, 7) = 0.0 then [int qi]
   else int qi :: float2cfrac (1.0 / (x - float (int qi)))

/// <summary> Finder den repræsentative liste for kædebrøk ved en given kvotient/brøk </summary>
/// <param name="t"> Heltals-dividend </param>
/// <param name="n"> Heltals-divisor </param>
/// <returns> En heltalsliste </summary>
let rec frac2cfrac (t: int) (n: int) : int list =
   if n = 0 then []
   elif t % n = 0 then [t]
   else t / n :: frac2cfrac n (t % n)

/// <summary> Finder en kvotient/brøk som svarer til resultatet af kædebrøk given ved en liste </summary>
/// <param name="lst"> En heltalsliste </param>
/// <param name="i"> Heltalsværdi for index </param>
/// <returns> En tuple bestående af to heltal: (divisor, dividend) </summary>
let rec cfrac2frac (lst: int list) (i: int) : int * int =
   if i < lst.Length then
       let qi = lst.[i]
       if i = 0 then
           let ti = qi
           let ni = 1
           (ti, ni)
       elif i = 1 then
           let ti = qi * fst(cfrac2frac lst (i - 1)) + 1
           let ni = qi * snd(cfrac2frac lst (i - 1))
           (ti, ni)
       else
           let ti = qi * fst(cfrac2frac lst (i - 1)) + fst(cfrac2frac lst (i - 2))
           let ni = qi * snd(cfrac2frac lst (i - 1)) + snd(cfrac2frac lst (i - 2))
           (ti, ni)
   else cfrac2frac lst (i - 1)
