﻿// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let name6 = from "Meshko Ivan!" // Call the function
    printfn "Hello world %s" name6
    0 // return an integer exit code
