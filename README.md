# Cake.EntityFramework6
A set of Cake aliases for Entity Framework 6.3 or above (not .NET Core) code-first migration using the ef6.exe command line interface (cli).

You can easily reference Cake.Json directly in your build script via a cake addin:

```csharp
#tool "nuget:?package=EntityFramework&version=6.3.0"
#addin nuget:?package=Cake.EntityFramework6
```

NOTE: It's very important at this point in time to specify the EntityFramework package and the version _6.3.0_ for it.

[![License](http://img.shields.io/:license-mit-blue.svg)](http://cake-contrib.mit-license.org)

## Information

|                |                                             Stable                                              |                                                                     Pre-release                                                                      |
| :------------: | :---------------------------------------------------------------------------------------------: | :--------------------------------------------------------------------------------------------------------------------------------------------------: |
| GitHub Release |                                                -                                                | [![GitHub release](https://img.shields.io/github/release/cake-contrib/Cake.EntityFramework6.svg)](https://github.com/cake-contrib/Cake.EntityFramework6/releases/latest) |
|     NuGet      | [![NuGet](https://img.shields.io/nuget/v/Cake.EntityFramework6.svg)](https://www.nuget.org/packages/Cake.EntityFramework6) |                      [![NuGet](https://img.shields.io/nuget/vpre/Cake.EntityFramework6.svg)](https://www.nuget.org/packages/Cake.EntityFramework6)                       |

## Build Status

|                                                                             Develop                                                                             |                                                                                     Master                                                                                     |
| :-------------------------------------------------------------------------------------------------------------------------------------------------------------: | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
| [![Build status](https://ci.appveyor.com/api/projects/status//branch/develop?svg=true)](https://ci.appveyor.com/project/cakecontrib/cake-entityframework6/branch/develop) | [![Build status](https://ci.appveyor.com/api/projects/status/oqn617679k8fy2q6/branch/develop?svg=true)](https://ci.appveyor.com/project/cakecontrib/cake-entityframework6/branch/master) |

## Code Coverage

[![Coverage Status](https://coveralls.io/repos/github/cake-contrib/Cake.EntityFramework6/badge.svg?branch=develop)](https://coveralls.io/github/cake-contrib/Cake.EntityFramework6?branch=develop)

## Quick Links

- [Documentation](https://cakebuild.net/dsl/entityframework6/)

## Chat Room

Come join in the conversation about Cake.EntityFramework6 in our Gitter Chat Room

[![Join the chat at https://gitter.im/cake-contrib/Lobby](https://badges.gitter.im/cake-contrib/Lobby.svg)](https://gitter.im/cake-contrib/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
