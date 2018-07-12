using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            this.barcodeImage.BarcodeOptions = new ZXing.Common.EncodingOptions()
            {
                Height = 300,
                Width = 300
            };
            this.barcodeImage.BarcodeValue = Guid.NewGuid().ToString();
        }
    }
}