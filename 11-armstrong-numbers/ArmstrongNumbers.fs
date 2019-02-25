module ArmstrongNumbers

let isArmstrongNumber (number: int): bool =
  let numDigits = number.ToString().Length

  number.ToString()
    |> Seq.map (string >> int)
    |> Seq.sumBy (fun x -> pown x numDigits)
    |> (=) number
