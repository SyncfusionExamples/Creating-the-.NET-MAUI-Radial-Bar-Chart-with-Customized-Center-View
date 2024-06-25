# Creating the .NET MAUI Radial Bar Chart with Customized Center View
This sample demonstrates how to create a visually stunning [Radial Bar Chart](https://www.syncfusion.com/maui-controls/maui-circular-charts/chart-types/maui-radial-bar-chart) with customized [center view](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_CenterView) using the [Syncfusion .NET MAUI Charts control](https://www.syncfusion.com/maui-controls/maui-circular-charts).

## Why Use Radial Bar Charts?
[Radial Bar chart](https://youtu.be/KO7LfFuIwHE) is a type of doughnut chart that represents each segment as a separate circle. Radial Bar Charts are versatile and can be used in various scenarios to visualize categorical data in a circular format. Here are a few common use cases:
* Sales Performance
* Market Share Analysis
* Survey Results
* Performance Metrics

## Center View Customization

The .NET MAUI Radial Bar Chart offers extensive customization options, with the [center view](https://help.syncfusion.com/maui/circular-charts/radialbarchart#centerview) feature being one of its most powerful. This feature allows you to add any view or key statistics to the center of the radial bar chart, making it a useful area for sharing additional information about the chart. In this blog, we will visualize Apple's revenue for 2022, placing an Apple icon and the total revenue in the center view. This central element not only adds a visual appeal but also provides a quick snapshot of the overall data.

## Other Key Features of the Syncfusion .NET MAUI Radial Bar Chart

The other key features of Radial Bar chart customization include chart features such as chart title, series customization, interaction features, and legends.

### Chart Title: Setting the Stage
With the Syncfusion .NET MAUI Circular Chart, adding a [title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Title) is simple and intuitive. For our Radial Bar Chart, we've chosen "Apple's Revenue Breakdown for FY 2022." The title of the chart provides quick information about the data being plotted in the chart.

### Palette: Making Data Pop with Colors
The Syncfusion Circular Chart allows for a customized [palette](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_PaletteBrushes) to use distinct colors for each category, making it easier to differentiate between them. Each segment of the radial bar represents a product category, with unique colors assigned to Services, Wearables, iPad, Mac, and iPhone. This use of color coding helps in quick visual identification and comparison of categories.

### Customizing the Series Appearance
With the Syncfusion .NET MAUI Radial Bar Chart, there is flexibility to customize the series appearance to suit data presentation needs. Below are the key properties used to enhance the visual appeal of the Radial Bar Chart series:

The [CapStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_CapStyle) property adds smooth curves to the start and end of each bar, the [Radius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_Radius) property changes the radial bar chart size, and the [MaximumValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_MaximumValue) represents the span of the segment-filled area in the radial bar track. The [GapRatio](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_GapRatio) defines the spacing between each segment, and the [TrackFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_TrackFill) property customizes the circular bar area behind the radial bar segments.

By leveraging these properties, a visually stunning and highly customizable Radial Bar Chart can be created to effectively communicate data insights.  

### Legend: A Quick Reference Guide
The [legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) in the Syncfusion Circular Chart provides information about the data points displayed in the circular chart. It lists all categories with their respective icons, making it easy to interpret the data at a glance without needing to hover over each segment.

### Tooltip: Adding Interactivity
Syncfusion’s Circular Chart enhances interactivity with [tooltips](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_EnableTooltip) that provide detailed information when a user hovers over or taps on a segment. In this chart, the tooltip shows the category name and its contribution to the total revenue in percentage. This interactivity makes the chart more engaging and informative.

After executing these code examples, we will get the output that resembles the following image. 

![OutputWithAudio](https://github.com/SyncfusionExamples/Creating-the-.NET-MAUI-Radial-Bar-Chart-to-Visualize-Apples-Revenue-Breakdown/assets/105496706/c2f1db20-708b-47dd-9b70-20bf3a606daf)


## Troubleshooting
Path too long exception

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

For a step-by-step procedure, refer to the [Radial Bar Chart with customized center view blog post]().

