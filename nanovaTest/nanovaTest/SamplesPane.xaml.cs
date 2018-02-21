using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace nanovaTest
{
    public sealed partial class SamplesPane : UserControl
    {
        public SamplesPane()
        {
            this.InitializeComponent();
        }

        private void NavigateToAbout(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("1111111");
        }

        private void NavigateToExit(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("2222222");
        }
    }
}
