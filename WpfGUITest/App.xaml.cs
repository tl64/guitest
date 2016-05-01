using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfGUITest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //StackPanel mainWindow = new StackPanel();
            //DockPanel mainWindow = new DockPanel();
            //WrapPanel mainWindow = new WrapPanel();
            //GridPanel mainWindow = new GridPanel();
            //CanvasPanel mainWindow = new CanvasPanel();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
