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
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();

            SizeChanged += Page3SizeChanged;
		}

        private void Page3SizeChanged(object sender, EventArgs e)
        {
            bool isPortrait = this.Height >= this.Width;
            bool isLandscape = this.Width >= this.Height;
            ScrollPanel.Orientation = (isPortrait ? ScrollOrientation.Vertical : ScrollOrientation.Horizontal);
            StackPanel.Orientation = (isPortrait ? StackOrientation.Vertical : StackOrientation.Horizontal);

            if(Xamarin.Forms.Device.Idiom == TargetIdiom.Phone)
            {
                if(StackPanel.Orientation == StackOrientation.Vertical)
                {
                    AccentBV.WidthRequest = 80;
                    AccentBV.HeightRequest = 200;

                    BlackBV.WidthRequest = 80;
                    BlackBV.HeightRequest = 200;

                    RedBV.WidthRequest = 80;
                    RedBV.HeightRequest = 200;

                    BeigeBV.WidthRequest = 80;
                    BeigeBV.HeightRequest = 200;

                    YellowBV.WidthRequest = 80;
                    YellowBV.HeightRequest = 200;

                    BlueBV.WidthRequest = 80;
                    BlueBV.HeightRequest = 200;
                }

                if (StackPanel.Orientation == StackOrientation.Horizontal)
                {
                    AccentBV.WidthRequest = 400;
                    AccentBV.HeightRequest = 200;

                    BlackBV.WidthRequest = 400;
                    BlackBV.HeightRequest = 200;

                    RedBV.WidthRequest = 400;
                    RedBV.HeightRequest = 200;

                    BeigeBV.WidthRequest = 400;
                    BeigeBV.HeightRequest = 200;

                    YellowBV.WidthRequest = 400;
                    YellowBV.HeightRequest = 200;

                    BlueBV.WidthRequest = 400;
                    BlueBV.HeightRequest = 200;
                }
            }

            if (Xamarin.Forms.Device.Idiom == TargetIdiom.Tablet)
            {
                if(StackPanel.Orientation == StackOrientation.Vertical)
                {
                    AccentBV.WidthRequest = 100;
                    AccentBV.HeightRequest = 300;

                    BlackBV.WidthRequest = 100;
                    BlackBV.HeightRequest = 300;

                    RedBV.WidthRequest = 100;
                    RedBV.HeightRequest = 300;

                    BeigeBV.WidthRequest = 100;
                    BeigeBV.HeightRequest = 300;

                    YellowBV.WidthRequest = 100;
                    YellowBV.HeightRequest = 300;

                    BlueBV.WidthRequest = 100;
                    BlueBV.HeightRequest = 300;
                }

                if (StackPanel.Orientation == StackOrientation.Horizontal)
                {
                    AccentBV.WidthRequest = 500;
                    AccentBV.HeightRequest = 300;

                    BlackBV.WidthRequest = 500;
                    BlackBV.HeightRequest = 300;

                    RedBV.WidthRequest = 500;
                    RedBV.HeightRequest = 300;

                    BeigeBV.WidthRequest = 500;
                    BeigeBV.HeightRequest = 300;

                    YellowBV.WidthRequest = 500;
                    YellowBV.HeightRequest = 300;

                    BlueBV.WidthRequest = 500;
                    BlueBV.HeightRequest = 300;
                }
            }

        }
    }
}