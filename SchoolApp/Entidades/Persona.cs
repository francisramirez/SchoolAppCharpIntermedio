

namespace SchoolApp.Entidades
{
    public abstract class Persona
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public abstract string ObtenerInformacion();  
        
        public virtual string ObtenerInformacionCompleta()
        {
            return $"Nombre: {Nombre}, Apellido: {Apellido}, Correo: {Correo}, Telefono: {Telefono}, Direccion: {Direccion}";
        }
    }
}
