using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Controls;

namespace FolderizerDesktop.Dictionaries
{
    public partial class Buttons : ResourceDictionary
    {
        private void Button_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if(e.HeightChanged)
            {
                if(sender is Button button)
                {
                    ButtonAssist.SetCornerRadius(button, new CornerRadius(e.NewSize.Height * 0.5));
                }
            }

        }

    }
}
