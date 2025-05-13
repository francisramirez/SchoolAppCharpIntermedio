using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Entidades
{
    public sealed class CursoOnline : Curso
    {
        public string? Url { get; set; }
        public string? Plataforma { get; set; }
        public int Duracion { get; set; } // en horas
        public override void Inscripbirse(Estudiante estudiante)
        {
            Console.WriteLine($"El estudiante {estudiante.Nombre} se ha inscrito en el curso online.");

            Console.WriteLine("Iniciando proceso de inscripcion");


          

            // la funcionalidad realizar pago //


            // logica de inscripcion a un curso db //


            // notificar al estudiante que se ha inscrito //

            Console.WriteLine("Fin proceso de inscripcion");
        }
        public override string ObtenerInformacionCompleta()
        {
            return base.ObtenerInformacionCompleta() + $", URL: {Url}, Plataforma: {Plataforma}, Duración: {Duracion} horas";
        }
    }
    {
    }
}
