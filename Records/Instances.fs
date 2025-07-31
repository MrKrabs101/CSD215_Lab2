module Records.Instances

open Records.Models // bringing in model definitions

// Creating Boston Celtics team instance
let bostonCeltics = 
    { Name = "Boston Celtics"
      Coach = { Name = "Joe Mazzulla"; FormerPlayer = false }
      Stats = { Wins = 6196; Losses = 3695 }
      PlayerStats = 
        [ { PlayerName = "Jayson Tatum"; Points = 26; Assists = 4; Rebounds = 7 }
          { PlayerName = "Jaylen Brown"; Points = 23; Assists = 3; Rebounds = 6 } ]
      Opponents = ["Lakers"; "76ers"; "Heat"] }

// Adding San Antonio Spurs with key player data
let sanAntonioSpurs = 
    { Name = "San Antonio Spurs"
      Coach = { Name = "Gregg Popovich"; FormerPlayer = true }
      Stats = { Wins = 3949; Losses = 2339 }
      PlayerStats = 
        [ { PlayerName = "Victor Wembanyama"; Points = 20; Assists = 2; Rebounds = 10 }
          { PlayerName = "Devin Vassell"; Points = 18; Assists = 3; Rebounds = 5 } ]
      Opponents = ["Rockets"; "Grizzlies"; "Mavericks"] }

// Setting up Los Angeles Lakers team
let losAngelesLakers = 
    { Name = "Los Angeles Lakers"
      Coach = { Name = "Darvin Ham"; FormerPlayer = true }
      Stats = { Wins = 6086; Losses = 3600 }
      PlayerStats = 
        [ { PlayerName = "LeBron James"; Points = 28; Assists = 6; Rebounds = 7 }
          { PlayerName = "Anthony Davis"; Points = 25; Assists = 3; Rebounds = 11 } ]
      Opponents = ["Clippers"; "Warriors"; "Celtics"] }

// Defining Oklahoma City Thunder and their top contributors
let oklahomaCityThunder = 
    { Name = "Oklahoma City Thunder"
      Coach = { Name = "Mark Daigneault"; FormerPlayer = false }
      Stats = { Wins = 4688; Losses = 2538 }
      PlayerStats = 
        [ { PlayerName = "Shai Gilgeous-Alexander"; Points = 30; Assists = 5; Rebounds = 5 }
          { PlayerName = "Josh Giddey"; Points = 15; Assists = 6; Rebounds = 7 } ]
      Opponents = ["Nuggets"; "Jazz"; "Trail Blazers"] }

// Final team: Phoenix Suns with notable stats
let phoenixSuns = 
    { Name = "Phoenix Suns"
      Coach = { Name = "Frank Vogel"; FormerPlayer = false }
      Stats = { Wins = 4607; Losses = 2465 }
      PlayerStats = 
        [ { PlayerName = "Kevin Durant"; Points = 29; Assists = 5; Rebounds = 6 }
          { PlayerName = "Devin Booker"; Points = 27; Assists = 6; Rebounds = 4 } ]
      Opponents = ["Lakers"; "Warriors"; "Kings"] }
