[Прочитать эту страницу по-русски](https://github.com/vazhka-dolya/Shapeshift/blob/main/README.ru.md) | **Read this page in English**

# Shapeshift
**Shapeshift** is a very experimental [*Mario 64 Movie Maker 3*](https://github.com/projectcomet64/M64MM) add-on for changing Mario's model in real time.

# Usage
In its current state, the add-on only works with models that are stored at address `F0860`, which are usually older models, such as [Enkal's Peach model](https://www.youtube.com/watch?v=itgn6dsmcNA). This means that [*Fast64*](https://github.com/Fast-64/fast64) models are, unfortunately, currently not supported.

It's very much recommended that you use an extended ROM with this add-on. You can use [*SM64 ROM Manager*](https://pilzinsel64.de/sm64-rom-manager/) to extend a ROM.

Some tips/notes:
- Since the models get loaded at a different address, using something like [*katarakta PT4*](https://github.com/vazhka-dolya/katarakta/releases/tag/vpt4) or the upcoming *kataraktaCS* add-on won't work by default with *Shapeshift*. You can, however, change a model's textures before extracting it and the model will still have those textures when it gets loaded.
- You can use a ROM with a *Fast64* model and still use *Shapeshift* to replace this model with something else, allowing you to use a *Fast64* model together with other models in some cases.
- After loading a model on top of Mario, you can use the *Load Back Mario* button to load back Mario's model. If you're loading a model on top of a *Fast64* model, then use the *Load Back F64 Model* button.
- If you're extracting Mario's model, then you have to use an extended ROM for that.
- Going to another stage will reset the model back to what it originally was.
- - There is a way to prevent this from happening, which might get added in a future update.

# Installing and using
1. Make sure you have the [latest version](https://github.com/projectcomet64/M64MM/releases/latest) of *M64MM3* installed.
2. Download the [latest version](https://github.com/vazhka-dolya/Shapeshift/releases/latest) of the add-on. It will be in an archive.
3. Extract the downloaded archive's contents[^1] into the root folder[^2] of *M64MM3*. If it prompts you to replace files, then do it.
4. That's all.

# Building prerequisites
<details>
  <summary>Click here to view</summary>
  
- *Visual Studio 2022*.
- *M64MM3*'s repository in a folder called `M64MM` outside of where this repository is.
  - Example: if the `.sln` for *Shapeshift* is in `C:/projects/Shapeshift/Shapeshift.sln`, the whole *M64MM3* repository must be in `C:/projects/M64MM`.
- If you're on *Windows*, then, before extracting the archives, make sure to right-click the archive, open **Properties** and see if you have an **Unblock** checkbox. If you do, tick it and press **Apply**. If you don't do this and the archive(s) remain blocked, you may run into issues.
- *Depending on the circumstances*, you *may* have to do the following: go to **Menu** > **Tools** > **NuGet Package Manager** > **Package Manager Console** and enter `Install-Package HtmlRenderer.WinForms`. After that, go to **Menu** > **Project** > **Manage NuGet Packages…**, and make sure that both `HtmlRenderer.Core` and `HtmlRenderer.WinForms` are up-to-date.

</details>

# Credits
- Kaze Emanuar & Net64 — original code for extracting models (or at least I think it was them who made it).
- Warioplier — shared this code and roughly explained how to use it.

[^1]: That means *all* the contents, including the `deps` folder. If it crashes when opening the *About* window, make sure that you have `HtmlRenderer.dll` and `HtmlRenderer.WinForms.dll` in *M64MM*'s `deps` folder.
[^2]: That's the same folder where `M64MM.exe` is located.
