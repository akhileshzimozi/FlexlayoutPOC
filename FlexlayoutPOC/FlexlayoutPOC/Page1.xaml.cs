using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlexlayoutPOC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            SizeChanged += (sender, args) =>
            {
                string visualState = Width > Height ? "Landscape" : "Portrait";
                VisualStateManager.GoToState(mainStack, visualState);


            };
        }

    }
}
