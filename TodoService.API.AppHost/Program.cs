var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.TodoService_API>("todoservice-api");

builder.Build().Run();
