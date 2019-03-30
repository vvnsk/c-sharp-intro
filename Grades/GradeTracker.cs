using System;
using System.Collections;
using System.IO;

namespace Grades
{
    public abstract class GradeTracker: IGradeTracker
    {
        protected string _name;
        public event NameChangedDelegate NameChanged;

        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrades(TextWriter destination);

        public abstract IEnumerator GetEnumerator();

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be Null");
                }
                if (_name != value)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;

                    NameChanged(this, args);
                }

                _name = value;
            }
        }
    }
}
