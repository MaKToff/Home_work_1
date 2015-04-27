﻿(*
Homework 8 (20.04.2015)
Tests for calculator

Author: Mikhail Kita, group 171
*)

module CalcTests

open NUnit.Framework
open Calc

[<TestCase ("5 !", Result = "120")>]
[<TestCase ("sin 0", Result = "0")>]
[<TestCase ("cos 0", Result = "1")>]
[<TestCase ("54 / 6", Result = "9")>]
[<TestCase ("sqrt 64", Result = "8")>]
[<TestCase ("lg 1000", Result = "3")>]
[<TestCase ("5 + (-5)", Result = "0")>]
[<TestCase ("555 % 10", Result = "5")>]
[<TestCase ("2 + 2 * 2", Result = "6")>]
[<TestCase ("3 ^ 1 ^ 2", Result = "3")>]
[<TestCase ("sqrt -1", Result = "NaN")>]
[<TestCase ("2 ^ (-1)", Result = "0.5")>]
[<TestCase ("1 - 101", Result = "-100")>]
[<TestCase ("1 - 2 - 3", Result = "-4")>]
[<TestCase ("123456789 ^ 0", Result = "1")>]
[<TestCase ("((1 + 2) * 3) ^ 4", Result = "6561")>]
[<TestCase ("3 + 4 * 2 / (1 - 5) ^ 2", Result = "3.5")>]
let ``Test for calculator`` (expression : string) =
    compute expression