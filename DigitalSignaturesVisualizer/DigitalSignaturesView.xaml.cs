// Copyright (c) 0x5BFA. All rights reserved.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Imaging;
using System;
using Windows.ApplicationModel.DataTransfer;
using Windows.Storage;

namespace DigitalSignaturesVisualizer
{
	public sealed partial class DigitalSignaturesView : UserControl
	{
		public DigitalSignaturesViewModel ViewModel { get; } = new();

		public DigitalSignaturesView()
		{
			InitializeComponent();
		}

		private async void DigitalSignaturesView_Drop(object sender, DragEventArgs e)
		{
			if (e.DataView.Contains(StandardDataFormats.StorageItems))
			{
				var items = await e.DataView.GetStorageItemsAsync();
				if (items.Count is 1 && items[0] is StorageFile file)
				{
					ViewModel.RefreshView(file.Path);
				}
			}
			else
			{
				e.AcceptedOperation = DataPackageOperation.None;
			}
		}

		private void Grid_DragOver(object sender, DragEventArgs e)
		{
			e.AcceptedOperation = DataPackageOperation.Copy;
			e.DragUIOverride.Caption = "Drop to view digital signatures";
		}

		private void TitleBar_BackRequested(TitleBar sender, object args)
		{
			ViewModel.Back.Execute(null);
		}
	}
}
