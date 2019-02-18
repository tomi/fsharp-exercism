module SpaceAge

type Planet =
  | Earth
  | Mercury
  | Venus
  | Mars
  | Jupiter
  | Saturn
  | Uranus
  | Neptune

let earthOrbitalPeriod = 31557600.0

let age (planet: Planet) (seconds: int64): float =
  let orbitalPeriodInS =
    match planet with
    | Earth -> earthOrbitalPeriod
    | Mercury -> 0.2408467 * earthOrbitalPeriod
    | Venus -> 0.61519726 * earthOrbitalPeriod
    | Mars -> 1.8808158 * earthOrbitalPeriod
    | Jupiter -> 11.862615 * earthOrbitalPeriod
    | Saturn -> 29.447498 * earthOrbitalPeriod
    | Uranus -> 84.016846 * earthOrbitalPeriod
    | Neptune -> 164.79132 * earthOrbitalPeriod

  float seconds / orbitalPeriodInS
