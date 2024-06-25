using System.Collections.ObjectModel;

namespace AppleRevenueRadialBarChart
{
    public class ViewModel
    {
        public ObservableCollection<Model> RadialBarData { get; set; }
        public ObservableCollection<Brush> Palette { get; set; }

        public ViewModel()
        {
            RadialBarData = new ObservableCollection<Model>()
            {
                new Model("Services", 78129, "service"),
                new Model("Wearables", 41241, "earphone"),
                new Model("iPad", 29292, "ipad"),
                new Model("Mac", 40177, "mac"),
                new Model("iPhone", 205489, "iphone"),
            };

            Palette = new ObservableCollection<Brush>()
            {
                  new SolidColorBrush(Color.FromArgb("#0B77E3")),
                  new SolidColorBrush(Color.FromArgb("#1D5B6F")),
                  new SolidColorBrush(Color.FromArgb("#BD34B7")),
                  new SolidColorBrush(Color.FromArgb("#DE7207")),
                  new SolidColorBrush(Color.FromArgb("#8E4AFC")),
            };
        }
    }
}
