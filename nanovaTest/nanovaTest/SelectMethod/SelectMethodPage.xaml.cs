using nanovaTest.Calibrate;
using nanovaTest.Utils;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace nanovaTest.SelectMethod
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class SelectMethodPage : Page
    {
        public SelectMethodPage()
        {
            this.InitializeComponent();
            CustomUtils.SetCustomTitleBar(GridTitleBar);
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += App_BackRequested;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter.ToString() != "True")
            {
                Frame.Navigate(typeof(CalibratePage), "FromSelect");
            }
        }

        private void App_BackRequested(object sender, BackRequestedEventArgs e)
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
        //TVOC
        private void Button_TVOC_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(TVOCPage), true);
        }
        //BTEX
        private void Button_BTEX_Click(object sender, RoutedEventArgs e)
        {

        }
        //MTBE
        private void Button_MTBE_Click(object sender, RoutedEventArgs e)
        {

        }
        //TCE/PCE
        private void Button_TCE_Click(object sender, RoutedEventArgs e)
        {

        }
        //Malodorous Gas
        private void Button_MG_Click(object sender, RoutedEventArgs e)
        {

        }
        //Vehicle Indoor
        private void Button_VI_Click(object sender, RoutedEventArgs e)
        {

        }
        //Environmental Air
        private void Button_EA_Click(object sender, RoutedEventArgs e)
        {

        }
        //Pollution Source
        private void Button_PS_Click(object sender, RoutedEventArgs e)
        {

        }
        //Water Sample-Online
        private void Button_Water_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
