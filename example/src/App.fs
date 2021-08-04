module App

open Browser.Dom

// // Mutable variable to count the number of times we clicked the button
// let mutable count = 0

// // Get a reference to our button and cast the Element to an HTMLButtonElement
// let myButton = document.querySelector(".my-button") :?> Browser.Types.HTMLButtonElement

// // Register our listener
// myButton.onclick <- fun _ ->
//     count <- count + 1
//     myButton.innerText <- sprintf "You clicked: %i time(s)" count

open Fable.JQuery.Effects.Slide

// let added = add 10 20

// printfn "added: %i" added

// let button = select ".my-button"
// printfn "button is %A" button

// let jquery = import()
let button2 = jq.Select(".my-button")
printfn "button2 is %A" button2

let mutable isHidden = true

let slideButton = document.querySelector("#my-other-button") :?> Browser.Types.HTMLButtonElement
slideButton.onclick <- fun _ ->
    printfn "sliding element"
    if isHidden then
        jq.SlideDown("#slide-me")
    else
        jq.SlideUp("#slide-me")
    isHidden <- not isHidden
    printfn "element should have did the slide"