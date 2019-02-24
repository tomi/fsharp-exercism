module CollatzConjecture

let (|Even|Odd|) number =
  if number % 2 = 0 then Even else Odd

let steps (number: int): int option =
  let rec takeStep number numSteps =
    match number with
    | n when n <= 0 -> None
    | 1 -> Some numSteps
    | Even -> takeStep (number / 2) (numSteps + 1)
    | Odd -> takeStep (3 * number + 1) (numSteps + 1)

  takeStep number 0
