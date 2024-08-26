namespace Models;

/*

    Correcion de nombramiento de atributos

*/

public class Ciudades
{
    public Guid CiudadId { get; set; }
    public string? Nombre { get; set; }

    public ICollection<AutorLibro> Autores { get; set; } = new List<AutorLibro>();
}
