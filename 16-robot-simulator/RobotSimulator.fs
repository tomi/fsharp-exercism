module RobotSimulator

type Direction = North | East | South | West
type Position = int * int
type Robot = { direction: Direction; position: Position }

let create direction position =
  {
    direction = direction
    position = position
  }

let rotateRight { direction=dir; position=pos } =
  match dir with
  | North -> create East pos
  | East -> create South pos
  | South -> create West pos
  | West -> create North pos

let rotateLeft { direction=dir; position=pos } =
  match dir with
  | North -> create West pos
  | East -> create North pos
  | South -> create East pos
  | West -> create South pos

let advance { direction=dir; position=(x,y) } =
  match dir with
  | North -> create dir (x, y + 1)
  | East -> create dir (x + 1, y)
  | South -> create dir (x, y - 1)
  | West -> create dir (x - 1, y)

let handleInstruction robot instruction =
  match instruction with
  | 'R' -> rotateRight robot
  | 'L' -> rotateLeft robot
  | 'A' -> advance robot
  | _ -> failwith "Unknown command"

let move instructions robot =
  instructions |> Seq.fold handleInstruction robot
