using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FolderizerDesktop.CustomControls.Steps
{
    /// <summary>
    /// Interaction logic for StepDefinition.xaml
    /// </summary>
    public partial class StepDefinition : UserControl
    {
        private bool _isActive;

        public StepDefinition()
        {
            InitializeComponent();
        }


        public string StepName
        {
            get => (string)StepNameLabel.Content;
            set => StepNameLabel.Content = value;
        }

        public string StepNumber
        {
            get => (string)StepNumberLabel.Content;
            set => StepNumberLabel.Content = value;
        }

        public bool IsLastStep
        {
            set
            {
                bool isLastStep = value;

                ConnectorToNextStep.Visibility = isLastStep
                    ? Visibility.Collapsed
                    : Visibility.Visible;
            }
        }
    }
}
