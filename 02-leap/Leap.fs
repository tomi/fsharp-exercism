module Leap

let leapYear (year : int) : bool =
  if year % 400 = 0 then true
  elif year % 100 = 0 then false
  else year % 4 = 0
