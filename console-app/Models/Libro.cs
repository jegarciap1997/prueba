namespace Models;

/*

    Correcion de nombramiento de atributos

*/

public class Libro
{
    public Guid LibroId { get; set; }
    public string? Nombre { get; set; }
    public DateTime AnioPublicacion { get; set; }
    public Guid AutorId { get; set; }

    public AutorLibro Autor { get; set; }
}
