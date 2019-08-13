using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Text;
using Xamarin.Forms;

namespace Reciper2.ViewModel
{
    public class RecetasViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string mensajeBienvenida = "Bienvenido a recetas";
        List<int> numeros = new List<int> { 1, 2, 3 };
        public string mensaje
        {
            get { return mensajeBienvenida; }
            set { mensajeBienvenida = value; }
        }

        public List<int> test
        {
            get { return numeros; }
            set { numeros = value; }
        }
        
        
    }
}
