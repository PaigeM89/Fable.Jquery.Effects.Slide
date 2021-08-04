module Fable.JQuery.Effects.Slide

open Fable.Core

(************************************************)
(*     You should remove the next lines and     *)
(*    start writing your library in this file   *)
(************************************************)

[<Emit("$0 + $1")>]
let add (x: int) (y: int) = jsNative

[<Emit("$0 - $1")>]
let subtract x y = x - y 


open Fable.Core.JsInterop
open Fable.Import

module Functions =

  type IJquery = interface end
  let [<Global>] jquery : IJquery = jsNative

  [<Emit("window['$']($0)")>]
  let select (selector) : IJquery = jsNative

  [<Emit("$($0)")>]
  let ready (handler: unit -> unit) : unit = jsNative

  [<Emit("$($0).slideDown()")>]
  let slideDown selector : unit = jsNative

  [<Emit("$($0).slideUp()")>]
  let slideUp selector : unit = jsNative

type JQueryClass(elem) =
  // let e = elem
  member x.Select(selector) = Functions.select(selector)
  member x.SlideDown(selector) = Functions.slideDown(selector)
  member x.SlideUp(selector) = Functions.slideUp(selector)

// let jq = importDefault<JQueryClass> "jquery"
let jq = importDefault<JQueryClass> "jquery"
let import() = importDefault<JQueryClass> "jquery"

// [<ImportMember("./Slide.js")>]
// let select : string -> JQueryClass = jsNative


// [<Emit("$1.SlideDown()")>]
// let slideDown selector : unit = jsNative

// let jq = importDefault<Jquery> "jquery"
// let select selector = jq $ (selector)

// [<ImportMember("slideDown")>]
// let slideDown () = jsNative

// let slideDown2 (selected) =
//   printfn "selected is %A" selected
//   selected?slideDown()