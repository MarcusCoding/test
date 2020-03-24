using FFImageLoading;
using Foundation;
using System;
using UIKit;

namespace test
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            ImageService.Instance.LoadUrl("https://66.media.tumblr.com/8f15a33da807eafa72caea30cf137ddc/tumblr_inline_p8id6u4n8o1qafrh6_250.gifv").Into(image);


        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}