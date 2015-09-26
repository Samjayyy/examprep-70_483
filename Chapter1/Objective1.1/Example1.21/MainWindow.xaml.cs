using System.IO;
using System.Net.Http;
using System.Text;
using System.Windows;

namespace Example1._21
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void OnButtonClick(object sender, RoutedEventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            string content = await httpClient.GetStringAsync("http://www.microsoft.com").ConfigureAwait(false);

            using (FileStream sourceStream = new FileStream("temp.html", FileMode.Create, FileAccess.Write, FileShare.None, 4096, useAsync: true))
            {
                byte[] encodedText = Encoding.Unicode.GetBytes(content);
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length).ConfigureAwait(false);
            }

            MessageBox.Show(@"temp.html created in ...\bin\Debug");
        }
    }
}
