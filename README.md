# Creating the .NET MAUI Radial Bar Chart with Customized Center View
This sample demonstrates how to create a visually stunning Radial Bar Chart with customized center view using the Syncfusion .NET MAUI Charts control.

## Why Use Radial Bar Charts?
Radial Bar chart is a type of doughnut chart that represents each segment as a separate circle. Radial Bar Charts are versatile and can be used in various scenarios to visualize categorical data in a circular format. Here are a few common use cases:
* Sales Performance
* Market Share Analysis
* Survey Results
* Performance Metrics

## Center View Customization

The .NET MAUI Radial Bar Chart offers extensive customization options, with the center view feature being one of its most powerful. This feature allows you to add any view or key statistics to the center of the radial bar chart, making it a useful area for sharing additional information about the chart. In this blog, we will visualize Apple's revenue for 2022, placing an Apple icon and the total revenue in the center view. This central element not only adds a visual appeal but also provides a quick snapshot of the overall data.

```
<chart:RadialBarSeries.CenterView>

    <VerticalStackLayout Margin="{OnPlatform WinUI='0, -20, 0, 0', Default='0, -10, 0, 0'}" >
        <Image HorizontalOptions="CenterAndExpand" VerticalOptions="StartAndExpand"  Source="apple.png" 
               HeightRequest="{OnPlatform iOS=70, Android=70, WinUI=85, MacCatalyst=120}" 
               WidthRequest="{OnPlatform iOS=70, Android=70, WinUI=100, MacCatalyst=120}" />
        <VerticalStackLayout Margin="{OnPlatform WinUI='0, -10, 0, 0', Default='0, -10, 0, 0'}" >
            <Label Text="Total revenue " FontSize="{OnPlatform Android=12, iOS=14, WinUI=12, MacCatalyst=18}" 
                   HorizontalOptions="Center" VerticalOptions="Center" />
            <Label Text="$394.3B" FontSize="{OnPlatform Android=14, iOS=18, WinUI=16, MacCatalyst=22}" 
                   FontAttributes="Bold" HorizontalOptions="Center" VerticalOptions="Center" />
        </VerticalStackLayout>
    </VerticalStackLayout>

</chart:RadialBarSeries.CenterView>
```

## Other Key Features of the Syncfusion .NET MAUI Radial Bar Chart

The other key features of Radial Bar chart customization include chart features such as chart title, series customization, interaction features, and legends.

### Chart Title: Setting the Stage
With the Syncfusion .NET MAUI Circular Chart, adding a title is simple and intuitive. For our Radial Bar Chart, we've chosen "Apple's Revenue Breakdown for FY 2022." The title of the chart provides quick information about the data being plotted in the chart.

<chart:SfCircularChart.Title>

    <HorizontalStackLayout>
        <Image Source="revenue1.png" WidthRequest="{OnPlatform Default='50', iOS='40', MacCatalyst='70'}"/>
        <VerticalStackLayout>
            <Label Text="Apple's Revenue Breakdown for FY 2022" Margin="5,0,0,0" HorizontalOptions="CenterAndExpand" 
                   HorizontalTextAlignment="Center" VerticalOptions="CenterAndExpand" 
                   FontSize="{OnPlatform Default='25', iOS='22', MacCatalyst='28'}" FontAttributes="Bold" />
            <Label Text="Revenue growth rate calculated by product category" Margin="5,0,0,0" 
                   HorizontalOptions="StartAndExpand" HorizontalTextAlignment="Center" VerticalOptions="CenterAndExpand" 
                   FontSize="{OnPlatform WinUI='14', Android='12', iOS='14', MacCatalyst='18'}" TextColor="Gray"/>
        </VerticalStackLayout>
    </HorizontalStackLayout>

</chart:SfCircularChart.Title>

### Palette: Making Data Pop with Colors
The Syncfusion Circular Chart allows for a customized palette to use distinct colors for each category, making it easier to differentiate between them. Each segment of the radial bar represents a product category, with unique colors assigned to Services, Wearables, iPad, Mac, and iPhone. This use of color coding helps in quick visual identification and comparison of categories.

<chart:RadialBarSeries PaletteBrushes="{Binding Palette}">

public class ViewModel
{
    public ObservableCollection<Brush> Palette { get; set; }

