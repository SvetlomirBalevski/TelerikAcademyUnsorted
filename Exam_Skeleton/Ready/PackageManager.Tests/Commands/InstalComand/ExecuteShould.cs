//using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using PackageManager.Commands;
//using Moq;
//using PackageManager.Core.Contracts;
//using PackageManager.Models.Contracts;
//using PackageManager.Enums;

//namespace PackageManager.Tests.Commands.InstalComand
//{
//    [TestFixture]
//    class ExecuteShould
//    {
//        [Test]
//        public void StartsOperation()
//        {

//            var mockedInstaller = new Mock<IInstaller<IPackage>>();
//            var mockedIpackage = new Mock<IPackage>();
//            var sut = new InstallCommand(mockedInstaller.Object, mockedIpackage.Object);
                      
//            sut.Execute();
//        }
//    }
//}
