using Reciper2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Reciper2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InformacionReceta : ContentPage
    {
        public InformacionReceta()
        {
            InitializeComponent();
            //var receta = this.BindingContext as RecetaModel;
           // listaIngredientes.ItemsSource = receta.ingredientes;
        }
    }
}