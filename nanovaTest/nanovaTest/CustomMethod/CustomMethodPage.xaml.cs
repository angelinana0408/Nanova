using nanovaTest.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text.RegularExpressions;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using WinRTXamlToolkit.Controls.DataVisualization.Charting;

namespace nanovaTest.CustomMethod
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class CustomMethodPage : Page
    {
        //control CONFIG and STATUS button
        private int ClickStatus = 0;
        //control Calculation button
        private int ClickCalculationStatus = 0;

        private string x_axis = "x_axis";
        private string y_axis = "y_axis";

        private ObservableCollection<ChartData> topDatas;//上图的数据集合
        private ObservableCollection<ChartData> bottomDatas;//下图的数据集合
        //折线图数据模型
        class ChartData
        {
            public double label { get; set; }//x
            public double text { get; set; }//y
        }

        private CycleData c;
        private int total;
        private DispatcherTimer timer;
        public CustomMethodPage()
        {
            this.InitializeComponent();
            CustomUtils.SetCustomTitleBar(GridTitleBar);
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += App_BackRequested;
            initTopChart();
        }


        private void App_BackRequested(object sender,BackRequestedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame == null)
                return;

            if (rootFrame.CanGoBack && e.Handled == false)
            {
                e.Handled = true;
                rootFrame.GoBack();
            }
        }

        private void Config_Click(object sender, RoutedEventArgs e)
        {
            if(ClickStatus == 1)
            {
                ConfigImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/config-tab-t.png"));
                ConfigText.Foreground = new SolidColorBrush(CustomUtils.GetColorFromHex("#007DC4"));
                StatusImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/status-tab-f.png"));
                StatusText.Foreground = new SolidColorBrush(CustomUtils.GetColorFromHex("#808080"));
                ConfigGrid.Visibility = Visibility.Visible;
                StatusGrid.Visibility = Visibility.Collapsed;
                ClickStatus = 0;
            }
        }
        //设置和状态切换状态点击事件
        private void Status_Click(object sender, RoutedEventArgs e)
        {
            if(ClickStatus == 0)
            {
                ConfigImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/config-tab-f.png"));
                ConfigText.Foreground = new SolidColorBrush(CustomUtils.GetColorFromHex("#808080"));
                StatusImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/status-tab-t.png"));
                StatusText.Foreground = new SolidColorBrush(CustomUtils.GetColorFromHex("#007DC4"));
                ConfigGrid.Visibility = Visibility.Collapsed;
                StatusGrid.Visibility = Visibility.Visible;
                ClickStatus = 1;
            }
        }
        //开始和停止按钮点击方法
        private void Calculation_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(this.ExperienceName.Text))
            {
                NotifyPopup notifyPopup = new NotifyPopup("Experience Name cannot be empty.");
                notifyPopup.Show();
                return;
            }
            if(string.IsNullOrWhiteSpace(this.SamplingTimeText.Text))
            {
                NotifyPopup notifyPopup = new NotifyPopup("Sampling Time cannot be empty.");
                notifyPopup.Show();
                return;
            }
            //SamplingTimeText WaitTimeText HighestTempText 
            //    HighHoldingTimeText LowHoldingTimeText RampSpeedText

            //    BeginTimeText1 EndTimeText1
            if(ClickCalculationStatus == 0)
            {
                CalcButtonImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/stop-button.png"));
                CalcTestText.Text = "STOP";
                ClickCalculationStatus = 1;
                StartCountDown();
            } else {
                CalcButtonImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/start-button.png"));
                CalcTestText.Text = "START";
                ClickCalculationStatus = 0;
                timer.Stop();
                c.Update(0, 1000);
                Value = 0;
            }
            
        }

        private void StartCountDown()
        {
            //总的计算剩余时间，现暂支持秒
            total = 100;
            c = new CycleData();
            c.data = new DoubleCollection() { 0, 1000 };
            c.i = total;
            timer = new DispatcherTimer()
            {
                Interval = new TimeSpan(0, 0, 1)
            };
            Rount.StrokeDashArray = c.data;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, object e)
        {
            c.i--;
            Value = c.i;
            c.Update((total - c.i) / (double)total * 95 / 5 * Math.PI, 1000);
            
            //更新折线图
            Random r = new Random();
            topDatas.Add(new ChartData() {label = total - c.i,text = r.Next(100)});
            bottomDatas.Add(new ChartData() {label = total - c.i,text = r.Next(100)});

            if (c.i == 0)
            {
                (sender as DispatcherTimer).Stop();
            }
        }

        public class CycleData : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            private int _i;

            private DoubleCollection _data;

            public DoubleCollection data
            {
                get { return _data; }
                set { _data = value; }
            }

            public String count
            {
                get { return _i.ToString(); }
                set
                {
                    _i = Convert.ToInt32(value);

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(""));
                }
            }

            public int i
            {
                get { return _i; }
                set
                {
                    _i = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(""));
                }
            }

            public void Update(double v, double p)
            {
                this._data.Clear();
                _data.Add(v);
                _data.Add(p);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(""));
            }
        }


        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
            "Value", typeof(double), typeof(MainPage), new PropertyMetadata(default(double)));

        public double Value
        {
            get
            {
                return (double)GetValue(ValueProperty);
            }
            set
            {
                SetValue(ValueProperty, value);
            }
        }

        private void RountProgress_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void initTopChart()
        {
            topDatas = new ObservableCollection<ChartData>();
            bottomDatas = new ObservableCollection<ChartData>();
        }
    }
}
