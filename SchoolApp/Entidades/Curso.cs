 

namespace SchoolApp.Entidades
{
    public abstract class Curso
    {
        public List<Docente> Docentes { get; set; }
        public string Tipo { get; set; }


        public abstract void Inscripbirse(Estudiante estudiante);
        

        public void Save()
        {
            Console.WriteLine("Iniciando proceso de guardado");
            //logica de guardado



            Console.WriteLine("Fin proceso de guardado");
        }
    }
