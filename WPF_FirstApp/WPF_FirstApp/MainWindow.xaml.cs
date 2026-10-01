using System.Windows;

namespace WPF_FirstApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool running = false; 
        public MainWindow()
        {
            InitializeComponent();

            // access the component using the name and change it's properties
            tbHello.Text = "Bye World";

            // static action which change button content as soon as ap starts
            btnRun.Content = "Stop"; 
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            tbHello.Text = "Running";
            running = true; 
        }
    }
}