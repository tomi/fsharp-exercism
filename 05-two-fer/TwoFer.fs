module TwoFer

let twoFer (input: string option): string =
  match input with
  | Some x -> sprintf "One for %s, one for me." x
  | None -> "One for you, one for me."
