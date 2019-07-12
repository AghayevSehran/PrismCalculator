using Prism.Unity;
using PrismCalculator.Views;
using System.Windows;
using Unity;

namespace PrismCalculator.App_Start
{
    class Bootstrapper:UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.TryResolve<Shell>();
        }
        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            Container.RegisterInstances();
        }
    }
}
