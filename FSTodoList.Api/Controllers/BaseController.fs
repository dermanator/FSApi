namespace FSTodoList.Controllers

open System.Linq
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open FSTodoList.EF
open Microsoft.EntityFrameworkCore;
open FSTodoList.EF.Models
open System

[<ApiController>]
type BaseController () = 
    inherit ControllerBase()

    member _.HandleResult(result: Result<_, string>) =
        match result with
            | Ok data -> base.Ok(data) :> IActionResult
            | Error e -> base.StatusCode(500) :> IActionResult

