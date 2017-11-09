using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace ColorPicker {
    public partial class MainPage : ContentPage {

        private readonly ColorPickerPopup _colorPickerPopup;
        
        public MainPage() {
            InitializeComponent();

            _colorPickerPopup = new ColorPickerPopup();
            _colorPickerPopup.ColorChanged += ColorPickerPopupOnColorChanged;
        }

        private async void Button_OnClicked(object sender, EventArgs e) {

            await Navigation.PushPopupAsync(_colorPickerPopup);
        }

        private void ColorPickerPopupOnColorChanged(object sender, ColorChangedEventArgs args) {

            BoxView.Color = args.Color;
        }
    }
}
