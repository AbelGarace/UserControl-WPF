using System.Windows.Controls;

namespace StatusPanelInfoControl.View
{
    /// <summary>
    /// Interaction logic for StatusPanelControl.xaml
    /// </summary>
    public partial class StatusPanelControl : UserControl
    {
        public StatusPanelControl()
        {
            InitializeComponent();
            this.DataContext = new ViewModel.StatusPanelViewModel();
        }
    }
}
