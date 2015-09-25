using System.Windows;

namespace StatusPanelInfoDependencyControl.ViewModel
{
    public class StatusPanelDependencyViewModel : DependencyObject
    {
        public decimal AllMessages
        {             
            get { return (decimal)GetValue(AllMessagesProperty); }
            set { SetValue(AllMessagesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AllMessages.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AllMessagesProperty =
            DependencyProperty.Register("AllMessages", typeof(decimal), typeof(StatusPanelDependencyViewModel), new PropertyMetadata(decimal.Parse("0")));

        public decimal Today
        {
            get { return (decimal)GetValue(TodayProperty); }
            set { SetValue(TodayProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Today.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TodayProperty =
            DependencyProperty.Register("Today", typeof(decimal), typeof(StatusPanelDependencyViewModel), new PropertyMetadata(decimal.Parse("0")));

        public decimal Last7Days
        {
            get { return (decimal)GetValue(Last7DaysProperty); }
            set { SetValue(Last7DaysProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Last7Days.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Last7DaysProperty =
            DependencyProperty.Register("Last7Days", typeof(decimal), typeof(StatusPanelDependencyViewModel), new PropertyMetadata(decimal.Parse("0")));

        public decimal Last30Days
        {
            get { return (decimal)GetValue(Last30DaysProperty); }
            set { SetValue(Last30DaysProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Last30Days.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Last30DaysProperty =
            DependencyProperty.Register("Last30Days", typeof(decimal), typeof(StatusPanelDependencyViewModel), new PropertyMetadata(decimal.Parse("0")));

        public decimal Last180Days
        {
            get { return (decimal)GetValue(Last180DaysProperty); }
            set { SetValue(Last180DaysProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Last180Days.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Last180DaysProperty =
            DependencyProperty.Register("Last180Days", typeof(decimal), typeof(StatusPanelDependencyViewModel), new PropertyMetadata(decimal.Parse("0")));



        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set { SetValue(TituloProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Titulo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TituloProperty =
            DependencyProperty.Register("Titulo", typeof(string), typeof(StatusPanelDependencyViewModel), new PropertyMetadata(""));


    }
}
