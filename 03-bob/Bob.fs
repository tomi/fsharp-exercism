module Bob
open System

let hasLettersAndAreAllUppercase (input: string) =
  input |> Seq.exists(Char.IsLetter) && input |> Seq.filter(Char.IsLetter) |> Seq.forall(Char.IsUpper)

let response (input: string): string =
  if String.IsNullOrWhiteSpace input then "Fine. Be that way!"
  elif input.Trim().EndsWith "?" then
    if hasLettersAndAreAllUppercase input then "Calm down, I know what I'm doing!"
    else "Sure."
  elif hasLettersAndAreAllUppercase input then "Whoa, chill out!"
  else "Whatever."
