using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Persona : Hospital
    {
        long telefono;
        Int32 edad;
        String sexo, nombre;
        public long Telefono { get { return telefono; } set { telefono = value; } }
        public Int32 Edad { get { return edad; } set { edad = value; } }
        public String Sexo { get { return sexo; } set { sexo = value; } }
        public String Nombre { get { return nombre; } set { nombre = value; } }

        public Persona(int telefono, int edad, string nombre, string sexo)
        {
            this.telefono = telefono;
            this.edad = edad;
            this.nombre = nombre;
            this.sexo = sexo;
        }

        public override string ToString()
        {
            Console.WriteLine($"-Nombre: {this.nombre}: \n"+
                              $"   -Edad: {this.edad} \n"+
                              $"   -Sexo: {this.sexo} \n"+
                              $"   -Telefono: {this.telefono}");
            return "";
        }
    }
}
