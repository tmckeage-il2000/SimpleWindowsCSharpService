using System.ServiceProcess;

namespace SimpleWindowsCSharpService {
    /// <summary>
    ///     A simple Windows Service class
    /// </summary>
    class SimpleService : ServiceBase {
        /// <summary>
        ///     Default constructor
        /// </summary>
        public SimpleService() {
            InitializeComponent();
        }

        /// <summary>
        ///     Main methods starts the service
        /// </summary>
        static void Main() {
            Run(
                new SimpleService()
            );
        }

        /// <summary>
        ///     Init this components
        /// </summary>
        private void InitializeComponent() {
            // 
            // SimpleService
            // 
            ServiceName = "SimpleWindowsService";
            CanHandlePowerEvent = true;
            CanHandleSessionChangeEvent = true;
            CanPauseAndContinue = true;
            CanShutdown = true;
            CanStop = true;
        }
    }
}