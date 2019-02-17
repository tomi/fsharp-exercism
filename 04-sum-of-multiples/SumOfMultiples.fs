module SumOfMultiples

let generateMultiplesForNumber (upperBound: int) (number: int): seq<int> =
  if number = 0 then Seq.singleton 0
  else seq { number .. number .. upperBound - 1 }

let generateMultiples (numbers: int list) (upperBound: int): seq<int> =
    numbers |> Seq.collect (generateMultiplesForNumber upperBound)
            |> Seq.distinct

let sum (numbers: int list) (upperBound: int): int =
  Seq.sum (generateMultiples numbers upperBound)
