open System
 
let usageMessage = "Please enter a number as the only parameter for the program. The fizz buzz to that sequences will then be printed."
let fizz = "fizz"
let buzz = "buzz"
 
let GetMessageForNumber number =
    match number with
    | numerator when numerator % 3 = 0  && numerator % 5 = 0 -> fizz + buzz
    | numerator when numerator % 3 = 0 -> fizz
    | numerator when numerator % 5 = 0 -> buzz
    | _ -> number.ToString()
 
let rec FizzBuzzToTotal count total = 
    printfn "%s" (GetMessageForNumber count)
    let incrementedcount = count + 1;
    if incrementedcount <= total then FizzBuzzToTotal incrementedcount total

[<EntryPoint>]
let main argv = 
    match argv.Length with
    | 1 -> FizzBuzzToTotal 1 (Int32.Parse(argv.[0]))
    | _ -> printfn "%s" usageMessage
    0