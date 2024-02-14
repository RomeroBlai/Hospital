using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Medico: Persona
    {
        String especialidad;
        
        Int32 idMedico;

        public String Especialidad { get { return especialidad; } set { especialidad = value;} }

        public Int32 IdMedico { get { return idMedico; } set { idMedico = value; } }

        public Medico(string especialidad, int telefono, int edad, string nombre, string sexo, int idMedico): base(telefono, edad, nombre, sexo)
        {
            
            this.especialidad = especialidad; 
            this.idMedico = idMedico;
          
        }

        public override string ToString()
        {
            base.ToString();
            Console.WriteLine($"   -ID Medico: { this.IdMedico} \n"+
                              $"   -Especialidad: { this.Especialidad} \n");         

            return ""; 
        }
    }
}
