namespace inventariosmvc.Models;

public class ProductoListado
{
    public string Descripcion { get; set; } = "";
    public string Marca { get; set; } = "";
    public decimal Precio { get; set; }
    public int Existencia { get; set; }
    public DateTime FechaRegistro { get; set; }
}