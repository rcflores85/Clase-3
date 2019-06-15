using System;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook
    {
        //Constructor
        public GradeBook()
        {
            grades = new List<float>();
        }

        public List<float> grades;
        private readonly string _name;
        //private (por default)
        //protected (lo ven los objetos que heredan de la clase)
        //internal

        private string _lastname;
        public string LastName
        {
            get {return _lastname;}
            set
            {
                if (!String.IsNullOrEmpty(value))
                    LastName = value;

                if (_lastname != value)
                    NameChanged(_lastname, value);

                _lastname = value;
            }
        }

        public GradeBook(string name)
        {
            grades = new List<float>();
            _name = name;
            //de esta manera solo se puede asignar valor desde el constructor (readonly)
        }
        public void AddGrades(float grade)
        {
            grades.Add(grade);
        }

        public Estadisticas ComputarEstadisticas()
        {
            Estadisticas estadisticas = new Estadisticas();
            Estadisticas estadisticas2 = new Estadisticas(1, 2);
            float sum = 0;
            foreach(float grade in grades)
            {
                estadisticas.HighestGrade = Math.Max(grade, estadisticas.HighestGrade);
                estadisticas.LowestGrade = Math.Min(grade, estadisticas.LowestGrade);
                sum += grade;
            }
            if (grades.Count > 0)
                estadisticas.AverageGrade = sum / grades.Count;

            return estadisticas;
        }
        public static float MinGrade()
        {
            return float.MinValue;
        }
    }
}