using ProyectoFinal_Movil.Model;
using ProyectoFinal_Movil.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProyectoFinal_Movil.ViewModel
{
    public class PersonaViewModel:PersonasModel 
    {
        public ObservableCollection<PersonasModel> Personas { get; set; }
        PersonasServicios servicio = new PersonasServicios();
        PersonasModel modelo;
        public PersonaViewModel()
        {
            Personas = servicio.Consultar();
            GuardarCommand = new Command(async() => await Guardar(), () => !Isbusy);
            ModificarCommand = new Command(async () => await Modificar(), () => !Isbusy);
            EliminarCommand = new Command(async () => await Eliminar(), () => !Isbusy);
            LimpiarCommand = new Command(Limpiar, () => !Isbusy);
        }

        public Command GuardarCommand { get; set; }
        public Command ModificarCommand { get; set; }
        public Command EliminarCommand { get; set; }
        public Command LimpiarCommand { get; set; }

        private async Task Guardar()
        {
            Isbusy = true;
            Guid IdPersona=Guid.NewGuid();

            modelo = new PersonasModel()
            {
                Nombre = Nombre,
                Apellido = Apellido,
                Edad = Edad,
                Fecha = Fecha,
                Hora = Hora,
                Id = IdPersona.ToString()
            };
            await Application.Current.MainPage.DisplayAlert("Guardando", "Clase Reservada Exitosamente", "Aceptar");
            servicio.Guardar(modelo);
            await Task.Delay(2000);           
            Isbusy = false;
        }

        private async Task Modificar()
        {
            Isbusy = true;

            modelo = new PersonasModel()
            {
                Nombre = Nombre,
                Apellido = Apellido,
                Edad = Edad,
                Fecha = Fecha,
                Hora = Hora,
                Id = Id
            };
            await Application.Current.MainPage.DisplayAlert("Modificando", "Modificación Exitosa", "Aceptar");
            servicio.Modificar(modelo);
            await Task.Delay(2000);            
            Isbusy = false;
        }

        private async Task Eliminar()
        {
            Isbusy = true;
            await Application.Current.MainPage.DisplayAlert("Eliminando", "Reservada Eliminada Exitosamente", "Aceptar");
            servicio.Eliminar(Id);            
            await Task.Delay(2000);
            Isbusy = false;
        }

        private void Limpiar()
        {
            Nombre = "";
            Apellido = "";
            Edad = 0;
            Fecha = "";
            Hora = "";
            Id = "";
        }
    }
}
