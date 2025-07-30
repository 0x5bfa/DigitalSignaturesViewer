// Copyright (c) 0x5BFA. All rights reserved.
// Licensed under the MIT License.

using Microsoft.UI.Input;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Windows.Graphics;

namespace DigitalSignaturesVisualizer
{
	public sealed partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			ExtendsContentIntoTitleBar = true;
			AppWindow.Resize(new(600, 800));

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
