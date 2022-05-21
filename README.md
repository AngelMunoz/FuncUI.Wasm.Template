# Avalonia.FuncUI + WebAssembly

This is a template repository that can get you started with Avalonia.FuncUI and WebAssembly

If you don't know much about web but you do know a little bit of desktop development this is one of the best choices you have to dive into the frontend landscape without leaving behind your knowledge.

## Run

- `dotnet run` or `dotnet watch run`

## Build for production

- `dotnet publish -c Release -o dist`

files will be available at `dist/wwwroot`

### Notes

> Avalonia is a Desktop/Cross-Platform framework why only web here?

In this case I want to isolate the web bits specifically so it's easier to experiment without having to deal with desktop/ios/android specific setups or "distractions if can name them that way. I will eventually'ish add the complete and official skeleton from Avalonia so... there's that as well.

> Can we use CSS to style this?

The avalonia controls are inside a canvas so you need to use Avalonia's XML standard way to style your websites

> How heavy is this?

WASM, Blazor and Avalonia are still optimizing for better size in this case the initial load of the website is around `22MB` (which is extremely huge for a website), subsequent reloads are around `360kb` which can still be quite some specially for users with bad internet signal, if you have concerns about this, you should not be looking into WASM at all just yet, perhaps in a couple of years (at the time of writing) it might be feasible, but today is not the day.
