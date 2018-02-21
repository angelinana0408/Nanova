using System;
using nanovaTest.Calibrate;
using nanovaTest.Utils;
using System.Diagnostics;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.Foundation;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;

namespace nanovaTest.SelectMethod
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class TVOCPage : Page
    {
        public TVOCPage()
        {
            this.InitializeComponent();
            CustomUtils.SetCustomTitleBar(GridTitleBar);
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += App_BackRequested;
            if(!CustomUtils.CheckCalibrate())
            {
                ShowDialog();
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter == typeof(string))
            {

            }
        }

        private async void ShowDialog()
        {
            var dialog = new MessageDialog("Calibrate needed");
            dialog.Title = "Alert";
            dialog.Commands.Add(new UICommand("Go to calibrate.", cmd => { }, commandId: 0));
            dialog.Commands.Add(new UICommand("Test any way.(Not recommended)", cmd => { }, commandId: 1));
            IUICommand result = await dialog.ShowAsync();
            dialog.DefaultCommandIndex = 0;
            dialog.CancelCommandIndex = 1;

            if ((int)result.Id == 0)
            {
                Frame.Navigate(typeof(CalibratePage), "FromSelect");
                //if (this.Frame.CanGoBack)
                //{
                //    this.Frame.GoBack();
                //}
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
    }
}
