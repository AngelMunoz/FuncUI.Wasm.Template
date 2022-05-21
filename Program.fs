#nowarn "0020"

open Avalonia.Web.Blazor
open Bolero
open Bolero.Html
open Microsoft.AspNetCore.Components.WebAssembly.Hosting
open Avalonia.ReactiveUI
open Trax

type MainView() =
    inherit Component()

    override this.OnParametersSet() =
        base.OnParametersSet()

        WebAppBuilder
            .Configure<App>()
            .UseReactiveUI()
            .SetupWithSingleViewLifetime()

        ()

    override this.Render() = comp<AvaloniaView> { attr.empty () }

let builder = WebAssemblyHostBuilder.CreateDefault([||])
builder.RootComponents.Add<MainView>("#app")
builder.Build().RunAsync()
