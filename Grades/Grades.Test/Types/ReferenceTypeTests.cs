using System;
using NUnit.Framework;

namespace Grades.Test.Types
{
    [TestFixture()]
    public class ReferenceTypeTests
    {
        [Test()]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            // grades = new float[5];
            grades[1] = 89.1f;
        }

        [Test()]
        public void UpperCaseString()
        {
            string name = "sai";
            name = name.ToUpper();

            Assert.AreEqual("SAI", name);
        }

        [Test()]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015, 1, 1);
            date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);
        }

        [Test()]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(ref book2);
            Assert.AreEqual("A GradeBook", book2.Name);
        }

        private void GiveBookAName(ref GradeBook book)
        {
            book = new GradeBook();
            book.Name = "A GradeBook";
        }

        [Test()]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(ref x);
            Assert.AreEqual(47, x);
        }

        private void IncrementNumber(ref int number)
        {
            number += 1;
        }

        [Test()]
        public void StringComparisions()
        {
            string name1 = "Sai";
            string name2 = "sai";

            bool result = String.Equals(name1, name2, StringComparison.CurrentCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [Test()]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [Test()]
        public void VariablesHoldReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Sai's grade Book";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
