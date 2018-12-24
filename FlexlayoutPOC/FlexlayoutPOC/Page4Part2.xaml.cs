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
	public partial class Page4Part2 : ContentPage
	{
		public Page4Part2 ()
		{
			InitializeComponent ();

            SizeChanged += P4P2SizeChange;
		}

        private void P4P2SizeChange(object sender, EventArgs e)
        {
            if(Xamarin.Forms.Device.Idiom == TargetIdiom.Tablet)
            {
                //App.Current.MainPage = new NavigationPage(new Page4P2Tablet());
                Navigation.PopModalAsync();
                Navigation.PushModalAsync(new Page4P2Tablet());
                

            }
        }
    }
}