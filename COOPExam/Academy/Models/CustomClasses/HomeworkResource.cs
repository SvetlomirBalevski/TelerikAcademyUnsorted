using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.CustomClasses
{
    class HomeworkResource : ParentResources, ILectureResouce, IResources
    {
        private DateTime _DueDate;
        public HomeworkResource(string name, string url, DateTime dueDate) : base(name, url)
        {
            this.DueDate = dueDate;
        }

        public DateTime DueDate
        {
            get
            {
                return this._DueDate;
            }
            set
            {
                this._DueDate = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(PrintForResourceClasses.FormatBeforePrinting(base.Name, base.Url, "Demo"));
            result.AppendLine($"     - Due date: {_DueDate}");
            return base.ToString();
        }
    }
}
