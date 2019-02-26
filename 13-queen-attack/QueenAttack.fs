module QueenAttack

type Coords = int * int

let create ((x, y): Coords) =
  0 <= x && x < 8 && 0 <= y && y < 8

let isOnSameRow (x1, _) (x2, _) = x1 = x2
let isOnSameColumn (_, y1) (_, y2) = y1 = y2
let isOnSameDiagonal (x1, y1) (x2, y2) = abs (y2 - y1) = abs (x2 - x1)

let canAttack (queen1: Coords) (queen2: Coords) =
  isOnSameRow queen1 queen2 ||
  isOnSameColumn queen1 queen2 ||
  isOnSameDiagonal queen1 queen2
