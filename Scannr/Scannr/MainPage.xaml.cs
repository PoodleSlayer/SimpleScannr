using Scannr.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Common;
using ZXing.Net.Mobile.Forms;

namespace Scannr
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			BindingContext = new MainPageViewModel();

			BarcodeText.SetBinding(Entry.TextProperty, nameof(ViewModel.BarcodeText));
			BarcodePresenter.SetBinding(ZXingBarcodeImageView.BarcodeValueProperty, nameof(ViewModel.BarcodeText));

			EncodingOptions barcodeOptions = new EncodingOptions();
			barcodeOptions.Height = 300;
			barcodeOptions.Width = 300;
			BarcodePresenter.BarcodeOptions = barcodeOptions;
		}

		private MainPageViewModel ViewModel
		{
			get
			{
				return this.BindingContext as MainPageViewModel;
			}
		}
	}
}
