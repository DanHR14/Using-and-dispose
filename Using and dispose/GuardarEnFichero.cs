using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_and_dispose
{
    class GuardarEnFichero
    {
        public static void Guardar(Alumno alu)
        {

            using (StreamWriter file = new StreamWriter("Alumnos.txt"))
            {
                file.WriteLine("Alumno {0} que vive en {1}\n", alu.Nombre, alu.Ciudad);
            }
            
            
            
        }
    }
}
