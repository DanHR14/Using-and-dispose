using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_and_dispose
{
    class Alumno : IDisposable
    {
        public String Nombre { get; set; }
        public String Ciudad { get; set; }

        public void getData()
        {
            Console.WriteLine("Introduce Nombre ");
            this.Nombre = Console.ReadLine();
            Console.WriteLine("Introduce Ciudad ");
            this.Ciudad = Console.ReadLine();
        }

        public void mostrarAlumno()
        {
            StringBuilder sb = new StringBuilder("Los datos del alumno son: \n ");
            sb.AppendFormat("Nombre: {0}  Ciudad: {1} ", this.Nombre, this.Ciudad);
            Console.WriteLine(sb.ToString());
            Console.Read();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
