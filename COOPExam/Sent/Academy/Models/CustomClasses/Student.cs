using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Utils.Contracts;

namespace Academy.Models.CustomClasses
{
    class Student : IStudent
    {
        private IList<ICourseResult> _CouresResults;
        private Track _Track;
        private string _Username;
        readonly int minUsernameLength = 3;
        readonly int maxUsernameLength = 16;

        public Student(Track track, string username)
        {
            this.Username = username;
            this.Track = track;
            this._CouresResults = new List<ICourseResult>();
                        
        }

        public IList<ICourseResult> CourseResults
        {
            get
            {
                return this._CouresResults;
            }

            set
            {
                this._CouresResults = value;
            }
        }

        public Track Track
        {
            get
            {
                return this._Track;
            }

            set
            {
                this._Track = value;
            }
        }

        public string Username
        {
            get
            {
                return this._Username;
            }

            set
            {
                string error = "User's username should be between 3 and 16 symbols long!";
                ErrorHandling.ValidationOfInput(value, error, minUsernameLength, maxUsernameLength);
                this._Username = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("*Student:");
            result.AppendLine($" -Username: {this._Username}");
            result.AppendLine($" - Track: {this._Track.ToFriendlyString()}");
            result.AppendLine(" - Course results:");
            if (this._CouresResults.Count == 0)
            {
                result.AppendLine("  * User has no course results!");
            }            
            else
            {
                foreach (var courseResult in this._CouresResults)
                {
                    result.AppendLine(courseResult.ToString());
                }
            }
            return result.ToString();
        }
    }
}
