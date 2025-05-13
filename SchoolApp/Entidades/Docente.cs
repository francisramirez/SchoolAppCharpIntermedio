

namespace SchoolApp.Entidades
{
    public sealed class Docente : Empleado
    {
        public string? Materia { get; set; }
        public int AniosExperiencia { get; set; }

        public List<Curso>? Cursos { get; set; } = new List<Curso>();
        public override string ObtenerInformacion()
        {
            // el comportamiento exclusivo para obtener los datos de un docente
            throw new NotImplementedException();
        }
    }
     
}
