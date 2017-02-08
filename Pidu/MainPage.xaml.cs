using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Pidu
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Korter korter1 = new Korter();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void LisaButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBox1.Text))
            {
            korter1.lisaInimene(TextBox1.Text);
            TextBox1.Text = "";
            TextBlock1.Text = korter1.kuvaInimesed();  
            }
            else
            {
                var dialog = new MessageDialog("TextBox ei tohi olla tühi!");
                dialog.ShowAsync();
            }
        }

        private void EemaldaButton_Click(object sender, RoutedEventArgs e)
        {
            korter1.eemaldaInimene(TextBox1.Text);
            TextBox1.Text = "";
            TextBlock1.Text = korter1.kuvaInimesed();

        }
    }
}
