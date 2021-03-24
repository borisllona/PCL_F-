module Slides

open System
open System.IO

let x:int64 = 2048L
//32788290
//34108209 bytes (30.2 MB
let sizeOfFolder folder =
    let fullSum =
        Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories)
        |> Array.map (fun (file: string) -> new FileInfo(file))
        |> Array.map (fun (info: FileInfo) -> info.Length)
        |> Array.sum
    fullSum / 1024L / 1024L