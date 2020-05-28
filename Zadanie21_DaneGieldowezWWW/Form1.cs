using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Helpers;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;
using Syncfusion.Styles;
using Syncfusion.Windows.Forms.Chart.SvgBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Axis = LiveCharts.Wpf.Axis;
using SeriesCollection = LiveCharts.SeriesCollection;

namespace Zadanie21_DaneGieldowezWWW
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        List<string> dates;
        List<double> openingPrices;
        List<double> closingPrices;
        List<int> volumes;


        private void MainForm_Load(object sender, EventArgs e)
        {
            date_Stop.Value = DateTime.Now;
            date_Start.Value = DateTime.Now.AddDays(-30);

            //cartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
            //{
            //    Title = "Month",
            //    Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul"
            //, "Aug", "Sep", "Oct", "Nov", "Dec" }
            //});

            //cartesianChart.AxisY.Add(new LiveCharts.Wpf.Axis
            //{ Title = "Revenue",
            //LabelFormatter = value => value.ToString()
            //});

            //cartesianChart.LegendLocation = LiveCharts.LegendLocation.Bottom;

            dates = new List<string>();
            openingPrices = new List<double>();
            closingPrices = new List<double>();
            volumes = new List<int>();


            // cartesianChart.Series.Clear();

            btn_DownloadData.Enabled = false;

        }

        private void btn_DownloadData_Click(object sender, EventArgs e)
        {
            dates.Clear();
            openingPrices.Clear();
            closingPrices.Clear();
            volumes.Clear();


            dataChart.Series["Open"].Points.Clear();
            dataChart.Series["Close"].Points.Clear();
            dataChart.Series["Volume"].Points.Clear();

            cartesianChart.Series.Clear();

            string companyTag = textBox_CompanyTag.Text.ToString().ToLower();
            string startDate = date_Start.Value.ToString("yyyyMMdd");
            string stopDate = date_Stop.Value.ToString("yyyyMMdd");
            string urlAddress = String.Format("https://stooq.pl/q/d/l/?s={0}&d1={1}&d2={2}&i=d",
                companyTag, startDate, stopDate);

            dgv_Data.Columns.Clear();
            dgv_Data.Columns.Add("DATE", "Date");
            dgv_Data.Columns.Add("OPEN", "Opening Price");
            dgv_Data.Columns.Add("CLOSE", "Closing Price");
            dgv_Data.Columns.Add("VOLUME", "Volume");

            dgv_Data.Columns[0].Width = 100;
            dgv_Data.Columns[1].Width = 200;
            dgv_Data.Columns[2].Width = 200;
            dgv_Data.Columns[3].Width = 150;




            try
            {
                WebClient webClient = new WebClient();
                string s = webClient.DownloadString(urlAddress);


                string[] lines = s.Split('\n');

                for (int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] items = line.Trim().Split(',');

                    if (items.Length == 6)
                    {
                        string[] row = new string[4]
                        {
                            items[0], items [1],items[4], items[5]
                        };

                        dgv_Data.Rows.Add(row);

                        this.dataChart.Series["Open"].Points.AddXY(items[0], items[1]);
                        this.dataChart.Series["Close"].Points.AddXY(items[0], items[4]);
                        this.dataChart.Series["Volume"].Points.AddXY(items[0], items[5]);

                        dates.Add(items[0]);
                        openingPrices.Add(Double.Parse(items[1], CultureInfo.InvariantCulture));
                        closingPrices.Add(Double.Parse(items[4], CultureInfo.InvariantCulture));
                        volumes.Add(Int32.Parse(items[5]));



                        //openingPrices.Add(Double.Parse(items[1]));
                        //closingPrices.Add(Double.Parse(items[4]));
                        //volume.Add(Int32.Parse(items[5]));
                        //Series series = new Series;

                        //this.chartControl1.Series["Open"].Points.Add(items[0], Double.Parse(items[1]));
                        //this.chartControl1.Series["Close"].Points.Add(items[0], Double.Parse(items[4]));
                        //this.chartControl1.Series["Volume"].Points.Add(items[0], Double.Parse(items[1]));
                        // chart_Chart.Series = dgv_Data.Columns["CLOSE"]
                        //seriesOpen.ChartPoints.AddXY(items[0], Double.Parse(items[4], CultureInfo.InvariantCulture));
                        //chart_Chart.Series.Append(PointsArray items[1]);
                        // seriesVolume.ChartPoints.AddXY(items[0], Int32.Parse(items[5]));
                    }
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }



            //chart_Chart.AsChartValues() = openingPrices.AsChartValues();
            //chart_Chart.Series = openingPrices.AsChartValues();
            //closingPrices

            //    chart_Chart.Series.Append(openingPrices.Item);
            //    volume;


            //dvcChart.Visible = Enabled;

            //cartesianChart.Series.Clear();
            

            var openingPricesLine = new LiveCharts.ChartValues<double>();
            var closingPricesLine = new LiveCharts.ChartValues<double>();

            foreach (var item in openingPrices)
            {
                openingPricesLine.Add(item);
            }

            foreach (var item in closingPrices)
            {
                closingPricesLine.Add(item);
            }



            cartesianChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Opening Prices",
                    Values = openingPricesLine,
                    
                    
                },
                new LineSeries
                {
                    Title = "Closing Prices",
                    Values = closingPricesLine

                }

            };

           
            

            //cartesianChart.AxisX.Remove(cartesianChart.AxisX[0]);
            //MessageBox.Show(cartesianChart.AxisY.Count.ToString());
            //MessageBox.Show(cartesianChart.AxisX.Count.ToString());

            //cartesianChart.AxisX.Clear();
            //cartesianChart.AxisY.Clear();

            //MessageBox.Show("os Y po usnięciu " +cartesianChart.AxisY.Count.ToString());
            //MessageBox.Show("os X po usnięciu " + cartesianChart.AxisX.Count.ToString());

            //cartesianChart.AxisX.Clear();
            //MessageBox.Show("os X po usnięciu jeszcze raz " + cartesianChart.AxisX.Count.ToString());




            //cartesianChart.AxisX.Add(new Axis
            //{
            //    Title = "Date",


            //    LabelFormatter = value => value.ToString(),

            //    //Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" }
            //}); ;


            //cartesianChart.AxisY.Add(new Axis
            //{
            //    Title = "Price",
            //    LabelFormatter = value => value.ToString("C")
            //});

            //cartesianChart.LegendLocation = LegendLocation.Bottom;


            //cartesianChart2.AxisY.Add(new Axis
            //{
            //    Title = "sdfsf",
            //    LabelFormatter = value => value.ToString("C")
            //});

        }

        private void textBox_CompanyTag_TextChanged(object sender, EventArgs e)
        {
            if(textBox_CompanyTag.Text.Length == 3)
            {
                btn_DownloadData.Enabled = true;
            }
            else
            {

            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{


        //    /////////
        //    //cartesianChart1.Series = new SeriesCollection
        //    //{
        //    //    new LineSeries
        //    //    {
        //    //        Title = "Series 1",
        //    //        Values = new ChartValues<double> {4, 6, 5, 2, 7}
        //    //    },
        //    //    new LineSeries
        //    //    {
        //    //        Title = "Series 2",
        //    //        Values = new ChartValues<double> {6, 7, 3, 4, 6},
        //    //        PointGeometry = null
        //    //    },
        //    //    new LineSeries
        //    //    {
        //    //        Title = "Series 2",
        //    //        Values = new ChartValues<double> {5, 2, 8, 3},
        //    //        PointGeometry = DefaultGeometries.Square,
        //    //        PointGeometrySize = 15
        //    //    }
        //    //};

        //    //cartesianChart1.AxisX.Add(new Axis
        //    //{
        //    //    Title = "Month",
        //    //    Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" }
        //    //});

        //    //cartesianChart1.AxisY.Add(new Axis
        //    //{
        //    //    Title = "Sales",
        //    //    LabelFormatter = value => value.ToString("C")
        //    //});

        //    //cartesianChart1.LegendLocation = LegendLocation.Right;

        //    ////modifying the series collection will animate and update the chart
        //    //cartesianChart1.Series.Add(new LineSeries
        //    //{
        //    //    Values = new ChartValues<double> { 5, 3, 2, 4, 5 },
        //    //    LineSmoothness = 0, //straight lines, 1 really smooth lines
        //    //    PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
        //    //    PointGeometrySize = 50,
        //    //    PointForeground = Brushes.Gray
        //    //});

        //    ////modifying any series values will also animate and update the chart
        //    //cartesianChart1.Series[2].Values.Add(5d);


        //    //cartesianChart1.DataClick += CartesianChart1OnDataClick;


        //    /////////

        //    //cartesianChart.AxisX.AddRange(dates);
        //    //cartesianChart.AxisY.AddRange(openingPrices);
        //    //SeriesCollection series1 = new SeriesCollection();
        //    //foreach(string date in dates)
        //    //{
        //    //    series1.Add()


        //    //}
        //    //        cartesianChart.Series = new SeriesCollection
        //    //        {

        //    //            new LineSeries
        //    //            {
        //    //                 Values = new ChartValues<ObservableValue>
        //    //                 {
        //    //                   foreach (var item in openingPrices)
        //    //        {
        //    //            new ObservableValue(item);
        //    //        }
        //    //    }
        //    //}
        //    //            new ObservableValue(item);
        //    //        }
        //    //            }

        //    //            }
        //    //        };

        //}
    }
}
