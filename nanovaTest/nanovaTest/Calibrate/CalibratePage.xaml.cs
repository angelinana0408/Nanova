using nanovaTest.Utils;
using System;
using System.Diagnostics;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace nanovaTest.Calibrate
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class CalibratePage : Page
    {
        private string NavigateParameter = null;
        public CalibratePage()
        {
            this.InitializeComponent();
            CustomUtils.SetCustomTitleBar(GridTitleBar);
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += App_BackRequested;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if(e.Parameter.ToString() != "True")
            {
                NavigateParameter = (string)e.Parameter;
            }
        }

        private void App_BackRequested(object sender, BackRequestedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame == null)
                return;
            if (NavigateParameter == null)
            {
                if (rootFrame.CanGoBack && e.Handled == false)
                {
                    e.Handled = true;
                    rootFrame.GoBack();
                }
                
            } else
            {
                Debug.WriteLine("******************:{0}", Frame.BackStack.Count);
                Frame.BackStack.RemoveAt(0);
                Frame.BackStack.RemoveAt(Frame.BackStack.Count - 1);
                Frame.Navigate(typeof(MainPage));
            }

            
        }
    }
}
