using ProyectoFinal_Movil.Model;
using ProyectoFinal_Movil.ViewModel;
using ProyectoFinal_Movil.View;
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
    public partial class PersonaPage : ContentPage
    {
        PersonaViewModel contex = new PersonaViewModel();

        public PersonaPage()
        {
            InitializeComponent();
            BindingContext = contex;
            L_Personas.ItemSelected += L_Personas_ItemSelected;
        }

        private void L_Personas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null)
            {
                PersonasModel modelo = (PersonasModel)e.SelectedItem;
                //Navigation.PushAsync(new Detalles(modelo));
                contex.Nombre = modelo.Nombre;
                contex.Apellido = modelo.Apellido;
                contex.Edad = modelo.Edad;
                contex.Id = modelo.Id;
            }
        }
    }
}