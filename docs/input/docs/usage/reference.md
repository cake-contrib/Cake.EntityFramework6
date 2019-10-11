---
Order: 1
Title: Referencing Cake.EntityFramework6
---

You can reference Cake.EntityFramework in your build script as a cake addin:
You can easily reference Cake.Json directly in your build script via a cake addin:

```csharp
#tool "nuget:?package=EntityFramework&version=6.3.0"
#addin nuget:?package=Cake.EntityFramework6
```

NOTE: It's very important at this point in time to specify the Newtonsoft.Json package *and* the version _6.3.0_ for it.