using Academy.Models.Utils.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Enums;

namespace Academy.Models.CustomClasses
{
    class CourseResult : ICourseResult
    {
        private ICourse _Course;
        private float _CoursePoints;
        private float _ExamPoints;
        private Grade _Grade;
        readonly float minExamPoints = 0;
        readonly float maxExamPoints = 1000;
        readonly string ExamPointsError = "Course result's exam points should be between 0 and 1000!";
        readonly float minCoursePoints = 0;
        readonly float maxCoursePoints = 125;
        readonly string CoursePointsError = "Course result's course points should be between 0 and 125!";

        public CourseResult(ICourse course, float coursepoints, float exampoints)
        {
            ErrorHandling.CustomError(exampoints, ExamPointsError, minExamPoints, maxExamPoints);
            ErrorHandling.CustomError(coursepoints, ExamPointsError, minExamPoints, maxExamPoints);
            this._CoursePoints = coursepoints;
            this._ExamPoints = exampoints;
            this._Grade = FindGrade(exampoints, coursepoints);
        }

        public ICourse Course
        {
            get
            {
                return this._Course;
            }
        }

        public float CoursePoints
        {
            get
            {
                return this._CoursePoints;
            }
        }

        public float ExamPoints
        {
            get
            {
                return this._ExamPoints;
            }
        }

        public Grade Grade
        {
            get
            {
                return this._Grade;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"  * {this._Course.Name}: Points - {this.CoursePoints}, Grade - {this._Grade.ToFriendlyString()}");
            return result.ToString();
        }

        private Grade FindGrade(float exampoints, float coursepoints)
        {
            if (exampoints >= 65 || coursepoints >= 75)
            {
                return Grade.Excellent;
            }
            else if ((exampoints < 65 && exampoints >= 30) || (coursepoints < 75 && coursepoints >= 45))
            {
                return Grade.Passed;
            }
            else
            {
                return Grade.Failed;
            }
        }
    }
}
