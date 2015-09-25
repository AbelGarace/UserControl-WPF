using StatusPanelInfoControl.ViewModel;
using StatusPanelInfoDependencyControl.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserControlExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StatusPanelDependencyViewModel panelDependecy;
        StatusPanelViewModel panel;
        public MainWindow()
        {
            InitializeComponent();
            SetInitialValues();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            panelDependecy.AllMessages++;
            panel.AllMessages++;
        }

        private void SetInitialValues()
        {
            panelDependecy = ((StatusPanelDependencyViewModel)statusPanelDependecyControl.DataContext);
            panelDependecy.Titulo = "Binding DenpendencyProperty";
            panel = ((StatusPanelViewModel)statusPanelControl.DataContext);
            panel.Titulo = "Binding INotifyPropertyChanged";
        }

    }
}
