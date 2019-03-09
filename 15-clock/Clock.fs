module Clock

type Clock = int * int

let rec create hours minutes =
  if hours >= 24 then create (hours - 24) minutes
  elif hours < 0 then create (hours + 24) minutes
  elif minutes >= 60 then create (hours + 1) (minutes - 60)
  elif minutes < 0 then create (hours - 1) (minutes + 60)
  else (hours, minutes)

let add minutes (clockH, clockM) = create clockH (clockM + minutes)

let subtract minutes (clockH, clockM) = create clockH (clockM - minutes)

let display (hour, minutes) = sprintf "%02i:%02i" hour minutes
