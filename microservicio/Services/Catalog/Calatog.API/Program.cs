var builder = WebApplication.CreateBuilder(args);



// Servicios del contenedor
var app = builder.Build();



// Configuración del HTTP pipeline.
app.Run();


