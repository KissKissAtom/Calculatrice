using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculatrice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private decimal Num1 = 0.0m;
        private decimal Num2 = 0.0m;
        private decimal Resultat = 0.0m;
        private string operation = "";
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_1(object sender, RoutedEventArgs e)
        {
            if(textBox_resultat.Text == "0")
            {
                textBox_resultat.Text = "1";
            }
            else
            {
                textBox_resultat.Text += "1";
            }
        }

        private void Button_2(object sender, RoutedEventArgs e)
        {
            if (textBox_resultat.Text == "0")
            {
                textBox_resultat.Text = "2";
            }
            else
            {
                textBox_resultat.Text += "2";
            }
        }

        private void Button_3(object sender, RoutedEventArgs e)
        {
            if (textBox_resultat.Text == "0")
            {
                textBox_resultat.Text = "3";
            }
            else
            {
                textBox_resultat.Text += "3";
            }
        }

        private void Button_4(object sender, RoutedEventArgs e)
        {
            if (textBox_resultat.Text == "0")
            {
                textBox_resultat.Text = "4";
            }
            else
            {
                textBox_resultat.Text += "4";
            }
        }

        private void Button_5(object sender, RoutedEventArgs e)
        {
            if (textBox_resultat.Text == "0")
            {
                textBox_resultat.Text = "5";
            }
            else
            {
                textBox_resultat.Text += "5";
            }
        }

        private void Button_6(object sender, RoutedEventArgs e)
        {
            if (textBox_resultat.Text == "0")
            {
                textBox_resultat.Text = "6";
            }
            else
            {
                textBox_resultat.Text += "6";
            }
        }

        private void Button_7(object sender, RoutedEventArgs e)
        {
            if (textBox_resultat.Text == "0")
            {
                textBox_resultat.Text = "7";
            }
            else
            {
                textBox_resultat.Text += "7";
            }
        }

        private void Button_8(object sender, RoutedEventArgs e)
        {
            if (textBox_resultat.Text == "0")
            {
                textBox_resultat.Text = "8";
            }
            else
            {
                textBox_resultat.Text += "8";
            }
        }

        private void Button_9(object sender, RoutedEventArgs e)
        {
            if (textBox_resultat.Text == "0")
            {
                textBox_resultat.Text = "9";
            }
            else
            {
                textBox_resultat.Text += "9";
            }
        }

        private void Button_0(object sender, RoutedEventArgs e)
        {
            if (textBox_resultat.Text == "0")
            {
                textBox_resultat.Text = "0";
            }
            else
            {
                textBox_resultat.Text += "0";
            }
        }

        private void Button_Virgule(object sender, RoutedEventArgs e)
        {
            if(!textBox_resultat.Text.Contains(','))
            {
                textBox_resultat.Text += ",";
            }
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            Num1 = decimal.Parse(textBox_resultat.Text);
            textBox_resultat.Clear();
            operation = "+";
        }

        private void Button_Moins(object sender, RoutedEventArgs e)
        {
            Num1 = decimal.Parse(textBox_resultat.Text);
            textBox_resultat.Clear();
            operation = "-";
        }

        private void Button_Divise(object sender, RoutedEventArgs e)
        {
            Num1 = decimal.Parse(textBox_resultat.Text);
            textBox_resultat.Clear();
            operation = "/";
        }

        private void Button_Multi(object sender, RoutedEventArgs e)
        {
            Num1 = decimal.Parse(textBox_resultat.Text);
            textBox_resultat.Clear();
            operation = "*";
        }

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            textBox_resultat.Text = "0";
        }

        private void Button_Egal(object sender, RoutedEventArgs e)
        {

            switch (operation)
            {
                case "-":
                    Num2 = decimal.Parse(textBox_resultat.Text);
                    Resultat = Num1 - Num2;
                    textBox_resultat.Text = Resultat.ToString();
                    break;

                case "+":
                    Num2 = decimal.Parse(textBox_resultat.Text);
                    Resultat = Num1 + Num2;
                    textBox_resultat.Text = Resultat.ToString();
                    break;

                case "*":
                    Num2 = decimal.Parse(textBox_resultat.Text);
                    Resultat = Num1 * Num2;
                    textBox_resultat.Text = Resultat.ToString();
                    break;

                case "/":
                    if (Num2 != 0)
                    {
                        Num2 = decimal.Parse(textBox_resultat.Text);
                        Resultat = Num1 / Num2;
                        textBox_resultat.Text = Resultat.ToString();
                        break;
                    }
                    else
                    {
                        throw new DivideByZeroException("Impossible de diviser avec 0");
                    }
                default:
                    throw new ArgumentException("Opération Invalide");
                    
                

            }



            

        }

     

       
    }
}
