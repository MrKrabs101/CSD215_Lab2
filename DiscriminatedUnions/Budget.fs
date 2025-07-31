module DiscriminatedUnions.Budget

open DiscriminatedUnions.Models // importing DU types for activities

// calculating the estimated cost of a Valentine's Day activity
let calculateBudget (activity: Activity) : float =
    match activity with
    | BoardGame
    | Chill -> 0.0 // simple activities with no cost

    | Movie mt -> // branching based on movie type
        match mt with
        | Regular -> 12.0
        | IMAX -> 17.0
        | DBOX -> 20.0
        | RegularWithSnacks -> 12.0 + 5.0
        | IMAXWithSnacks -> 17.0 + 5.0
        | DBOXWithSnacks -> 20.0 + 5.0

    | Restaurant cuisine -> // cost based on selected cuisine
        match cuisine with
        | Korean -> 70.0
        | Turkish -> 65.0

    | LongDrive (km, rate) -> float km * rate // calculating fuel cost
