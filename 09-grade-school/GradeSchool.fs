module GradeSchool

type School = Map<int, string list>

let empty: School = Map.empty

let add (student: string) (grade: int) (school: School): School =
  match Map.tryFind grade school with
  | Some x -> Map.add grade (student::x) school
  | None -> Map.add grade [student] school

let roster (school: School): string list =
  school
  |> Map.toList
  |> List.collect (fun (_, studentsOnGrade) -> List.sort studentsOnGrade)

let grade (number: int) (school: School): string list =
  match Map.tryFind number school with
  | Some studentsOnGrade -> List.sort studentsOnGrade
  | None -> []
