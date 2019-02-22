# MicroBusRepro
Reproduction for an ObjectDisposed exception in Enexure.MicroBus

Pulling this repo and running `dotnet run` produces the following output:

    dbug: Carter.CarterDiagnostics[0]
          Found module HomeModule
    Hosting environment: Development
    Content root path: C:\Projects\Personal\MicrobusRepro\MicrobusRepro
    Now listening on: https://localhost:5001
    Now listening on: http://localhost:5000
    Application started. Press Ctrl+C to shut down.
    info: Microsoft.AspNetCore.Hosting.Internal.WebHost[1]
          Request starting HTTP/1.1 GET http://localhost:5000/
    dbug: HomeModule[0]
          Executing module route handler for GET /
    fail: Microsoft.AspNetCore.Server.Kestrel[13]
          Connection id "0HLKP2NFUE11V", Request id "0HLKP2NFUE11V:00000001": An unhandled exception was thrown by the application.
    System.ObjectDisposedException: Instances cannot be resolved and nested lifetimes cannot be created from this LifetimeScope as it has already been disposed.
       at Autofac.Core.Lifetime.LifetimeScope.BeginLifetimeScope(Object tag) in C:\projects\autofac\src\Autofac\Core\Lifetime\LifetimeScope.cs:line 133
       at Enexure.MicroBus.Autofac.AutofacDependencyResolver.BeginScope()
       at Enexure.MicroBus.MicroBus.RunPipelineAsync(Object message, CancellationToken cancellation)
       at HomeModule.<.ctor>b__1_0(HttpRequest req, HttpResponse res, RouteData routeData) in C:\Projects\Personal\MicrobusRepro\MicrobusRepro\CarterModule.cs:line 13
       at Carter.CarterExtensions.<>c__DisplayClass1_0.<<CreateRouteHandler>b__0>d.MoveNext() in /Users/jonathan/Projects/Carter/src/CarterExtensions.cs:line 111
    --- End of stack trace from previous location where exception was thrown ---
       at Microsoft.AspNetCore.Builder.RouterMiddleware.Invoke(HttpContext httpContext)
       at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
    info: Microsoft.AspNetCore.Hosting.Internal.WebHost[2]
          Request finished in 78.6663ms 500
