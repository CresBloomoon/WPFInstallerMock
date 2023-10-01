using System.Windows.Controls;
using WPFInstallerMock.ViewModels;

namespace WPFInstallerMock.Views {
    /// <summary>
    /// InstallPathSettingView.xaml の相互作用ロジック
    /// </summary>
    public partial class InstallPathSettingView : UserControl {
        public InstallPathSettingView(InstallPathSettingViewModel viewModel) {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
