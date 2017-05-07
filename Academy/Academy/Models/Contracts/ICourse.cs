using System;
using System.Collections.Generic;

namespace Academy.Models.Contracts
{
    public interface ICourse
    {
        string Name { get; set; }

        int LecturesPerWeek { get; set; }

        DateTime StartingDate { get; set; }

        DateTime EndingDate { get; set; }

        IList<Student> OnsiteStudents { get; }

        IList<Student> OnlineStudents { get; }

        IList<ILecture> Lectures { get; }
    }
}
