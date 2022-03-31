//-----------------------------------------------------------------------
// <copyright file="App.xaml.cs" company="Jay Bautista Mendoza">
//     Copyright (c) Jay Bautista Mendoza. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ThirdEye
{
    using System.Configuration;
    using System.Windows;
    using JayWpf.Windows;

    /// <summary>Interaction logic for App XAML.</summary>
    public partial class App : Application
    {
        /// <summary>Declare an instance of WPF Window.</summary>
        WpfWindow mainWindow;

        /// <summary>Startup event of the main App.</summary>
        /// <param name="sender">Object 'sender'.</param>
        /// <param name="e">StartupEventArgs 'e'.</param>
        private void App_Startup(object sender, StartupEventArgs e)
        {
            this.mainWindow = new WpfWindow("Views/MainPage.xaml");
            this.mainWindow.Title = "3rd Eye";
            this.mainWindow.IconText = "(ⵙ)";
            this.mainWindow.IconTextSize = 16;
            this.mainWindow.Show();
        }
    }
}
