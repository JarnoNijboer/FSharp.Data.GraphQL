﻿namespace System
open System.Reflection
open System.Runtime.CompilerServices

[<assembly: AssemblyTitleAttribute("FSharp.Data.GraphQL.Shared")>]
[<assembly: AssemblyProductAttribute("FSharp.Data.GraphQL")>]
[<assembly: AssemblyDescriptionAttribute("FSharp implementation of Facebook GraphQL query language")>]
[<assembly: AssemblyVersionAttribute("0.0.3")>]
[<assembly: AssemblyFileVersionAttribute("0.0.3")>]
[<assembly: InternalsVisibleToAttribute("FSharp.Data.GraphQL.Server")>]
[<assembly: InternalsVisibleToAttribute("FSharp.Data.GraphQL.Client")>]
[<assembly: InternalsVisibleToAttribute("FSharp.Data.GraphQL.Tests")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.3"
    let [<Literal>] InformationalVersion = "0.0.3"
