var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Toki_WebUI>("toki-webui");

builder.AddProject<Projects.Toki_Api>("toki-api");

builder.Build().Run();
