using Kiosk_File_Explorer.Directory.Commands;
using Kiosk_File_Explorer.Directory.Data;
using Kiosk_File_Explorer.Directory.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace Kiosk_File_Explorer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FileCommand fileCommand = new FileCommand();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new DirectoryStructureViewModel();
        }

        private void Click_Copy(object sender, RoutedEventArgs e)
        {
            var filePath = ((MenuItem)sender).Tag;
            fileCommand.SourcePath = filePath.ToString();
            fileCommand.ActionHolder = FileActionType.Copy;
        }

        private void Click_Cut(object sender, RoutedEventArgs e)
        {
            var filePath = ((MenuItem)sender).Tag;
            fileCommand.SourcePath = filePath.ToString();
            fileCommand.ActionHolder = FileActionType.Cut;
        }

        private void Click_Paste(object sender, RoutedEventArgs e)
        {
            var filePath = ((MenuItem)sender).Tag;
            fileCommand.DestinitionPath = filePath.ToString();
            fileCommand.PerformAction();
        }
    }
}
