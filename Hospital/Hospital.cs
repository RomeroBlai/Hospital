using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Hospital
    {
        List<Persona> personasLista;

        public List<Persona> PersonasLista { get { return personasLista; } set { personasLista = value; } }
        public Hospital()
        {

            this.personasLista = new List<Persona>();

        }
        public void AgregarMedico(int telefono, int edad, string nombre, string sexo, int idMedico, string especialidad)
        {

            List<Paciente> pacientes = new List<Paciente>();

            Medico medico = new Medico(especialidad, telefono, edad, nombre, sexo, idMedico);

            this.PersonasLista.Add(medico);

        }

        public void AgregarPaciente(int telefono, int edad, string nombre, string sexo, int idMedico, string enfermedad)
        {

            Paciente paciente = new Paciente(enfermedad, telefono, edad, nombre, sexo, idMedico);

            this.PersonasLista.Add(paciente);
        }

        public void AgregarAdministrativo(int telefono, int edad, string nombre, string sexo)
        {

            Administrativo administrativo = new Administrativo(telefono, edad, nombre, sexo);

            this.PersonasLista.Add(administrativo);

        }

        public void MostrarMedicos()
        {
            foreach (Persona persona in personasLista)
            {
                
                if (persona is Medico)
                    Console.WriteLine(persona.ToString());
            }
        }

        public void MostrarPacienteDeMedico(int codigo)
        {            
            Persona paciente = (from p in personasLista
                          where p is Paciente pa && pa.IdMedico == codigo
                          select p).FirstOrDefault();

            Console.WriteLine(paciente.ToString());
        }

        public void BorrarPaciente(string nombre)
        {          
            Persona paciente = (from p in personasLista
                                where p is Paciente pa && pa.Nombre == nombre
                                select p).FirstOrDefault();

            PersonasLista.Remove(paciente);            
        }

        public new virtual string ToString()
        {
            foreach (Persona persona in this.PersonasLista)
            {
                if (persona is Medico)
                {
                    Medico medico = (Medico)persona;
                    Console.WriteLine(medico.ToString());
                }
                else if (persona is Paciente)
                {
                    Paciente paciente = (Paciente)persona;
                    Console.WriteLine(paciente.ToString());
                }
                else
                    Console.WriteLine(persona.ToString());

            }
            return "";
        }

    }
}
