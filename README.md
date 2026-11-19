### Ejemplo de Documento MongoDb

    {
      Titulo: "",
      Duracion: 0,
      Genero: "",
      Clasificacion: "",
      Direccion: "",
      Reparto: [
    	  ""
      ],
      Sinopsis: "",
      UrlPortada: ""
    }

### Sitio de películas
<a href="https://www.themoviedb.org/" target="_blank">The Movie Database</a>

### Crear un proyecto

    dotnet new webapi -n "CarteleraCine.Api" --use-controllers 

### Agregar paquetes

    dotnet add package MongoDb.Driver 
    dotnet add package MongoDb.EntityFrameworkCore 

### Configurar una colección en el DatabaseContext

    modelBuilder.Entity<Pelicula>().ToCollection("peliculas");

### Configurar Program.cs
Antes de builder.Build
```
builder.Services.Configure<JsonOptions>(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);
builder.Services.AddCors(cors => cors.AddDefaultPolicy(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));
builder.Services.ConfigureMongoDb(builder.Configuration);
builder.Services.ConfigureRepositories();
```
Después de builder.Build
```
app.UseCors();
```
