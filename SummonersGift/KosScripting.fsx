﻿#r @"..\packages\FSharp.Data.2.1.0\lib\net40\FSharp.Data.dll"
#r @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\System.dll"
#r @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\System.Core.dll"
#r @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\System.Numerics.dll"
#r @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\System.Web.dll"
#r @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\System.Xml.Linq.dll"
#r @"C:\Users\Andrew\Documents\GitHub\SummonersGift\packages\Newtonsoft.Json.6.0.6\lib\net45\Newtonsoft.Json.dll"

#load "ApiKeys.fs"
#load "FetchFunctions.fs"

let kf = SummonersGift.FetchFunctions.getSummoner "euw" [|"Proheme";"Khaos Force"|]
kf.["proheme"]



