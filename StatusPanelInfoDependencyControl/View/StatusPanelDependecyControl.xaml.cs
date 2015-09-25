using StatusPanelInfoDependencyControl.ViewModel;
using System.Windows.Controls;

namespace StatusPanelInfoDependencyControl.View
{
    /// <summary>
    /// Interaction logic for StatusPanelDependecyControl.xaml
    /// </summary>
    public partial class StatusPanelDependecyControl : UserControl
    {
        public StatusPanelDependecyControl()
        {
            InitializeComponent();
            this.DataContext = new StatusPanelDependencyViewModel();
        }
    }
}
