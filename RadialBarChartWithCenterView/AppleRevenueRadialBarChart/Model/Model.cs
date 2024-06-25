
namespace AppleRevenueRadialBarChart
{
    public class Model
    {
        public string Category { get; set; }
        public double Revenue { get; set; }
        public string CategoryImage { get; set; }

        public Model(string category, double revenue, string categoryImage)
        {
            Category = category;
            Revenue = revenue;
            CategoryImage = categoryImage + ".png";
        }
    }
}
