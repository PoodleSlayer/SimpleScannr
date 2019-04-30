using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scannr.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
		public RelayCommand CreateCommand;
		public RelayCommand ScanCommand;

		public MainPageViewModel()
		{
			SetupCommands();
		}

		private void SetupCommands()
		{
			CreateCommand = new RelayCommand(() => 
			{
				// open the barcode scanner
			});

			ScanCommand = new RelayCommand(() =>
			{
				// somehow generate a QR code from the text, oh boy
			});
		}

		private string barcodeText;
		public string BarcodeText
		{
			get => barcodeText;
			set
			{
				if (!String.IsNullOrEmpty(value))
				{
					barcodeText = value;
					RaisePropertyChanged(nameof(BarcodeText));
				}
			}
		}
	}
}
