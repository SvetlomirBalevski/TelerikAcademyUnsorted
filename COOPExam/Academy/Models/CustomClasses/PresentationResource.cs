﻿using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.CustomClasses
{
    class PresentationResource : ParentResources, ILectureResouce, IResources
    {
        public PresentationResource(string name, string url) : base(name, url)
        {
        }

        public override string ToString()
        {
            string result = PrintForResourceClasses.FormatBeforePrinting(base.Name, base.Url, "Presentation");
            return result.ToString();
        }
    }
}
