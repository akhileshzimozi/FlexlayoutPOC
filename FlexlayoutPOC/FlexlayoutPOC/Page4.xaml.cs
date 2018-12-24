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
	public partial class Page4 : ContentPage
	{
		public Page4 ()
		{
			InitializeComponent ();

            SizeChanged += Page4SizeChanged;
		}

        private void Page4SizeChanged(object sender, EventArgs e)
        {
            bool isPortrait = this.Height >= this.Width;
            bool isLandscape = this.Width >= this.Height;



            if (Xamarin.Forms.Device.Idiom == TargetIdiom.Tablet)
            {
                if(isPortrait == true)
                {

                    FlexPanel.BackgroundColor = Color.Blue;
                    StackPanel.Orientation = StackOrientation.Vertical;
                    StackPanel.HorizontalOptions = LayoutOptions.CenterAndExpand;
                }
                if (isLandscape == true)
                {
                    FlexPanel.BackgroundColor = Color.Yellow;
                    StackPanel.Orientation = StackOrientation.Horizontal;
                    StackPanel.HorizontalOptions = LayoutOptions.CenterAndExpand;
                    StackPanel.Spacing = 100;
                }
                ProfileImage.WidthRequest = 300;
                ProfileImage.HeightRequest = 300;
                Username.FontSize = 32;
                Address.FontSize = 32;
                DOB.FontSize = 32;
            }

            if (Xamarin.Forms.Device.Idiom == TargetIdiom.Phone)
            {
                //ProfileImage.WidthRequest = 300;
                //ProfileImage.HeightRequest = 300;
                if (isPortrait == true)
                {
                    FlexPanel.BackgroundColor = Color.Red;

                }
                if (isLandscape == true)
                {
                    FlexPanel.BackgroundColor = Color.Purple;

                }

                Username.FontSize = 16;
                Address.FontSize = 16;
                DOB.FontSize = 16;
            }
        }
    }
}