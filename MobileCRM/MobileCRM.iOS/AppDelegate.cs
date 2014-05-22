﻿using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.Forms;
using Xamarin;
using MobileCRM.Views;

namespace MobileCRM.iOS
{
    [Register ("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        UIWindow window;

        public override bool FinishedLaunching (UIApplication app, NSDictionary options)
        {
            window = new UIWindow (UIScreen.MainScreen.Bounds);
            
            MobileCRM.Init(typeof(MobileCRM).Assembly);
            Forms.Init();
            FormsMaps.Init();

            window.RootViewController = BuildView();
            window.MakeKeyAndVisible ();
            
            return true;
        }

        static UIViewController BuildView()
        {
            var root = new RootPage();
            var controller = root.CreateViewController();
            return controller;
        }
    }
}
