using System;

using TizenSpecific = Xamarin.Forms.PlatformConfiguration.Tizen;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;

namespace Sample.Wizard.Views
{
    public partial class MainPage : ContentPage
    {
        // Supports a circular button that can contain image.
        // Note, Ignored even if text is set.
        public MainPage()
        {
            InitializeComponent();

            // Only Tizen platform is supported to set the style in VisualElement(Button).
            // Sets the default display of the button to the circle style.
            // API Spec: https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.platformconfiguration.tizenspecific.buttonstyle?view=xamarin-forms
            denyButton.On<TizenSpecific>().SetStyle(ButtonStyle.Circle);
            confirmButton.On<TizenSpecific>().SetStyle(ButtonStyle.Circle);
        }
    }
}
