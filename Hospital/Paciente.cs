using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Paciente : Persona
    {
        String enfermedad;
        Int32 idMedico;

        public String Enfermedad { get { return enfermedad; } set { enfermedad = value; } }

        public Int32 IdMedico { get { return idMedico; } set { idMedico = value; } }

        public Paciente(string enfermedad,int telefono, int edad, string nombre, string sexo,int idMedico) : base(telefono, edad, nombre, sexo)
        {

            this.enfermedad = enfermedad;
            this.idMedico = idMedico;
        }

        public override string ToString()
        {
            base.ToString();
            Console.WriteLine(this.enfermedad);
            return "";
        }
    }
}
