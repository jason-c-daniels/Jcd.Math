# Jcd.Math

## THIS IS A WORK IN PROGRESS. IT IS NOT YET COMPLETE. NO NUGET PACKAGE EXISTS YET!

A *.NET Standard 2.0* library that provides some rudimentary mathematics helpers.

While I'm no expert in mathematics, .NET is sorely missing some rudimentary types
causing programmers to continuously reinvent the wheel.

So, this library offers some efficient data types and algorithms to help with some 
common use cases I've encountered. *(I started it when I found that none of the 
Interval implementations I could find were neither "minimally complete" nor memory 
efficient if they even handled all the bounding edge cases with interval comparisons.)*

**On memory efficiency:** One common trend I saw was that people were implementing what 
is in all rights an immutable value type (read struct!) as a mutable class. This incurs 
both unneeded memory pressure on the GC and a slight performance hit even outside of the 
GC concerns, as classes take longer to initialize since they're heap memory. When avoiding
boxing allocations structs are strictly stack memory, therefore faster.

**On optimizing for memory efficiency**: While premature optimization is a serious issue 
in our industry. Selecting readonly structs for items such as Intervals we both eliminate 
the unwanted GC pressure while also ensuring immutability, reducing the chances of 
programmer error for consumers. Immutability and stack storage are usually our friends 
when it comes to performant data types and algorithms.

**Known "issues" with structs**: When using non-.NET6+ default values for structs are
essentially zeroed out memory (null for reference types, compiler defined `default` 
for struct types. For integer types this literally translates to 0). So never use an 
uninitialized value. Your compiler and IDE can help you find an eliminate these 
scenarios.

To aid in the cause of writing minimal special case code, I've created most structs to 
a valid zeroed state. While the default state may not be what you want, the code will 
still function as designed. For those cases where it's not possible to do so,
I've provided an IsValid flag, and used it in the relevant locations. Types will detect
and throw an exception if they're being used in an invalid state.

## Before you begin coding: LEAVE HERE UNTIL FINISHED.

1. Setup the [AppVeyor project](https://ci.appveyor.com/projects) and replace TODO_YOUR_PROJECT_SLUG_HERE, in this file, with the project slug.
  * The project slug can be found in the URL of the project after creation or on the Settings/General tab.
  * On the Settings/General tab
    - Set your build version (typically to 0.0.{build} for a new project.)
    - Turn on AssemblyInfo patching.
    - Turn on .NET Core project files patching.
  * On the Settings/Environment tab, select the Ubuntu build worker image to ensure unit tests run on Linux.
  * On the Settings/Build tab
    - Set "Configuration" to "Release"
    - Turn on "Package NuGet projects."
  * On the Settings/Deployment tab
    - Set up a NuGet provider pointed to MyGet: https://www.myget.org/F/jason-c-daniels/api/v2/package
    - Set your API key/personal access token. You can get it from your [MyGet Access Tokens](https://www.myget.org/profile/Me#!/AccessTokens)
    - Turn on "Deploy from branch" with the branch set to "main"
2. Setup the [codefactor.io project](https://www.codefactor.io/dashboard).
  * Click the "+ Add" button on the [dashboard](https://www.codefactor.io/dashboard)
  * Select Jcd.Math from the list.
  * Click "Import" at the bottom of the screen.
3. Review various generated non-code files to ensure you have customized the content to this project's
   needs. *The list is relative to the repository root directory.*
  * [.github/ISSUE_TEMPLATE/bug_report.md](.github/ISSUE_TEMPLATE/bug_report.md)
  * [.github/ISSUE_TEMPLATE/feature_request.md](.github/ISSUE_TEMPLATE/feature_request.md)
  * [.github/ISSUE_TEMPLATE/technical_task.md](.github/ISSUE_TEMPLATE/technical_task.md)
  * [.github/ISSUE_TEMPLATE/user_story.md](.github/ISSUE_TEMPLATE/user_story.md)
  * [.github/FUNDING.yml](.github/FUNDING.yml) - Remove this if you don't want to solicit funding for your works. (Currently only has Patreon and Ko-Fi entries)
  * [LICENSE](LICENSE)
  * [CODE_OF_CONDUCT.md](CODE_OF_CONDUCT.md)
  * [CONTRIBUTING.md](CONTRIBUTING.md)
  * [PULL_REQUEST_TEMPLATE.md](PULL_REQUEST_TEMPLATE.md)
4. Delete this section of this file and replace it with something meaningful.

## Examples

```csharp
// snippets of code from the examples project goes here.
// TODO: I'll be adding examples here as a teaser.
```

## Badges
[![GitHub](https://img.shields.io/github/license/jason-c-daniels/Jcd.Math)](https://github.com/jason-c-daniels/Jcd.Math/blob/main/LICENSE)
[![Build status](https://ci.appveyor.com/api/projects/status/sbmfvmr1jmcf1pic?svg=true)](https://ci.appveyor.com/project/jason-c-daniels/TODO_YOUR_PROJECT_SLUG_HERE)
[![CodeFactor Grade](https://img.shields.io/codefactor/grade/github/jason-c-daniels/Jcd.Math)](https://www.codefactor.io/repository/github/jason-c-daniels/Jcd.Math)

[![MyGet](https://img.shields.io/myget/jason-c-daniels/v/Jcd.Math?logo=nuget)](https://www.myget.org/feed/jason-c-daniels/package/nuget/Jcd.Math)
[![Nuget](https://img.shields.io/nuget/v/Jcd.Math?logo=nuget)](https://www.nuget.org/packages/Jcd.Math)

[![API Docs](https://img.shields.io/badge/Read-The%20API%20Documentation-blue?style=for-the-badge)](https://github.com/jason-c-daniels/Jcd.Math/blob/main/docs/Jcd.Math.md)