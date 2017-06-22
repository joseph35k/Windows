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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.

            
        }

      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0"||(operation_pressed))
                result.Text = "";
                Button b = (Button)sender;
              
                operation_pressed = false;
                result.Text +=b.Content.ToString();
            
        }

        private void operator_click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            operation = b.Content.ToString();
            value = Double.Parse(this.result.Text);
            operation_pressed = true;
            set_operation.Text = value + "\n" + operation;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            set_operation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                default :
                    break;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            value = 0;
            this.result.Text = "0";
        }

      
        private void MainApp(object sender, RoutedEventArgs e)
        {
            MainPage m1 = new MainPage();
        }
    }
}
