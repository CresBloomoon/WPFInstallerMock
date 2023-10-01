using MvvmWizard.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace WPFInstallerMock.ViewModels {
    public sealed class SimpleDemoDialogViewModel {

        public SimpleDemoDialogViewModel() {
            var unityContainer = new UnityContainer();
            WizardSettings.Instance.ViewResolver = type => unityContainer.Resolve(type);
        }
    }
}
