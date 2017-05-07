using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.CustomClasses
{
    class Trainer : ITrainer
    {
        private IList<string> _Technologies;
        private string _Username;
        readonly int minNameLength = 3;
        readonly int maxNameLength = 16;

        public Trainer(string username, string technologies)
        {
            this.Username = username;

            string[] temp = technologies.Split(',').ToArray();
            this._Technologies = new List<string>();
            foreach (var item in temp)
            {
                this._Technologies.Add(item);
            }         
        }

        public IList<string> Technologies
        {
            get
            {
                return this._Technologies;
            }

            set
            {
                this._Technologies = value;
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
                ErrorHandling.ValidationOfInput(value, error, minNameLength, maxNameLength);
                this._Username = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("* Trainer:");
            result.AppendLine($" - Username: {this._Username}");
            result.AppendLine(" - Technologies:");
            foreach (var technology in this._Technologies)
            {
                result.Append($" {technology};");
            }
            return result.ToString();
        }
    }
}
