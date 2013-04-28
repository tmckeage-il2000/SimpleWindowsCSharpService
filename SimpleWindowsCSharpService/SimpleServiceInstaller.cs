using System.ComponentModel;
using System.Configuration.Install;

namespace SimpleWindowsCSharpService {
    [RunInstaller(true)]
    public partial class SimpleServiceInstaller : Installer {
        public SimpleServiceInstaller() {
            InitializeComponent();
        }

        private void serviceInstaller_AfterInstall(object sender, InstallEventArgs e) {

        }
    }
}
