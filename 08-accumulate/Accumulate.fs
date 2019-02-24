module Accumulate

let accumulate (func: 'a -> 'b) (input: 'a list): 'b list =
  let rec _accumulate xs acc =
    match xs with
    | [] -> acc
    | head :: tail -> _accumulate tail (func head:: acc)

  _accumulate input []
  |> List.rev
