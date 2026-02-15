using Avalonia.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace p511_890.Views {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();


        }

        private void handleClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e) 
        {
            Content = "привет";
        }
    }
}