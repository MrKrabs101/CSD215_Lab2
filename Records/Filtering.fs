module Records.Filtering

open Records.Models // importing team-related types from Models

// creating a helper function to check if a team is successful
let isSuccessful (team: Team) =
    team.Stats.Wins > team.Stats.Losses

// filtering the full list to only include successful teams
let filterSuccessfulTeams (teams: Team list) =
    teams |> List.filter isSuccessful
