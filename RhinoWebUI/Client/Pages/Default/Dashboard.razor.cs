using MudBlazor;
using System;
using System.Collections.Generic;

namespace RhinoWebUI.Client.Pages.Default
{
    public partial class Dashboard
    {
        #region    Table Data
        EarningReport[] earningReports = new EarningReport[]
        {
        new EarningReport { Name = "Lunees", Title = "Reactor Engineer", Avatar = "https://avatars2.githubusercontent.com/u/71094850?s=460&u=66c16f5bb7d27dc751f6759a82a3a070c8c7fe4b&v=4", Salary = "$0.99", Severity = Color.Success, SeverityTitle = "Low"},
        new EarningReport { Name = "Mikes-gh", Title = "Developer", Avatar = "https://avatars.githubusercontent.com/u/16208742?s=120&v=4", Salary = "$19.12K", Severity = Color.Secondary, SeverityTitle = "Medium"},
        new EarningReport { Name = "Garderoben", Title = "CSS Magician", Avatar = "https://avatars2.githubusercontent.com/u/10367109?s=460&amp;u=2abf95f9e01132e8e2915def42895ffe99c5d2c6&amp;v=4", Salary = "$1337", Severity = Color.Primary, SeverityTitle = "High"},
                };

        class EarningReport
        {
            public string Avatar;
            public string Name;
            public string Title;
            public Color Severity;
            public string SeverityTitle;
            public string Salary;
        }
        #endregion

        #region Bar Charts
        private int barChartIndex = -1; //default value cannot be 0 -> first selectedindex is 0.

        public List<ChartSeries> barChartsSeries = new List<ChartSeries>()
{
        new ChartSeries() { Name = "United States", Data = new double[] { 40, 20, 25, 27, 46, 60, 48, 80, 15 } },
        new ChartSeries() { Name = "Germany", Data = new double[] { 19, 24, 35, 13, 28, 15, 13, 16, 31 } },
        new ChartSeries() { Name = "Sweden", Data = new double[] { 8, 6, 11, 13, 4, 16, 10, 16, 18 } },
    };
        public string[] barChartsXAxisLabels = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep" };
        #endregion

        #region Line Chart
        private ChartOptions options = new ChartOptions();
        public List<ChartSeries> linChartSeries = new List<ChartSeries>()
{
        new ChartSeries() { Name = "Series 1", Data = new double[] { 90, 79, 72, 69, 62, 62, 55, 65, 70 } },
        new ChartSeries() { Name = "Series 2", Data = new double[] { 35, 41, 35, 51, 49, 62, 69, 91, 148 } },
    };
        public string[] linChartXAxisLabels = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep" };

        Random random = new Random();
        protected override void OnInitialized()
        {
            options.InterpolationOption = InterpolationOption.NaturalSpline;
            options.YAxisFormat = "c2";
        }

        public void RandomizeData()
        {
            var new_series = new List<ChartSeries>()
{
            new ChartSeries() { Name = "Series 1", Data = new double[9] },
            new ChartSeries() { Name = "Series 2", Data = new double[9] },
        };
            for (int i = 0; i < 9; i++)
            {
                new_series[0].Data[i] = random.NextDouble() * 100;
                new_series[1].Data[i] = random.NextDouble() * 100;
            }
            linChartSeries = new_series;
            StateHasChanged();
        }

        void OnClickMenu(InterpolationOption interpolationOption)
        {
            options.InterpolationOption = interpolationOption;
            StateHasChanged();
        }

        #endregion

        #region Pie Charts
        private int pieChartIndex = -1; //default value cannot be 0 -> first selectedindex is 0.
        int dataSize = 4;
        double[] data = { 77, 25, 20, 5 };
        string[] labels = { "Uranium", "Plutonium", "Thorium", "Caesium", "Technetium", "Promethium",
                        "Polonium", "Astatine", "Radon", "Francium", "Radium", "Actinium", "Protactinium",
                        "Neptunium", "Americium", "Curium", "Berkelium", "Californium", "Einsteinium", "Mudblaznium" };

        Random pieChartRandom = new Random();

        void PieChartRandomizeData()
        {
            var new_data = new double[dataSize];
            for (int i = 0; i < new_data.Length; i++)
                new_data[i] = pieChartRandom.NextDouble() * 100;
            data = new_data;
            StateHasChanged();
        }

        void AddDataSize()
        {
            if (dataSize < 20)
            {
                dataSize = dataSize + 1;
                PieChartRandomizeData();
            }
        }
        void RemoveDataSize()
        {
            if (dataSize > 0)
            {
                dataSize = dataSize - 1;
                PieChartRandomizeData();
            }
        }
        #endregion

        #region
        #endregion
    }
}
