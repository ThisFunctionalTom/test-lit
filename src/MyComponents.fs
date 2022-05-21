module MyComponents

open Lit
open Fable.Core.JsInterop

importSideEffects "../main.css"

let register () = ()

[<LitElement("my-button")>]
let MyButton() =
    let _, props = LitElement.init(fun init -> ())
    html $"""<button class="mx-4"><slot class="bg-purple-800 rounded border-2"></slot></button>"""
