﻿using System;

using UIKit;

namespace CoursesIos
{
    public partial class CoursesViewController : UIViewController
    {
        public CoursesViewController() : base("CoursesViewController", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}