

namespace SchoolApp.Entidades
{
    public class Empleado : Persona
    {
        public string? Cargo { get; set; }

        public override string ObtenerInformacion()
        {
            // el comportamiento exclusivo para obtener los datos de un empleado
            throw new NotImplementedException();
        }
    }
}
