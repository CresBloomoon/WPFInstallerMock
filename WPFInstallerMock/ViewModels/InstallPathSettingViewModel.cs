using Microsoft.WindowsAPICodePack.Dialogs;
using MvvmWizard.Classes;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFInstallerMock.ViewModels {
    public sealed class InstallPathSettingViewModel : StepViewModelBase{

        private string _installPath = @"C:\";

        public InstallPathSettingViewModel() {
            SelectFolderCommand = new SimpleCommand(() => {

                var dialog = new CommonOpenFileDialog() {
                    IsFolderPicker = true,
                    Title = "Select Install Folder",
                    InitialDirectory = InstallPath,
                };
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok) {
                    InstallPath = dialog.FileName;
                }
            });
            
        }


        public string InstallPath {
            get { return _installPath; }
            set { 
                 SetProperty(ref _installPath, value);
                 RaisePropertyChanged(nameof(MyIsEnabled));
            }
        }

        public SimpleCommand SelectFolderCommand { get; }

        public bool MyIsEnabled => !string.IsNullOrWhiteSpace(InstallPath);

        public override async Task OnTransitedFrom(TransitionContext transitionContext) {
            
            if (transitionContext.TransitToStep < transitionContext.TransitedFromStep) {
                return;
            }

            transitionContext.SharedContext[nameof(InstallPath)] = InstallPath;

            return;
        }

    }
}