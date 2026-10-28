namespace inventariosmvc.Models;

public class Videojuego
{
    public int Id { get; set; }
    public string Titulo { get; set; } = "";
    public string Plataforma { get; set; } = "";
    public string Genero { get; set; } = "";
    public int Stock { get; set; }
    public decimal Precio { get; set; }
}
