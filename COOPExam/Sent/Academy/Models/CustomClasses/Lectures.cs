using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.CustomClasses
{
    class Lectures : ILecture
    {
        private DateTime _Date;
        private string _Name;
        private IList<ILectureResouce> _Resources;
        private ITrainer _Trainer;
        readonly int NameMaxLength = 30;
        readonly int NameMinLength = 5;
        readonly string NameError = "Lecture's name should be between 5 and 30 symbols long!";

        public Lectures(string name, DateTime date, ITrainer trainer)
        {
            this.Name = name;
            this.Date = date;
            this.Trainer = trainer;
            this._Resources = new List<ILectureResouce>();
        }

        public DateTime Date
        {
            get
            {
                return this._Date;
            }

            set
            {
                this._Date = value;
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
                ErrorHandling.ValidationOfInput(value, NameError, NameMinLength, NameMaxLength);
                this._Name = value;
            }
        }

        public IList<ILectureResouce> Resouces
        {
            get
            {
                return this._Resources;
            }
        }

        public ITrainer Trainer
        {
            get
            {
                return this._Trainer;
            }

            set
            {
                this._Trainer = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("  * Lecture:");
            result.AppendLine($"   - Name: {this._Name}");
            result.AppendLine($"   - Trainer username: {this._Trainer.Username}");
            result.AppendLine($"   - Resources:");
            if (this._Resources.Count == 0) ;
            {
                result.AppendLine("    * There are no resources in this lecture.");
            }
            return result.ToString(); 


        }
    }
}
