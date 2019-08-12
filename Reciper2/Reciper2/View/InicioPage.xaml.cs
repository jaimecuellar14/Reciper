using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace Reciper2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioPage : Xamarin.Forms.TabbedPage
    {
           
        public InicioPage()
        {
            InitializeComponent();
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            NavigationPage.SetHasBackButton(this, false);
        }
    }
}