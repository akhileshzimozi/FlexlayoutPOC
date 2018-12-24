using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FlexlayoutPOC
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            SizeChanged += MainPageSizeChanged;
        }

        private void MainPageSizeChanged(object sender, EventArgs e)
        {
            bool isPortrait = this.Height >= this.Width;
            bool isLandscape = this.Width >= this.Height;
            
            stackPanel.Orientation = (isPortrait ? StackOrientation.Vertical : StackOrientation.Horizontal );
            
            //pool.WidthRequest = (Math.Min(this.Width, 400));
            pool.VerticalOptions = LayoutOptions.StartAndExpand;
            HelloPanel.WidthRequest = (isLandscape ? 500 : this.Height);

            if(Xamarin.Forms.Device.Idiom == TargetIdiom.Phone)
            {
                pool.WidthRequest = (isLandscape ? Math.Min(this.Width, 400): Math.Min(this.Width, 400));

            }

            if (Xamarin.Forms.Device.Idiom == TargetIdiom.Tablet)
            {
                pool.WidthRequest = (isLandscape ? Math.Min(this.Width, 800) : Math.Min(this.Width, 400));

            }
        }
    }
}
