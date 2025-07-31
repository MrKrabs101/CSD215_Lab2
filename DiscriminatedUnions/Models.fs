module DiscriminatedUnions.Models

// defining restaurant cuisine options
type Cuisine =
    | Korean
    | Turkish

// defining types of movie experiences, with snack options
type MovieType =
    | Regular
    | IMAX
    | DBOX
    | RegularWithSnacks
    | IMAXWithSnacks
    | DBOXWithSnacks

// creating different activity options for the Valentine's Day evening
type Activity =
    | BoardGame                        // no cost
    | Chill                            // relaxing, no cost
    | Movie of MovieType               // watching a movie with optional snacks
    | Restaurant of Cuisine            // dinner option based on cuisine
    | LongDrive of kilometres:int * fuelRate:float // driving cost based on distance and fuel rate
