using System.Collections.ObjectModel;

namespace AppleRevenueRadialBarChart
{
    public class ViewModel
    {
        public ObservableCollection<Model> RadialBarData { get; set; }
        public ObservableCollection<Brush> Palette { get; set; }

        public ViewModel()
        {
            var colors = new string[]
            {
                "#0B77E3",
                "#1D5B6F",
                "#BD34B7",
                "#DE7207",
                "#8E4AFC"
            };

            RadialBarData = new ObservableCollection<Model>()
            {
                new Model("Services", 78129, "service", CreateBrush(colors[0])),
                new Model("Wearables", 41241, "earphone", CreateBrush(colors[1])),
                new Model("iPad", 29292, "ipad", CreateBrush(colors[2])),
                new Model("Mac", 40177, "mac", CreateBrush(colors[3])),
                new Model("iPhone", 205489, "iphone", CreateBrush(colors[4]))
            };

            Palette = new ObservableCollection<Brush>(colors.Select(CreateBrush));
        }

        private SolidColorBrush CreateBrush(string hexColor)
        {
            return new SolidColorBrush(Color.FromArgb(hexColor));
        }
    }
}
