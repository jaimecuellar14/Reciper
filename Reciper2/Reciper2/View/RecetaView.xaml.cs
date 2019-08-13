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
    public partial class RecetaView : ContentPage
    {

        string foto = "";
        string nombre = "";
        public string Foto { get { return foto; } }
        public string Nombre { get { return nombre; } }
        public RecetaView(RecetasModel receta)
        {
            InitializeComponent();
            getData(receta);
        }

        public void getData(RecetasModel receta)
        {
            foto = receta.fotoReceta;
            nombre = receta.nombreReceta;
        }
    }
}