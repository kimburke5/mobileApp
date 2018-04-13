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
    /// A simple calculator app with the ability to add,
    /// subtract, multiple and divide numbers 
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        //Declare and initialize variables
        private double calc1 = 0.0, calc2 = 0.0;
        bool plusButtonClick = false, minusButtonClick = false, multiplyButtonClick = false, divideButtonClick = false;

        //button methods generated
        //button number 1
        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            calcBox.Text = calcBox.Text + "1";
        }
        //button number 2
        private void Button2_Click(object sender, RoutedEventArgs e)
        { 
           
            calcBox.Text = calcBox.Text + "2";
        }
        //button number 3
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
           

            calcBox.Text = calcBox.Text + "3";
        }
        //button number 4
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            

            calcBox.Text = calcBox.Text + "4";
        }
        //button number 5
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
           

            calcBox.Text = calcBox.Text + "5";
        }
        //button number 6
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
           
            calcBox.Text = calcBox.Text + "6";
        }
        //button for number 7
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            
            calcBox.Text = calcBox.Text + "7";
        }
        //button for number 8
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
             calcBox.Text = calcBox.Text + "8";
        }
        //button for number 9
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            calcBox.Text = calcBox.Text + "9";
        }
        //button for number 0
        private void Button0_Click(object sender, RoutedEventArgs e)
        {
           
            calcBox.Text = calcBox.Text + "0";
        }
        // + button
        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
           
            calc1 = calc1 += double.Parse(calcBox.Text);
            calcBox.Text = "";

            //resetting variable results
            plusButtonClick = true;
            minusButtonClick = false;
            multiplyButtonClick = false;
            divideButtonClick = false;
        }
        // - button
        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            calc1 = calc1 + double.Parse(calcBox.Text);
            calcBox.Text = "";

            plusButtonClick = false;
            minusButtonClick = true;
            multiplyButtonClick = false;
            divideButtonClick = false;
        }
        // x button
        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            calc1 = calc1 + double.Parse(calcBox.Text);
            calcBox.Text = "";

            plusButtonClick = false;
            minusButtonClick = false;
            multiplyButtonClick = true;
            divideButtonClick = false;
            
        }
        // / button
        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
           
            calc1 = calc1 + double.Parse(calcBox.Text);
            calcBox.Text = "";

            plusButtonClick = false;
            minusButtonClick = false;
            multiplyButtonClick = false;
            divideButtonClick = true;
        }

        //calculations of the operands
        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            
            if (plusButtonClick == true)
            {
                calc2 = calc1 + double.Parse(calcBox.Text);
                calcBox.Text = calc2.ToString();
                calc1 = 0;
            }
            else if (minusButtonClick == true)
            {
                calc2 = calc1 - double.Parse(calcBox.Text);
                calcBox.Text = calc2.ToString();
                calc1 = 0;
            }
            else if (multiplyButtonClick == true)
            {
                calc2 = calc1 * double.Parse(calcBox.Text);
                calcBox.Text = calc2.ToString();
                calc1 = 0;
            }
            else if (divideButtonClick == true)
            {
                calc2 = calc1 / double.Parse(calcBox.Text);
                calcBox.Text = calc2.ToString();
                calc1 = 0;
            }
        
        }

        // . decimal point button
        private void ButtonDecimal_Click(object sender, RoutedEventArgs e)
        {
            calcBox.Text += ".";
        }
        // clear button
        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {

            calcBox.Text = "";
        }


    }
}

