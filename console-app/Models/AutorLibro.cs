namespace Models;

/*

    Correcion de nombramiento de atributos

*/

public class AutorLibro
{
    public Guid AutorId { get; set; }
    public string? Nombre { get; set; }
    public Guid CiudadId { get; set; }

    public Ciudades Ciudad { get; set; }
    public ICollection<Libro> Libros { get; set; } = new List<Libro>();
}