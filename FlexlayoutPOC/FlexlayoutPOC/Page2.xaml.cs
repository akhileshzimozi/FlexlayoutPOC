using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlexlayoutPOC
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();

            SizeChanged += Page2SizeChanged;
        }

        private void Page2SizeChanged(object sender, EventArgs e)
        {
            bool isPortrait = this.Height >= this.Width;
            bool isLandscape = this.Width >= this.Height;
            FlexFrame.Direction = (isPortrait ?   FlexDirection.Column : FlexDirection.Row );
            FlexFrame.JustifyContent = (isLandscape ? FlexJustify.Center : FlexJustify.Start);
        }
    }
}