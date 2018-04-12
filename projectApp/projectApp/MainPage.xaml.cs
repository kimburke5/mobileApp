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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace projectApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        //Declare and initialize variables
        private double calc1 = 0, calc2 = 0;
        bool plusButtonClick = false, minusButtonClick = false, multiplyButtonClick = false, divideButtonClick = false;

        //button methods generated
        //adding functionality to methods
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            calcBox.Text = calcBox.Text + "1";
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            calcBox.Text = calcBox.Text + "2";
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            calcBox.Text = calcBox.Text + "3";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            calcBox.Text = calcBox.Text + "4";
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            calcBox.Text = calcBox.Text + "5";
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            calcBox.Text = calcBox.Text + "6";
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            calcBox.Text = calcBox.Text + "7";
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            calcBox.Text = calcBox.Text + "8";
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            calcBox.Text = calcBox.Text + "9";
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            calcBox.Text = calcBox.Text + "0";
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButtonPercent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void ButtonDecimal_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            
        }


    }
}
