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
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {   
            // if running and button was pressed then we want to stop hence change content appropriatly
            if( running )
            {
                tbStatus.Text = "Stopped";
                btnToggleRun.Content = "Run";
            }
            else
            {
                tbStatus.Text = "Running";
                btnToggleRun.Content = "stop"; 
            }
            running = !running; 
        }
    }
}