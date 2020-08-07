using Kiosk_File_Explorer.Directory.ViewModels; 
using System.Windows; 

namespace Kiosk_File_Explorer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new DirectoryStructureViewModel();
        }
    }
}
