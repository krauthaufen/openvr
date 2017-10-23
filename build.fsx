#load @"paket-files/build/aardvark-platform/aardvark.fake/DefaultSetup.fsx"

open Fake
open System
open System.IO
open System.Diagnostics
open Aardvark.Fake
open Fake.CscHelper

do Environment.CurrentDirectory <- __SOURCE_DIRECTORY__

do DefaultSetup.install [ "src\\OpenVR.sln" ]


entry()