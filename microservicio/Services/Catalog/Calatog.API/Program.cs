var builder = WebApplication.CreateBuilder(args);



// Servicios del contenedor
var app = builder.Build();



// Configuraci�n del HTTP pipeline.
app.Run();


