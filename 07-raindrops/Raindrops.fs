module Raindrops

let factors = Map.empty.Add(7, "Plong").Add(5, "Plang").Add(3, "Pling")

let convert (number : int) =
  factors
  |> Map.filter (fun factor _ -> number % factor = 0)
  |> (fun factors ->
    if Map.isEmpty factors then number.ToString()
    else Map.fold (fun state _ value -> state + value) "" factors
  )
