using System;
using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.Windows.Input;
using System.Text;
using Xamarin.Forms;
using ProyectoFinal_Movil.View;
using ProyectoFinal_Movil.Model;
using SQLite;
namespace ProyectoFinal_Movil.ViewModel
{
    internal class InicioViewModel : Base
    {
        #region Atributos
        public string user;
        public string pass;
        #endregion

        #region Propiedades
        public string txtUser
        {
            get { return user; }
            set { SetValue(ref this.user,value); }
        }
        public string txtPass
        {
            get { return pass; }
            set { SetValue(ref this.pass, value); }
        }
        #endregion

        #region Commands
        public ICommand LoguearCommand
        {
            get
            {
                return new RelayCommand(Loguear);
            }
        }
        #endregion

        #region Metodos
        public async void Loguear()
        {
            string _query = "SELECT * FROM UserModel WHERE UserName = '" + txtUser.ToString() + "' AND UserPass = '" + txtPass.ToString() + "' ";
            List<UserModel> ListUser = App.Db.QueryUserModel(_query).Result;
            if (ListUser.Count>0)
            {
                await Application.Current.MainPage.DisplayAlert("Bienvenido","Iniciando","Aceptar");
                await Application.Current.MainPage.Navigation.PushAsync(new PersonaPage());
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Inicio Incorrecto", "Aceptar");
            }
        }
        #endregion
    }
}
