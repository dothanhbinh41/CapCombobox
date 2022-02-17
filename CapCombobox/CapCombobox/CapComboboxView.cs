using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CapCombobox
{
    public class CapComboboxView : ContentView
    {
        public CapComboboxView()
        {
            BackgroundColor = Color.Yellow;
            Content = new Button { Text = "Click me Now" };
            if (Content is Button btn)
            {
                btn.Clicked += Btn_Clicked;
            }
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            var popup = new ComboboxPopup(X, Y, Width, Height);
            var width = Xamarin.Essentials.DeviceDisplay.MainDisplayInfo.Width / Xamarin.Essentials.DeviceDisplay.MainDisplayInfo.Density;
            PopupNavigation.Instance.PushAsync(popup, false);
        }
    }
}
