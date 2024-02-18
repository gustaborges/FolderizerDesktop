using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace FolderizerDesktop.CustomControls.Steps
{

    [ContentProperty(nameof(Steps))]
    public partial class StepsControl : UserControl
    {
        public StepsControl()
        {
            InitializeComponent();
            Steps = StepsHolder.Children;
        }

        public static readonly DependencyPropertyKey StepsProperty = DependencyProperty.RegisterReadOnly(
            name: nameof(Steps),
            propertyType: typeof(UIElementCollection),
            ownerType: typeof(StepsControl),
            typeMetadata: new PropertyMetadata());

        public UIElementCollection Steps
        {
            get
            {
                return (UIElementCollection)GetValue(StepsProperty.DependencyProperty);
            }
            set
            {
                SetValue(StepsProperty, value);
            }
        }

    }

}
