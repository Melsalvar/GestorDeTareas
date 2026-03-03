internal class Tarea
{
    private string? titulo;
    private string? descripcion;
    private bool completado;

    public Tarea(string? titulo, string? descripcion)
    {
        this.titulo = titulo;
        this.descripcion = descripcion;
        this.completado = false;
    }
}