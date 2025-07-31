module Records.Models

// defining the Coach type to hold metadata about NBA coaches
type Coach = {
    Name : string              // full name of the coach
    FormerPlayer : bool       // true if the coach previously played professionally
}

// structuring Stats to capture basic win/loss info for a team
type Stats = {
    Wins : int
    Losses : int
}

// creating PlayerStats to represent performance of individual players
type PlayerStats = {
    PlayerName : string       // name of the player
    Points : int              // average points per game
    Assists : int             // average assists per game
    Rebounds : int            // average rebounds per game
}

// assembling the Team record with full breakdown
type Team = {
    Name : string                     // team name
    Coach : Coach                     // coach metadata
    Stats : Stats                     // team win/loss record
    PlayerStats : PlayerStats list    // list of player performance data
    Opponents : string list           // recent or frequent rival teams
}
