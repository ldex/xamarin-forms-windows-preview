using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace WorkingWithColors.iOS
{
	[Foundation.Register("AppDelegate")]
	public partial class AppDelegate : FormsApplicationDelegate
	{
		UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			Forms.Init ();

            LoadApplication(new WorkingWithColors.App());
			
			return base.FinishedLaunching(app, options);
		}
	}
}

