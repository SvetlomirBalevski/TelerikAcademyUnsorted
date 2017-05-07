using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.CustomClasses
{
   public class ParentResources : ILectureResouce, IResources
    {
        private string _Name;
        private string _URL;
        readonly int minNameLength = 5;
        readonly int maxNameLength = 30;
        readonly string nameError = "Resource name should be between 3 and 15 symbols long!";
        readonly int minURLLength = 5;
        readonly int maxURLLength = 150;
        readonly string URLError = "Resource url should be between 5 and 150 symbols long!";

        public  ParentResources(string name, string url)
        {
            this.Name = name;
            this.Url = url;
        }

        public string Name
        {
            get
            {
                return this._Name;
            }

            set
            {
                ErrorHandling.ValidationOfInput(value, nameError, minNameLength, maxNameLength);
                this._Name = value;
            }
        }

        public string Url
        {
            get
            {
                return this._URL;
            }

            set
            {
                ErrorHandling.ValidationOfInput(value, URLError, minURLLength, maxURLLength);
                this._URL = value;
            }
        }

    }
}
