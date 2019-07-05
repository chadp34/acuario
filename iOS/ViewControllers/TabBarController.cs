using System;
using UIKit;

namespace acuario.iOS
{
    public partial class TabBarController : UITabBarController
    {
        public TabBarController(IntPtr handle) : base(handle)
        {
            TabBar.Items[0].Title = "Collection";
            TabBar.Items[1].Title = "About";
        }
    }
}
