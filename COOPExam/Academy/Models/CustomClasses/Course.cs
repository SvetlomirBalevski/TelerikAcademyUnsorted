using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.CustomClasses
{
    class Course : ICourse
    {
        private DateTime _EndingDate;
        private string _Name;
        private DateTime _StartingDate;
        private int _LecturesPerWeek;
        private IList<IStudent> _OnlineStudents;
        private IList<IStudent> _OnsiteStudents;
        private IList<ILecture> _Lectures;
        readonly int minNameLength = 3;
        readonly int maxNameLength = 45;
        readonly int minLecturesPerWeek = 1;
        readonly int maxLecturesPerWeek = 7;
        

        public Course(string name, int lecturesPerWeek, string StartingDate)
        {
            this.Name = name;
            this.LecturesPerWeek = lecturesPerWeek;
            this._StartingDate = DateTime.Parse(StartingDate);
            this._EndingDate = this._StartingDate.AddDays(30);
            this._OnlineStudents = new List<IStudent>();
            this._OnsiteStudents = new List<IStudent>();
            this._Lectures = new List<ILecture>();
        }

        public DateTime EndingDate
        {
            get
            {
                return this._EndingDate;
            }

            set
            {
                this._EndingDate = value;
            }
        }

        public IList<ILecture> Lectures
        {
            get
            {
                return this._Lectures;
            }
        }

        public int LecturesPerWeek
        {
            get
            {
                return this._LecturesPerWeek;
            }

            set
            {
                string errorMessage = "The number of lectures per week must be between 1 and 7!";
                ErrorHandling.CustomError(value,errorMessage,minLecturesPerWeek,maxLecturesPerWeek);
                this._LecturesPerWeek = value;
            }
        }

        public string Name
        {
            get
            {
                return this._Name;
            }

            set
            {
                string errorString = "The name of the course must be between 3 and 45 symbols!";
                ErrorHandling.ValidationOfInput(value, errorString, minNameLength, maxNameLength);
                this._Name = value;
            }
        }

        public IList<IStudent> OnlineStudents
        {
            get
            {
                return this._OnlineStudents;
            }
        }

        public IList<IStudent> OnsiteStudents
        {
            get
            {
                return this._OnsiteStudents;
            }
        }

        public DateTime StartingDate
        {
            get
            {
                return this._StartingDate;
            }

            set
            {
                this._StartingDate = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("* Course");
            result.AppendLine($" - Name: {this._Name}");
            result.AppendLine($" - Lectures per week: {this._LecturesPerWeek}");
            result.AppendLine($" - Ending date: {this._EndingDate}");
            result.AppendLine($" - Lectures:");
            if (this.Lectures.Count == 0)
            {
                result.AppendLine("* There are no lectures in this course!");
            }
            return result.ToString();
        }

    }
}
