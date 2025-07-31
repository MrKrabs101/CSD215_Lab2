module Records.Mapping

open Records.Models // importing data types from the Models module

// calculating the success percentage for a team using win/loss stats
let successPercentage (team: Team) =
    let wins = float team.Stats.Wins                  // converting wins to float
    let total = float (team.Stats.Wins + team.Stats.Losses) // calculating total games
    if total = 0.0 then 0.0                            // handling division by zero
    else (wins / total) * 100.0                        // computing percentage
