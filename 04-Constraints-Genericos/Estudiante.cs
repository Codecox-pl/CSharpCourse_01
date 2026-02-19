
namespace _04_Constraints_Genericos
{
    public class Estudiante : Persona, IComparable<Estudiante>
    {
        public string? Apellido { get; set; }

        public Estudiante(): this("NombrePorDefecto","AepllidoPorDefecto") { }

        public Estudiante(string? nombre, string? apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }

        public int CompareTo(Estudiante? miEstudiante)
        {

            if (miEstudiante?.Apellido == this.Apellido)
            {

                return this.Nombre!.CompareTo(miEstudiante?.Nombre);

            }
            return this.Apellido!.CompareTo(miEstudiante?.Apellido);

        }


    }

    public record NombreCompleto(string Nombre, string Apellido);
}
