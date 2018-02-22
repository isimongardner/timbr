using System.ComponentModel;

namespace Timbr.Views
{
    public abstract class ApplicationView : INotifyPropertyChanged, IApplicationView
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual void Update() { }
        public virtual void Create() { }
    }
}
