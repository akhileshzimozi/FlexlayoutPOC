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
	public partial class Page4P2Tablet : ContentPage
	{
		public Page4P2Tablet ()
		{
			InitializeComponent ();

            SizeChanged += P4P2TabletSizeChanged;
		}

        private void P4P2TabletSizeChanged(object sender, EventArgs e)
        {
            bool isPortrait = this.Height >= this.Width;
            bool isLandscape = this.Width >= this.Height;
            ProfileImage.WidthRequest = 500;
            ProfileImage.HeightRequest = 500;

            if (isPortrait == true)
                {
                    StackPanel.Spacing = 50;
                    Username.FontSize = 30;
                    Address.FontSize = 30;
                    DOB.FontSize = 30;
                }
               
            
        }
    }
}