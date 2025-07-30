// Copyright (c) 0x5BFA. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSignaturesVisualizer
{
	public class DigitalSignaturesViewModel
	{
		public ObservableCollection<DigitalSignatureItem> Items = [];

		public DigitalSignaturesViewModel()
		{
			// Example data
			Items.Add(new DigitalSignatureItem
			{
				Issuer = "Example Issuer 1",
				DigestAlgorithm = "SHA256",
				Timestamp = DateTime.Now.ToString("o")
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
