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

### Crear un proyecto

    dotnet new webapi -n "CarteleraCine.Api" --use-controllers 

### Agregar paquetes

    dotnet add package MongoDb.Driver 
    dotnet add package MongoDb.EntityFrameworkCore 

### Configurar una colección en el DatabaseContext

    modelBuilder.Entity<Pelicula>().ToCollection("peliculas");
