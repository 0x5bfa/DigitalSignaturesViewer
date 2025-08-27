// Copyright (c) 0x5BFA. All rights reserved.
// Licensed under the MIT License.

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DigitalSignaturesVisualizer
{
	public class DigitalSignaturesViewModel : ObservableObject
	{
		public ObservableCollection<DigitalSignatureItem> Items = [];

		private bool _PathIsSet;
		public bool PathIsSet { get => _PathIsSet; set => SetProperty(ref _PathIsSet, value); }

		public ICommand Back { get; }

		public DigitalSignaturesViewModel()
		{
			Back = new RelayCommand(ExecuteBackCommand);
		}

		private void ExecuteBackCommand()
		{
			Items.Clear();

			PathIsSet = false;
		}

		public void RefreshView(string path)
		{
			Items.Clear();

			if (string.IsNullOrEmpty(path))
				return;

			PathIsSet = true;

			// Example data
			Items.Add(new DigitalSignatureItem
			{
				Issuer = "Microsoft Corporation",
				DigestAlgorithm = "SHA256",
				Timestamp = DateTime.Now.ToString("o")
			});
			Items.Add(new DigitalSignatureItem
			{
				Issuer = "Example Issuer 2",
				DigestAlgorithm = "SHA512",
				Timestamp = DateTime.Now.AddMinutes(-10).ToString("o")
			});
			Items.Add(new DigitalSignatureItem
			{
				Issuer = "Example Issuer 2",
				DigestAlgorithm = "SHA512",
				Timestamp = DateTime.Now.AddMinutes(-10).ToString("o")
			});
			Items.Add(new DigitalSignatureItem
			{
				Issuer = "Example Issuer 2",
				DigestAlgorithm = "SHA512",
				Timestamp = DateTime.Now.AddMinutes(-10).ToString("o")
			});
			Items.Add(new DigitalSignatureItem
			{
				Issuer = "Example Issuer 2",
				DigestAlgorithm = "SHA512",
				Timestamp = DateTime.Now.AddMinutes(-10).ToString("o")
			});
			Items.Add(new DigitalSignatureItem
			{
				Issuer = "Example Issuer 2",
				DigestAlgorithm = "SHA512",
				Timestamp = DateTime.Now.AddMinutes(-10).ToString("o")
			});
			Items.Add(new DigitalSignatureItem
			{
				Issuer = "Example Issuer 2",
				DigestAlgorithm = "SHA512",
				Timestamp = DateTime.Now.AddMinutes(-10).ToString("o")
			});
		}
	}
}
