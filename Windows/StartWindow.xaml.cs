using FolderizerDesktop.Windows;
using System.Windows;

namespace FolderizerDesktop
{
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            new AudioOrganizerSetUpWindow().Show();
            this.Close();
        }
    }
}
