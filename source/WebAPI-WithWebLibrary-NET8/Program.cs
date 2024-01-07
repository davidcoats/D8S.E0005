
WebAPI_WebLibrary_NET8.Class1 a;
WebAPI_WebLibrary_FrameworkReference_NET8.Class1 b;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("hello", () => "World");

app.Run();