    public ViewModel()
    {
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

### Customizing the Series Appearance
With the Syncfusion .NET MAUI Radial Bar Chart, there is flexibility to customize the series appearance to suit data presentation needs. Below are the key properties used to enhance the visual appeal of the Radial Bar Chart series:
The CapStyle property adds smooth curves to the start and end of each bar, the Radius property changes the radial bar chart size, and the MaximumValue represents the span of the segment-filled area in the radial bar track. The GapRatio defines the spacing between each segment, and the TrackFill property customizes the circular bar area behind the radial bar segments.
By leveraging these properties, a visually stunning and highly customizable Radial Bar Chart can be created to effectively communicate data insights.

<chart:RadialBarSeries CapStyle="BothCurve"
                Radius="{OnPlatform Android=1, iOS=1, Default=0.8}"
                MaximumValue="218000" GapRatio="0.4" TrackFill="#E7E0EC">        

### Legend: A Quick Reference Guide
The legend in the Syncfusion Circular Chart provides information about the data points displayed in the circular chart. It lists all categories with their respective icons, making it easy to interpret the data at a glance without needing to hover over each segment.

<chart:SfCircularChart>

    <chart:SfCircularChart.Resources>

        <local:BrushToColorConverter x:Key="brushToColor" />

        <local:BillionConverter x:Key="billionConverter" />

        <DataTemplate x:Key="LegendTemplate">
            <Grid ColumnDefinitions="Auto,Auto" Margin="{OnPlatform Android='0, -5, 0, 10', Default='20, 0, 0, 0'}">
                <Image Grid.Column="0" Source="{Binding Item.CategoryImage}" 
                       WidthRequest="{OnPlatform Default='35', iOS='40', MacCatalyst='50'}" 
                       HeightRequest="{OnPlatform Default='35', iOS='40', MacCatalyst='50'}" />
                <VerticalStackLayout Grid.Column="1">
                    <Label FontSize="{OnPlatform Default='13', iOS='16', MacCatalyst='18'}" 
                        VerticalTextAlignment="Center" Text="{Binding Item.Category}" 
                        TextColor="{Binding IconBrush,Converter={StaticResource brushToColor}}" Margin="0,2,0,0"
                        HorizontalOptions="StartAndExpand" HorizontalTextAlignment="Center"/>
                    <Label FontSize="{OnPlatform Default='13', iOS='16', MacCatalyst='18'}" 
                        VerticalTextAlignment="Center" 
                        Text="{Binding Item.Revenue, Converter={StaticResource billionConverter}}"
                        TextColor="{Binding IconBrush,Converter={StaticResource brushToColor}}" Margin="0,2,0,0"
                        HorizontalOptions="StartAndExpand" HorizontalTextAlignment="Center"/>
                </VerticalStackLayout>
            </Grid>
        </DataTemplate>

    </chart:SfCircularChart.Resources>


    <chart:SfCircularChart.Legend>
        <chart:ChartLegend Placement="{OnPlatform Android=Right, Default=Bottom}" 
                           ItemTemplate="{StaticResource LegendTemplate}"/>
    </chart:SfCircularChart.Legend>

    <chart:RadialBarSeries LegendIcon="Circle">

    </chart:RadialBarSeries>

</chart:SfCircularChart>


public class BillionConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if(value == null)
            return "$0B";

        value = Math.Round((double)value/1000, 1);
        return $"${value}B";
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

public class BrushToColorConverter : IValueConverter
{
    public object? Convert(object? value, Type? targetType, object? parameter, CultureInfo? culture)
    {
        if (!Brush.IsNullOrEmpty(value as SolidColorBrush))
        {
            SolidColorBrush? brush = value as SolidColorBrush;
            return brush == null ? null : brush.Color;
        }
        throw new ArgumentException("Expected value to be a type of brush", nameof(value));
    }

    public object ConvertBack(object? value, Type? targetType, object? parameter, CultureInfo? culture)
    {
        if (value != null && value is Color color)
        {
            return new SolidColorBrush(color);
        }
        throw new ArgumentException("Expected value to be a type of color", nameof(value));
    }
}

### Tooltip: Adding Interactivity
Syncfusion’s Circular Chart enhances interactivity with tooltips that provide detailed information when a user hovers over or taps on a segment. In this chart, the tooltip shows the category name and its contribution to the total revenue in percentage. This interactivity makes the chart more engaging and informative.

<chart:SfCircularChart>

    <chart:SfCircularChart.Resources>

        <local:PercentageConverter x:Key="percentageConverter" />

        <DataTemplate x:Key="tooltipTemplate">
                    <StackLayout Orientation="Horizontal" VerticalOptions="Center"   Margin="{OnPlatform MacCatalyst='3'}">
                        <Label Text="{Binding Item.Category, StringFormat='{0}: '}" TextColor="White" FontAttributes="Bold" FontSize="{OnPlatform Default='12', MacCatalyst='18'}" HorizontalOptions="Center" VerticalOptions="Center"/>
                        <Label Text="{Binding Item.Revenue, Converter={StaticResource percentageConverter}}" TextColor="White" FontAttributes="Bold" FontSize="{OnPlatform Default='12', MacCatalyst='18'}"
HorizontalOptions="Center" VerticalOptions="Center"/>
                    </StackLayout>
                </DataTemplate>

    </chart:SfCircularChart.Resources>
    
    <chart:SfCircularChart.TooltipBehavior>
    <chart:ChartTooltipBehavior />
    </chart:SfCircularChart.TooltipBehavior>

    <chart:RadialBarSeries 
EnableTooltip="True" TooltipTemplate="{StaticResource tooltipTemplate}">
                    
    </chart:RadialBarSeries>

</chart:SfCircularChart>

public class PercentageConverter : IValueConverter
{
    double total = 394328;
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value == null)
            return 0;

        value = Math.Round(((double)value / total) * 100, 2);
        return $" {value}%";
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

After executing these code examples, we will get the output that resembles the following image. 



