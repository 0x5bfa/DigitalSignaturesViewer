// Copyright (c) 0x5BFA. All rights reserved.
// Licensed under the MIT License.

using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;

namespace DigitalSignaturesVisualizer
{
	public sealed partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			ExtendsContentIntoTitleBar = true;
			AppWindow.Resize(new(480, 600));

			if (AppWindow.Presenter is OverlappedPresenter overlapped)
			{
				overlapped.IsMaximizable = false;
				overlapped.IsMinimizable = true;
				overlapped.IsResizable = false;
				overlapped.IsAlwaysOnTop = true;
			}
		}
	}
}
