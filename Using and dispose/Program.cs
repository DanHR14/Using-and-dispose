using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_and_dispose
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alu = new Alumno();
            
            alu.getData();
            alu.mostrarAlumno();
            GuardarEnFichero.Guardar(alu);
            alu.Dispose();
        }
    }
}
