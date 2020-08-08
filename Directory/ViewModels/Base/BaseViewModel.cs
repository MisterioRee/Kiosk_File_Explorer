
using System.ComponentModel;

namespace Kiosk_File_Explorer.Directory.ViewModels.Base
{    /// <summary>
     /// A base view model that fires Property Changed events as needed
     /// </summary>

    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The event that is fired when any child property changes its value
        /// </summary>
        /// 
        protected void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        } 
    }
}
