using System.Collections.Generic;
using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace NETWorks.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public IEnumerable<ISeries> Series { get; set; }
        = new GaugeBuilder()
        .WithMaxColumnWidth(30)
        .WithBackgroundMaxRadialColumnWidth(30)
        .WithLabelsSize(20)
        .WithInnerRadius(30)
        .WithBackgroundInnerRadius(30)
        .WithBackground(new SolidColorPaint(SKColors.RoyalBlue))
        .WithLabelsPosition(PolarLabelsPosition.ChartCenter)
        .AddValue(30, "DOWNLOAD/UPLOAD", SKColors.DarkSlateBlue, SKColors.Black) // defines the value and the color 
        .BuildSeries();


    }
}