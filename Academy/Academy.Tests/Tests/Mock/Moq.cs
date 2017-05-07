using Academy.Commands.Adding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Core.Contracts;

namespace Academy.Tests.Tests.Mock
{
    internal class AddingToSeasonCommandMock : AddStudentToSeasonCommand
    {
        public AddingToSeasonCommandMock(IAcademyFactory factory, IEngine engine) : base(factory, engine)
        {
        }

        public IAcademyFactory AcademyFactoryMock { get { return this.factory; } }
      //  public IAcademyFactory AcademyEngine { get { return this.factory; } }
    }
}
