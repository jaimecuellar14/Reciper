using Newtonsoft.Json;
using Reciper2.Model;
using Reciper2.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Reciper2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecetasView : ContentView
    {

        ObservableCollection<RecetasModel> recetas = new ObservableCollection<RecetasModel>();
        public ObservableCollection<RecetasModel> Recetas { get { return recetas; } }
        public string mensaje { get { return "Bienvenidos a recetas";  }  }
        public string testReceta { get; set; }
        
        public RecetasView()
        {
            InitializeComponent();
            BindingContext = this;
            ListaRecetas.ItemsSource = recetas;
            Test2();
        }
        
       
        public async void Test2()
        {


            recetas.Add(new RecetasModel { nombreReceta = "pollo" , fotoReceta = "https://www.centrovallereal.com/wp-content/uploads/sites/38/2017/08/VR-recetas-pollo-1.jpg" });
            recetas.Add(new RecetasModel { nombreReceta = "carne", fotoReceta = "https://www.atable.es/wp-content/uploads/2016/12/bien-848x477.jpg" });
            recetas.Add(new RecetasModel { nombreReceta = "pescado", fotoReceta = "http://www.annarecetasfaciles.com/files/merluza-en-salsa-verde-3.jpg" });
            recetas.Add(new RecetasModel { nombreReceta = "ensalada", fotoReceta = "https://e0605b5e794e16b15e51-b25f5db3158ecf712705ad7a35f2aa8a.ssl.cf3.rackcdn.com/ensalada-de-tofu-y-calabacin-a-la-plancha-80-1290-742-nw.jpg" });

        }

        private async void ListaRecetas_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            ListaRecetas.ItemSelected += null;
            RecetasModel selectedItem = e.Item as RecetasModel;
            var recetaView = new RecetaView();
            recetaView.BindingContext = selectedItem;
            await Navigation.PushAsync(recetaView,true);

        }

        
       /* private void ImageCell_Tapped(object sender, EventArgs e)
        {
            var item = (ViewCell)sender;
            item.View.BackgroundColor = Color.Transparent;
            
        }*/
    }
}