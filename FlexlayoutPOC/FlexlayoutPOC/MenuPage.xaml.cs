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
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page1());

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page2());

        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page3());

        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page4());

        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page4Part2());

        }
    }
}