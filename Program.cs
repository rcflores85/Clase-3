using System;
using System.Collections.Generic;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook boletin = new GradeBook();
            boletin.AddGrades(91);
            boletin.AddGrades(3.1415f);//especificamos que es un float
            boletin.AddGrades(75);

            Estadisticas estadisticas = boletin.ComputarEstadisticas();
            Console.WriteLine("Promedio: ", estadisticas.AverageGrade);
            Console.WriteLine("PRomedio2: {0.2f}", estadisticas.AverageGrade);
            Console.WriteLine("Mas alta: {0} de notas del [1] curso de net core", estadisticas.HighestGrade);

            string mensaje = string.Format("Mas baja [0]", estadisticas.LowestGrade);

            GradeBook boletin2 = new GradeBook("Luis");
            boletin2.LastName = string.Empty;
            Console.WriteLine("Apellido {0}", boletin2.LastName);
            Iteradores();
        }
        static void Condicionales()
        {
            int age = 5;
            string menorDeEdad = "";

            if (age < 18)
                menorDeEdad = "Si";
            else
                menorDeEdad = "No";

            Console.WriteLine(menorDeEdad);
        }
        static void Iteradores()
        {
            List<int> years = new List<int>();
            years.Add(2);
            years.Add(5);
            years.Add(10);
            int[] yearsArray = years.ToArray();
            int [] array = new int[] {1, 2, 3};
            foreach(int y in yearsArray)
            {
                var entero = 1;
                Console.WriteLine(y + " - ");
                if (entero == y)
                    return;

                //break;
                //continue;
            }

            for (int i = 0;i<yearsArray.Length;i++)
            {
                Console.WriteLine(yearsArray[i] + " - ");
            }
            int age = 5;
            while (age > 0)
            {
                Console.WriteLine(age);
                age--;
            }
            age = 5;
            do
            (
              Console.WriteLine(age);
              age--;
            ) while (age > 0);
        }
    }
}
