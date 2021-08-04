# Fable.JQuery.Effects.Slide

This repository shows how to wire up JQuery's slide effects in Fable.

Run the example by navigating to `./example` and running `yarn start`.

### Building

Make sure the following **requirements** are installed in your system:

* [dotnet SDK](https://www.microsoft.com/net/download/core) 2.0 or higher
* [node.js](https://nodejs.org) 6.11 or higher
* [yarn](https://yarnpkg.com)
* [Mono](http://www.mono-project.com/) if you're on Linux or macOS.

Then you just need to type `./build.cmd` or `./build.sh`

### Release

In order to push your package to [nuget.org][https://nuget.org] you need to add your API keys to `NUGET_KEY` environmental variable.
You can create a key [here](https://www.nuget.org/account/ApiKeys).

- Update RELEASE_NOTES with a new version, data and release notes [ReleaseNotesHelper](http://fake.build/apidocs/fake-releasenoteshelper.html).
Ex:

```
#### 0.2.0 - 30.04.2017
* FEATURE: Does cool stuff!
* BUGFIX: Fixes that silly oversight
```


- You can then use the Release target. This will:
  - make a commit bumping the version: Bump version to 0.2.0
  - publish the package to nuget
  - push a git tag

`./build.sh Release`



MacOS/Linux | Windows
--- | ---
[![Travis Badge](https://travis-ci.org/MyGithubUsername/Fable.Fable.JQuery.Effects.Slide.svg?branch=master)](https://travis-ci.org/MyGithubUsername/Fable.Fable.JQuery.Effects.Slide) | [![Build status](https://ci.appveyor.com/api/projects/status/github/MyGithubUsername/Fable.Fable.JQuery.Effects.Slide?svg=true)](https://ci.appveyor.com/project/MyGithubUsername/Fable.Fable.JQuery.Effects.Slide)
[![Build History](https://buildstats.info/travisci/chart/MyGithubUsername/Fable.Fable.JQuery.Effects.Slide)](https://travis-ci.org/MyGithubUsername/Fable.Fable.JQuery.Effects.Slide/builds) | [![Build History](https://buildstats.info/appveyor/chart/MyGithubUsername/Fable.Fable.JQuery.Effects.Slide)](https://ci.appveyor.com/project/MyGithubUsername/Fable.Fable.JQuery.Effects.Slide)


## Nuget

Stable | Prerelease
--- | ---
[![NuGet Badge](https://buildstats.info/nuget/Fable.Fable.JQuery.Effects.Slide)](https://www.nuget.org/packages/Fable.Fable.JQuery.Effects.Slide/) | [![NuGet Badge](https://buildstats.info/nuget/Fable.Fable.JQuery.Effects.Slide?includePreReleases=true)](https://www.nuget.org/packages/Fable.Fable.JQuery.Effects.Slide/)



## A note about Fable Libraries vs Fable Bindings

There are two kinds of Fable packages:

- **JS Bindings**: These don't contain any actual code, only signatures and attributes normally generated by [ts2fable](https://www.npmjs.com/package/ts2fable). They're just used to provide a type-safe to interact with a JS library from Fable.
- **Libraries**: These contain F# code that will be compiled to JS by Fable when being referenced by a consumer project.

The distinction is important because Fable can read metadata from .dll assemblies (like signatures and attributes) but not executable code, for that it needs the **F# sources**. For JS bindings _without actual code_ you don't need to worry as they can be distributed as any other Nuget package. However, Fable libraries need a couple of extra steps:

- First, the package must contain a folder named **fable** with the F# sources (and if necessary other files like JS scripts).
- The `fable` folder must contain an **.fsproj file with the same name as the Nuget package**.

This is not difficult to do and usually only requires adding a tag to your project file ([example](https://github.com/fable-compiler/fable-react-native/blob/6a7cc0e5074b985ef94e49a631cb8285eb9950c8/src/Fable.React.Native.fsproj#L32-L34)), but you need to make sure all the sources get into the package with the proper directory structure. Also, take into account Fable will just make a simple XML parsing to extract the source files from the .fsproj, so you should avoid MSBuild conditionals, etc.

Because Fable will compile your sources you must be careful with compiler directives too (like `#if MY_SYMBOL`, etc). Though you can use this to your advantage and do some logging in debug mode (`#if DEBUG`). And remember also that Fable will always define the `FABLE_COMPILER` symbol when compiling to JS.
