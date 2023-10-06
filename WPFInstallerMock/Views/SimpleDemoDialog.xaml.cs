using MvvmWizard.Classes;
using System.Collections.Generic;
using System.Windows.Input;

namespace WPFInstallerMock.Views {
    /// <summary>
    /// SimpleDemoDialog.xaml の相互作用ロジック
    /// </summary>
    public partial class SimpleDemoDialog {
        public SimpleDemoDialog() {
            this.FinishCommand = new SimpleGenericCommand<Dictionary<string, object>>(FinishMethod);
            this.CloseCommand = new SimpleGenericCommand<Dictionary<string, object>>(CloseMethod);
            this.InstallExecuteCommand = new SimpleGenericCommand<Dictionary<string, object>>(InstallExecuteMethod);
            SharedContext = new Dictionary<string, object>();
            SharedContext["In"] = 88;

            InitializeComponent();
        }

        private void FinishMethod(Dictionary<string, object> obj) {
            Close();
        }

        private void CloseMethod(Dictionary<string, object> obj) {
            Close();
        }

        private void InstallExecuteMethod(Dictionary<string, object> obj) {
            //InstallStart();
        }

        public ICommand FinishCommand { get; }
        public ICommand CloseCommand { get; }
        public ICommand InstallExecuteCommand { get; }
        public Dictionary<string, object> SharedContext { get; }
    }
}
