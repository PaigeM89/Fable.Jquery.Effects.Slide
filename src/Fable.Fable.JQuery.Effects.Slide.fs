module Fable.JQuery.Effects.Slide

open Fable.Core
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
  member x.Select(selector) = Functions.select(selector)
  member x.SlideDown(selector) = Functions.slideDown(selector)
  member x.SlideUp(selector) = Functions.slideUp(selector)

let jq = importDefault<JQueryClass> "jquery"
let import() = importDefault<JQueryClass> "jquery"
