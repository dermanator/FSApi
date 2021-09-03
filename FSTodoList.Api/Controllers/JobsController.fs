namespace FSTodoList.Controllers

open System.Linq
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open FSTodoList.EF
open Microsoft.EntityFrameworkCore;
open FSTodoList.EF.Models
open FSTodoList.Controllers

[<Route("[controller]")>]
type JobsController (logger : ILogger<JobsController>,
    context: AccuPrecisionDbContext) =
    inherit BaseController()

    member this.GetJobsAsync() = 
        async {
            try
                let! jobs = context.Jobs.OrderByDescending(fun job -> job.UpdatedDate).Take(100).ToListAsync() |> Async.AwaitTask
                return Ok (jobs |> List.ofSeq |> List.map this.ConvertJobToDto )
            with 
                | ex -> logger.LogError("An unexpected error occurred", ex); return Error $"An error occurred {ex}"
        }

    member _.ConvertJobToDto(job: Job) =
        struct {|JobId = job.JobId; 
            JobNumber = job.JobNumber; 
            Description = job.Description;
            PartNumber = job.PartNumber;
            Revision = job.Revision;
        |}

    [<HttpGet>]
    member this.Get() =
        this.GetJobsAsync()
        |> Async.RunSynchronously  
        |> this.HandleResult
        