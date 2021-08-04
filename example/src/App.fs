module App

open Browser.Dom
open Fable.JQuery.Effects.Slide

let mutable isHidden = true

let slideButton = document.querySelector("#my-other-button") :?> Browser.Types.HTMLButtonElement
slideButton.onclick <- fun _ ->
    if isHidden then
        jq.SlideDown("#slide-me")
    else
        jq.SlideUp("#slide-me")
    isHidden <- not isHidden
