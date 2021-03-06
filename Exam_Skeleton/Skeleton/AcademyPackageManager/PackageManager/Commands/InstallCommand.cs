﻿using PackageManager.Commands.Contracts;
using PackageManager.Core.Contracts;
using PackageManager.Enums;
using PackageManager.Models.Contracts;
using System;

namespace PackageManager.Commands
{
    internal class InstallCommand : ICommand
    {
        private IInstaller<IPackage> installer;
        private IPackage package;

        public InstallCommand(IInstaller<IPackage> installer, IPackage package)
        {
            if (installer == null)
            {
                throw new ArgumentNullException();
            }

            if (package == null)
            {
                throw new ArgumentNullException();
            }

            this.installer = installer;
            this.package = package;
            this.installer.Operation = InstallerOperation.Install;
        }

        internal IInstaller<IPackage> Installer { get { return this.installer; } } // Added for test purpose
        internal IPackage Package { get { return this.package; } } // Added for test purpose
        
        public void Execute()
        {
            this.installer.PerformOperation(this.package);
        }
    }
}
