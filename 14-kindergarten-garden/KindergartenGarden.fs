module KindergartenGarden

type Plant = Radishes | Clover | Grass | Violets

let startIndexByStudent =
  Map [
    ("Alice", 0)
    ("Bob", 2)
    ("Charlie", 4)
    ("David", 6)
    ("Eve", 8)
    ("Fred", 10)
    ("Ginny", 12)
    ("Harriet", 14)
    ("Ileana", 16)
    ("Joseph", 18)
    ("Kincaid", 20)
    ("Larry", 22)
  ]

let cupToPlant (cup: char) =
  match cup with
  | 'R' -> Plant.Radishes
  | 'C' -> Plant.Clover
  | 'G' -> Plant.Grass
  | 'V' -> Plant.Violets
  | _ -> failwith (sprintf "Invalid plant %c" cup)

let plants (diagram: string) (student: string) =
  let startIdx = Map.tryFind student startIndexByStudent
  match startIdx with
  | None -> []
  | Some firstPlantIdx ->
      diagram.Split [|'\n'|]
      |> Seq.collect (Seq.skip firstPlantIdx >> Seq.take 2)
      |> Seq.map cupToPlant
      |> Seq.toList
