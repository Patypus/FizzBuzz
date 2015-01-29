open System
 
let usageMessage = "Please enter a number as the only parameter for the program. The fizz buzz to that sequences will then be printed."
let fizz = "fizz"
let buzz = "buzz"
 
let GetMessageForNumber number =
    match number with
    | x when x % 3 = 0  && x % 5 = 0 -> fizz + buzz
    | x when x % 3 = 0 -> fizz
    | x when x % 5 = 0 -> buzz
    | _ -> number.ToString()
 
/// <summary>Recursive method which produces fizz buzz output for count parameter then increments it before recursing to itself
/// with the increased count until the count is equal to total 
/// </summary>
/// <param name="count">Next number to evaluate for fizz buzz</param>
/// <param name="total">Top number to fizz buzz to</param>
/// <returns>unit</returns>
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