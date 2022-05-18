using Domain;
using Domain.Contracts;
using Infrastructure;
using System.Windows;

namespace Gui
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        
        private void Application_Startup(object sender, StartupEventArgs e)
        {            
            IAutoRepository autoRepo = new AutoRepository();
            IOnderhoudRepository onderhoudRepo = new OnderhoudRepository();
            
            DomeinController dc = new(autoRepo, onderhoudRepo);

            // Create the startup window
            AutoWindow wnd = new(dc);
            
            wnd.Title = "Auto";
            
            // Show the window
            wnd.Show();
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Applicatiefout: " + e.Exception, "Probleem", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
