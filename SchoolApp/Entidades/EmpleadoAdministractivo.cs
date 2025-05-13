

namespace SchoolApp.Entidades
{
    public class EmpleadoAdministractivo : Empleado
    {
        public string? Departamento { get; set; }
        public double Sueldo { get; set; }
      
        /// <summary>
        /// Método que obtiene la información del empleado administrativo.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override string ObtenerInformacion()
        {
            // el comportamiento exclusivo para obtener los datos de un empleado administrativo
            throw new NotImplementedException();
        }
    }
   
}
