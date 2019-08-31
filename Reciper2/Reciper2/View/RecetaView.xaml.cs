using Reciper2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Json;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Microsoft.CSharp.RuntimeBinder;


namespace Reciper2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecetaView : ContentPage
    {
        ObservableCollection<RecetaModel> recetasList = new ObservableCollection<RecetaModel>();
        public ObservableCollection<RecetaModel> RecetasList { get { return recetasList; } }


        public RecetaView()
        {
            InitializeComponent();
            this.BindingContext = this;
            listadoRecetas.ItemsSource = recetasList;
            getRecipes();


        }
       /* protected async override void OnAppearing()
         {
             getRecipes();
             base.OnAppearing();
         }*/
        public async void getRecipes()
        {

            var tipoReceta = this.BindingContext as RecetasModel;
            if(tipoReceta != null)
            {
                string appID = "407f28ba";
                string appKey = "54a3b85e8834fbe960cd9af21bd6c914";

                string url = "";

                  switch (tipoReceta.nombreReceta)
                  {
                      case "pollo":
                          url = "https://api.edamam.com/search?q=chicken&app_id=$" + appID + "&app_key=$" + appKey;
                          break;
                      case "carne":
                          url = "https://api.edamam.com/search?q=meat&app_id=$" + appID + "&app_key=$" + appKey;
                          break;
                      case "pescado":
                          url = "https://api.edamam.com/search?q=fish&app_id=$" + appID + "&app_key=$" + appKey;
                          break;
                      case "ensalada":
                          url = "https://api.edamam.com/search?q=salad&app_id=$" + appID + "&app_key=$" + appKey;
                          break;
                  }


                 HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(url));
                 request.ContentType = "application/json";
                 request.Method = "GET";
                 

                 using (WebResponse response =  await request.GetResponseAsync())
                 {
                    using (Stream stream = response.GetResponseStream())
                    {
                        JsonValue jsonDoc = await Task.Run(() => JsonObject.Load(stream));
                        var jsonString = jsonDoc.ToString();
                        dynamic objetoRecetas = JsonConvert.DeserializeObject(jsonString);
                        var listadoRecetas = objetoRecetas.hits;
                        foreach(dynamic receta in listadoRecetas)
                            {
                            dynamic rec = receta.recipe;
                            string nombre = rec.label;
                            string imagen = rec.image;
                            string calorias = rec.calories;
                            recetasList.Add(new RecetaModel { nombre = nombre, imagen= imagen, calorias = calorias});
                            }
                        // await DisplayAlert("Alert", jsonDoc, "OK");
                     }
                 }

            }
        }
    }
}