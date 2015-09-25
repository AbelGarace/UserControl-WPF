using System.ComponentModel;

namespace StatusPanelInfoControl.ViewModel
{
    public class StatusPanelViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        private decimal _allMessages;
        public decimal AllMessages
        {
            get { return _allMessages; }
            set { if (_allMessages != value) { _allMessages = value; NotifyPropertyChanged("AllMessages"); } }
        }

        private decimal _today;
        public decimal Today
        {
            get { return _today; }
            set { if (_today != value) { _today = value; NotifyPropertyChanged("Today"); } }
        }

        private decimal _last7days;
        public decimal Last7Days
        {
            get { return _last7days; }
            set { if (_last7days != value) { _last7days = value; NotifyPropertyChanged("Last7Days"); } }
        }

        private decimal _last30days;
        public decimal Last30Days
        {
            get { return _last30days; }
            set { if (_last30days != value) { _last30days = value; NotifyPropertyChanged("Last30Days"); } }
        }
        private decimal _last180days;
        public decimal Last180Days
        {
            get { return _last7days; }
            set { if (_last180days != value) { _last180days = value; NotifyPropertyChanged("Last180Days"); } }
        }

        private string _titulo;
        public string Titulo
        {
            get { return _titulo; }
            set { if (_titulo != value) { _titulo = value;  NotifyPropertyChanged("Titulo"); } }
        }
    }
}
