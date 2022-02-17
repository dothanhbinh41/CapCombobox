using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CapCombobox
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComboboxPopup : PopupPage
    {
        public ComboboxPopup()
        {
            InitializeComponent();
            content.SizeChanged += Content_SizeChanged;
        }

        private void Content_SizeChanged(object sender, EventArgs e)
        {
            var size = content.Width;
        }

        double x, y, w, h;
        public ComboboxPopup(double x, double y, double w, double h) : this()
        {
            this.x = x;
            this.y = y;
            this.w = w;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            content.TranslateTo(x, y,length:0);
            content.WidthRequest = w;
            ForceLayout();
        }
    }
}