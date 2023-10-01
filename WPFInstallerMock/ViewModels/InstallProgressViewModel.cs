using MvvmWizard.Classes;
using System.Threading.Tasks;

namespace WPFInstallerMock.ViewModels {
    public sealed class InstallProgressViewModel : StepViewModelBase{

        private bool _isProcessing;
        public bool IsProcessing {
            get { return _isProcessing; }
            set { SetProperty(ref _isProcessing, value); }
        }

        public InstallProgressViewModel() {
            
            InstallExecuteCommand = new SimpleCommand(InstallExecute);

        }

        public SimpleCommand InstallExecuteCommand { get; }
        
        private async void InstallExecute() {

            try {
                IsProcessing = true;
                await Task.Delay(3000);
            }
            finally {
                IsProcessing = false;
            }

        }
    }
}
