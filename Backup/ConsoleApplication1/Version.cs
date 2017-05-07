using System;

namespace HWDeffClass2
{

    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]

    public class AtributeVersion : Attribute
    {
        public AtributeVersion(string version)
        {
            this.Version = version;
        }

        public string Version { get; set; }
    }
}

