using System.ComponentModel;
using System.ServiceProcess;
using System.Configuration.Install;

namespace SimpleWindowsCSharpService {
    partial class SimpleServiceInstaller {
        private ServiceProcessInstaller serviceProcessInstaller;
        private ServiceInstaller simpleServiceInstaller;
        private IContainer components = null;

        /// <summary> 
        ///     Dispose all used resources
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        /// <summary>
        ///     Method for constructor support
        /// </summary>
        private void InitializeComponent() {
            serviceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            simpleServiceInstaller = new System.ServiceProcess.ServiceInstaller();

            serviceProcessInstaller.Password = null;
            serviceProcessInstaller.Username = null;

            simpleServiceInstaller.ServiceName = "SimpleWindowsService";
            simpleServiceInstaller.AfterInstall += new InstallEventHandler(
                serviceInstaller_AfterInstall
            );

            Installers.AddRange(
                new Installer[] {
                    serviceProcessInstaller,
                    simpleServiceInstaller
                }
            );
        }
    }
}