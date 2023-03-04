﻿using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;

namespace NETWorks.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {   
        // LiveCharts Constructor
        public ISeries[] Series { get; set; } = new ISeries[]
        {
            new LineSeries<double>
            {
                Values = new double[] {2, 1, 3, 5, 3, 4, 6},
                Fill = null
            }
        };
        
    
    }
}