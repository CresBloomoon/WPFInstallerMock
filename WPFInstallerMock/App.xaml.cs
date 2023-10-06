using MvvmWizard.Controls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPFInstallerMock {
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application {

        public static string[] Args { get; private set; }

        [STAThread]
        public static void Main(string[] args) {
            Wizard.Args = args;

            var app = new App();
            app.InitializeComponent();
            app.Run();
        }
    }
}
