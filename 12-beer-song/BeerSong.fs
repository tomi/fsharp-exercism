module BeerSong

let statement numBottles =
  match numBottles with
  | 0 -> "No more bottles of beer on the wall, no more bottles of beer."
  | 1 -> "1 bottle of beer on the wall, 1 bottle of beer."
  | n -> sprintf "%i bottles of beer on the wall, %i bottles of beer." n n

let takedown numBottles =
  match numBottles with
  | 0 -> "Go to the store and buy some more, 99 bottles of beer on the wall."
  | 1 -> "Take it down and pass it around, no more bottles of beer on the wall."
  | 2 -> "Take one down and pass it around, 1 bottle of beer on the wall."
  | n -> sprintf "Take one down and pass it around, %i bottles of beer on the wall." (n - 1)

let recite (startBottles: int) (takeDown: int) =
  let text =
    seq { startBottles .. -1 .. startBottles - takeDown + 1 }
    |> Seq.map (fun n -> sprintf "%s\n%s" (statement n) (takedown n))
    |> String.concat "\n\n"

  text.Split [|'\n'|]
  |> Array.toList
