module App

open Fable.Core.JsInterop
open Browser
open Lit
open MyComponents

importSideEffects "../main.css"
let hmr = HMR.createToken()

MyComponents.register()

[<HookComponent>]
let App() =
    Hook.useHmr(hmr)
    let value, setValue = Hook.useState "World"

    html $"""
      <div class="content p-4 space-y-4">
        <p>Local state: <i class="text-purple-800 text-2xl border-2 rounded">Hello {value}!</i></p>
        <input
          type="text"
          class="border-2 rounded-lg"
          value={value}
          @keyup={EvVal setValue}>
        <my-button>Click me</my-button>
      </div>
    """

let el = document.getElementById("app")
App() |> Lit.render el