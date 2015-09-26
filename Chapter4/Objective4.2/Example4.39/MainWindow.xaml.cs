using Example4._39.ServiceReference1;
using System.Windows;

namespace Example4._39
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MyServiceClient client;

        public MainWindow()
        {
            InitializeComponent();
            this.client = new ServiceReference1.MyServiceClient();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            this.ResultTexxtBox.Text = await this.client.DoWorkAsync("John", "Doe");
        }
    }
}
