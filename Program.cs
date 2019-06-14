using System;

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
        }
    }
}
