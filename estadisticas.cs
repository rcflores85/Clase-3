namespace Grades
{
    public class Estadisticas
    {
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
        
        //creamos el constructor
        public Estadisticas()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public Estadisticas(float min, float max)
        {
            HighestGrade = max;
            LowestGrade = min;
        }
    }
}