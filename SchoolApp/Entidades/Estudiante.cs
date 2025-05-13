
using SchoolApp.Repositories;

namespace SchoolApp.Entidades
{
    public sealed class Estudiante : Persona
    {
        public string? Grado { get; set; }
        public double Promedio { get; set; }

        StudentRepository studentRepository;
        public Estudiante()
        {
            this.studentRepository = new StudentRepository();   
        }
        public override string ObtenerInformacion()
        {
            string datosEstudiantes = $"Nombre: {base.Nombre}, Apellido: {base.Apellido}, Grado: {Grado}, Promedio: {Promedio}";
            return datosEstudiantes;

        }

        public void Save()
        {
            Looger.Log("Iniciando proceso de guardado");

            //logica de guardado
            this.studentRepository.Save(this);

            Looger.Log("Fin proceso de guardado");
        }

        public void Update()
        {
            Console.WriteLine("Iniciando proceso de actualizacion");
            //logica de actualizacion
            this.studentRepository.Actualizar(this);

            Console.WriteLine("Fin proceso de actualizacion");
        }


        public void Delete()
        {
            Console.WriteLine("Iniciando proceso de actualizacion");
           
            //logica de actualizacion
            this.studentRepository.Delete(this);


            Console.WriteLine("Fin proceso de actualizacion");
        }

       
    }
}
