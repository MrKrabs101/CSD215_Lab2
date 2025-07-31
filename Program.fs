open Records.Models
open Records.Filtering
open Records.Mapping
open Records.Instances

open DiscriminatedUnions.Models
open DiscriminatedUnions.Budget

[<EntryPoint>]
let main argv =
    // loading all team instances into a list
    let teams = 
        [ bostonCeltics
          sanAntonioSpurs
          losAngelesLakers
          oklahomaCityThunder
          phoenixSuns ]

    // filtering only the teams with more wins than losses
    let successfulTeams = filterSuccessfulTeams teams

    // printing details of successful teams
    printfn "=== Successful NBA Teams ===\n"
    successfulTeams
    |> List.iter (fun team ->
        let percentage = successPercentage team |> sprintf "%.2f"
        printfn "Team: %s" team.Name
        printfn "Coach: %s (Former Player: %b)" team.Coach.Name team.Coach.FormerPlayer
        printfn "Wins: %d, Losses: %d" team.Stats.Wins team.Stats.Losses
        printfn "Success Percentage: %s%%" percentage
        printfn ""
    )

    // defining sample Valentine's Day activity choices
    let sampleActivities = 
        [ Movie IMAXWithSnacks
          Restaurant Turkish
          LongDrive (80, 0.15)
          Chill ]

    // calculating budget for each proposed activity
    printfn "\n=== Valentine's Day Activity Budget ===\n"
    sampleActivities
    |> List.iter (fun activity ->
        let cost = calculateBudget activity
        printfn "Activity: %A" activity
        printfn "Estimated Budget: $%.2f" cost
        printfn ""
    )

    0
