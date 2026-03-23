using Almostengr.FalconPiPlayer.ApiClient.Worker;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddFalconPiPlayerApiClientServices(builder.Configuration);

builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
