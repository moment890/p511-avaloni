using Avalonia.Controls;
using Avalonia.Interactivity;
using System;


namespace p511_890.Views {
    public partial class MainWindow : Window 
        {
        private string currentOperator = "";
        private double firstOperand = 0;


        public MainWindow() {
            
            InitializeComponent();
        }


        private void Number_Click(object sender, RoutedEventArgs e) {
            var button = sender as Button;
            Display.Text += button.Content.ToString();
        }

        private void Operation_Click(object sender, RoutedEventArgs e) {
            if (!string.IsNullOrEmpty(Display.Text)) {
                firstOperand = double.Parse(Display.Text);
                currentOperator = ((Button)sender).Content.ToString();
                Display.Clear();
            }
        }

        private void Calculate_Click(object sender, RoutedEventArgs e) {
            try {
                if (!string.IsNullOrEmpty(currentOperator) && !string.IsNullOrEmpty(Display.Text)) {
                    double secondOperand = double.Parse(Display.Text);
                    switch (currentOperator) {
                        case "+":
                            Display.Text = (firstOperand + secondOperand).ToString();
                            break;
                        case "-":
                            Display.Text = (firstOperand - secondOperand).ToString();
                            break;
                        case "*":
                            Display.Text = (firstOperand * secondOperand).ToString();
                            break;
                        case "/":
                            if (secondOperand != 0)
                                Display.Text = (firstOperand / secondOperand).ToString();
                            else
                                Display.Text = "Ошибка деления";
                            break;
                    }
                    firstOperand = 0;
                    currentOperator = "";
                }
            } catch (Exception ex) {
                
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e) {
            Display.Clear();
            firstOperand = 0;
            currentOperator = "";
        }

    }
    
}