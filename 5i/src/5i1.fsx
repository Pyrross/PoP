/// <summary> Udtrækker hvert element i en listes underlister, og laver den éndimensionel </summary>
/// <param name="llst"> Liste af lister med typen 'a </param>
/// <returns> En liste af typen 'a </returns>
let concat (llst : 'a list list) : 'a list = List.collect (fun x -> x) llst

let list = [[1;2;3];[4;5]]
printfn "%A %A" list.Concat (concat list)
