using System;
using System.Collections.Generic;

namespace Hospital
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int idMedico=0;
            string opcion = "";
            Hospital hospital = new Hospital();

            do
            {
                Console.WriteLine();
                Console.WriteLine("Elige la opcion: \n" +
                    "A.Agregar medico \n" +
                    "B.Agregar paciente \n" +
                    "C.Agregar administrativo \n" +
                    "D.Mostrar medico \n" +
                    "F.Listar pacientes por medico \n" +
                    "G.Eliminar a un paciente \n" +
                    "H.Mostrar todas las personas del hospital \n" +
                    "E.Exit");
                opcion = Console.ReadLine().ToUpper();

                switch (opcion)
                {
                    case "A":

                        string tipo = "medico", especialidad;
                        idMedico++;

                        var datosPersona = PedirDatosBasicos(tipo);                        

                        Console.WriteLine("Especialidad del medico:");
                        especialidad = Console.ReadLine();

                        hospital.AgregarMedico(datosPersona.Telefono, datosPersona.Edad, datosPersona.Nombre, datosPersona.Sexo, idMedico, especialidad); ;
                        break;

                    case "B":
                        tipo = "paciente";
                        string enfermedad;

                        datosPersona = PedirDatosBasicos(tipo);

                        Console.WriteLine("Enfermedad del paciente:");
                        enfermedad = Console.ReadLine();                       

                        hospital.AgregarPaciente(datosPersona.Telefono, datosPersona.Edad, datosPersona.Nombre, datosPersona.Sexo, idMedico, enfermedad); ;
                        break;

                    case "C":
                        tipo = "administrativo";

                        datosPersona = PedirDatosBasicos(tipo);

                        hospital.AgregarAdministrativo(datosPersona.Telefono, datosPersona.Edad, datosPersona.Nombre, datosPersona.Sexo);
                        break;

                    case "D":
                        hospital.MostrarMedicos();
                        break;

                    case "F":
                        Console.WriteLine("Codigo Medico:");
                        int codigo = int.Parse(Console.ReadLine());

                        hospital.MostrarPacienteDeMedico(codigo);
                        break;

                    case "G":
                        Console.WriteLine("Paciente a eliminar: ");
                        string nombre = Console.ReadLine();

                        hospital.BorrarPaciente(nombre);
                        break;

                    case "H":
                        hospital.ToString();
                        break;
                }

            } while (opcion != "E");
        }

        static (int Telefono, int Edad, string Nombre, string Sexo) PedirDatosBasicos(string tipo)
        {
            int telefono, edad;
            string nombre, sexo;
            Console.WriteLine($"Nombre del {tipo}:");
            nombre = Console.ReadLine();

            Console.WriteLine($"Sexo del {tipo}:");
            sexo = Console.ReadLine();

            Console.WriteLine($"Edad del {tipo}:");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine($"Telefono del {tipo}:");
            telefono = int.Parse(Console.ReadLine());

            return (telefono, edad, nombre, sexo);
        }

    }
}
