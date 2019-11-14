(*
    5i0.a       isTable
*)

/// <summary> Finder ud af hvorvidt en liste med lister er lovlig, altså hvorvidt alle lister ikke er tomme og længden på hver liste er identisk </summary>
/// <param name="llst"> En liste af lister med vilkårlig type </param>
/// <returns> En bool, hvor true betyder at det er en lovlig liste </returns>
let isTable (llst : 'a list list) : bool =
   let anyEmpty = not (List.forall (fun (x: 'a list) -> x.IsEmpty) llst)
   let lengthIdentical = List.forall (fun (x: 'a list) -> llst.[0].Length = x.Length) llst
   anyEmpty && lengthIdentical

(*
    5i0.b       firstColumn
*)

/// <summary> Udtager den første kolonne af en liste, kun hvis det er en lovlig tabel </summary>
/// <param name="llst"> En liste af lister af vilkårlig type 'a </param>
/// <returns> En liste af vilkårlig type 'a med værdierne fra første kolonne </returns>
let firstColumn (llst: 'a list list) : 'a list = if isTable llst then List.map List.head llst else []

(*
    5i0.c       isTable
*)

/// <summary> Sletter første kolonne af liste (inkluderer kun tail), kun hvis det er en lovlig tabel </summary>
/// <param name="llst"> En liste af lister af vilkårlig type 'a </param>
/// <returns> En liste af lister af vilkårlig type 'a med alle kolonner efter første</returns>
let dropFirstColumn (llst: 'a list list) : 'a list list =
   if isTable llst then List.map List.tail llst else [[]]

/// <summary> Transposering af liste med lister </summary>
/// <param name="llst"> En liste af lister af vilkårlig type 'a </param>
/// <returns> En liste af lister af vilkårlig type 'a vendt om (transposeret) </returns>
let transpose (llst: 'a list list) : 'a list list =
   List.map firstColumn (List.init llst.Head.Length (fun x ->
   List.fold (fun x f -> f x) llst (List.init x (fun x -> dropFirstColumn))))

let lst = [[1;2;3];[4;5;6];[7;8;9]]
printfn "%A" (transpose lst)
