// Copyright (c) 0x5BFA. All rights reserved.
// Licensed under the MIT License.

using Microsoft.UI.Xaml.Controls;

namespace DigitalSignaturesVisualizer
{
	public sealed partial class DigitalSignaturesView : UserControl
	{
		public DigitalSignaturesViewModel ViewModel { get; } = new();

		public DigitalSignaturesView()
		{
			InitializeComponent();
		}
	}
}
