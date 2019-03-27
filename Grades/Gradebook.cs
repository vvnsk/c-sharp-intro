using System;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook
    {
        private List<float> grades;
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            { 
                if(!String.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }

        public GradeBook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade) 
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics() 
        {
            GradeStatistics stats =  new GradeStatistics();

            float sum = 0;
            foreach(float grade in grades) 
            {
                sum += grade;
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
            }
            stats.AverageGrade = sum / grades.Count;

            return stats;
        }
    }
}
