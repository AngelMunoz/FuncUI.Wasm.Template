namespace Trax

open Avalonia
open Avalonia.Controls
open Avalonia.Controls.ApplicationLifetimes
open Avalonia.Themes.Fluent
open Avalonia.FuncUI
open Avalonia.FuncUI.DSL

[<RequireQualifiedAccess>]
module View =

  let Main () =
    Component(fun ctx ->
      let count = ctx.useState 0

      let countPlusTwo = count |> State.readMap (fun n -> n + 2)

      StackPanel.create
        [
          StackPanel.spacing 8
          StackPanel.children
            [
              Button.create
                [
                  Button.content $"%i{count.Current} - %i{countPlusTwo.Current}"
                  Button.onClick (fun _ -> count.Set(count.Current + 1))
                ]
            ]
        ])

type App() =
  inherit Application()

  override this.Initialize() =
    this.Styles.Add(FluentTheme(baseUri = null, Mode = FluentThemeMode.Dark))

  override this.OnFrameworkInitializationCompleted() =
    match this.ApplicationLifetime with
    | :? ISingleViewApplicationLifetime as single -> single.MainView <- View.Main()
    | lifetime ->
      let name = nameof lifetime
      let typ = lifetime.GetType
      failwith $"{name} - {typ} is not supported for this application"
