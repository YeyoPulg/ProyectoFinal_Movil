using ProyectoFinal_Movil.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal_Movil.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
            BindingContext = new RegistroViewModel();
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    //REGISTRAR USUARIO

        //}

        //async void Button_Clicked_1(object sender, EventArgs e)
        //{
        //    //REGRESAR AL INICIO
        //    await Navigation.PushAsync(new Inicio());
        //}
    }
}