namespace CarteleraCine.Api.Database.Entities;

public class Pelicula : Document
{
    public string Titulo { get; set; } = string.Empty;
    public string Genero { get; set; } = string.Empty;
    public string Clasificacion { get; set; } = string.Empty;
    public string Direccion { get; set; } = string.Empty;
    public string Sinopsis { get; set; } = string.Empty;
    public string UrlPortada { get; set; } = string.Empty;
    public int Duracion { get; set; }
    public List<string> Reparto = new List<string>();
    
}