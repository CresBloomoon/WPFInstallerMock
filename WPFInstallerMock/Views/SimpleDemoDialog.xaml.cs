using MvvmWizard.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFInstallerMock.Views {
    /// <summary>
    /// SimpleDemoDialog.xaml の相互作用ロジック
    /// </summary>
    public partial class SimpleDemoDialog {
        public SimpleDemoDialog() {

            CloseCommand = new SimpleGenericCommand<Dictionary<string, object>>(ExecuteMethod);
            SharedContext = new Dictionary<string, object>();
            SharedContext["In"] = 88;

            InitializeComponent();
        }

        private void ExecuteMethod(Dictionary<string, object> obj) {
            Close();
        }
        public ICommand CloseCommand { get; }
        public Dictionary<string, object> SharedContext { get; }
    }
}
