using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.CustomClasses
{
    class VideoResource : ParentResources, ILectureResouce, IResources
    {
        private DateTime _UploadDate;
        public VideoResource(string name, string url, DateTime uploadDate) : base(name, url)
        {
            this.UploaDate = uploadDate;
        }

        public DateTime UploaDate
        {
            get
            {
                return this._UploadDate;
            }
            set
            {
                this._UploadDate = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(PrintForResourceClasses.FormatBeforePrinting(base.Name, base.Url, "Video"));
            result.AppendLine($"     - Uploaded on: {_UploadDate}");
            return base.ToString();
        }
    }
}
