namespace FSTodoList

open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting;
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting
open FSTodoList.EF
open Microsoft.EntityFrameworkCore
open Newtonsoft.Json
open Newtonsoft.Json.Serialization

type Startup(configuration: IConfiguration) =
    member _.Configuration = configuration

    // This method gets called by the runtime. Use this method to add services to the container.
    member _.ConfigureServices(services: IServiceCollection) =
        let serverVersion = Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.29-mysql")

        // Add framework services.
        services.AddControllers()
            .AddNewtonsoftJson(fun options -> 
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore |> ignore
                options.SerializerSettings.ContractResolver = (CamelCasePropertyNamesContractResolver() :> IContractResolver) |> ignore
            ) |> ignore
        services.AddDbContext<AccuPrecisionDbContext>(
            fun options ->
                options.UseMySql("server=ap_mysql;user id=root;password=password;database=accu_precision_db;convert zero datetime=True;Convert Zero Datetime=True;",
                    serverVersion) |> ignore
        ) |> ignore
    

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    member _.Configure(app: IApplicationBuilder, env: IWebHostEnvironment) =
        if (env.IsDevelopment()) then
            app.UseDeveloperExceptionPage() |> ignore
        app.UseHttpsRedirection()
           .UseRouting()
           .UseAuthorization()
           .UseEndpoints(fun endpoints ->
                endpoints.MapControllers() |> ignore
            ) |> ignore
