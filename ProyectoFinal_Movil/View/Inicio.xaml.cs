using ProyectoFinal_Movil.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal_Movil.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
            BindingContext = new InicioViewModel();
        }

        //async void Button_Clicked(object sender, EventArgs e)
        //{
        //    //INICIAR SESIÓN
        //    await Navigation.PushAsync(new PersonaPage());
        //}

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            //REGISTRAR USUARIO
            await Navigation.PushAsync(new Registro());
        }

        //private void Button_Clicked_2(object sender, EventArgs e)
        //{

        //}
    }
}