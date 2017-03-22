namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FSharp.Data.GraphQL.Client")>]
[<assembly: AssemblyProductAttribute("FSharp.Data.GraphQL")>]
[<assembly: AssemblyDescriptionAttribute("FSharp implementation of Facebook GraphQL query language")>]
[<assembly: AssemblyVersionAttribute("0.0.3")>]
[<assembly: AssemblyFileVersionAttribute("0.0.3")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.3"
    let [<Literal>] InformationalVersion = "0.0.3"
