// Copyright (c) 0x5BFA. All rights reserved.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;

namespace DigitalSignaturesVisualizer
{
	public partial class App : Application
	{
		public static Window MainWindow { get; set; } = null!;

		public App()
		{
			InitializeComponent();
		}

		protected override void OnLaunched(LaunchActivatedEventArgs args)
		{
			MainWindow = new MainWindow();
			MainWindow.Activate();
		}
	}
}
