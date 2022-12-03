using System;
using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.Windows.Input;
using System.Text;
using Xamarin.Forms;
using ProyectoFinal_Movil.View;
using System.Runtime.InteropServices;
using ProyectoFinal_Movil.Model;
using ProyectoFinal_Movil.DataBase;

namespace ProyectoFinal_Movil.ViewModel
{
    internal class RegistroViewModel : Base
    {
        #region Atributos
        public string nom;
        public string correo;
        public string edad;
        public string peso;
        public string plan;
        public string user;
        public string pass;
        #endregion

        #region Propiedades
        public string txtNom
        {
            get { return nom; }
            set { SetValue(ref this.nom, value); }
        }
        public string txtCorreo
        {
            get { return correo; }
            set { SetValue(ref this.correo, value); }
        }
        public string Edad
        {
            get { return edad; }
            set { SetValue(ref this.edad, value); }
        }
        public string txtPeso
        {
            get { return peso; }
            set { SetValue(ref this.peso, value); }
        }
        public string txtPlan
        {
            get { return plan; }
            set { SetValue(ref this.plan, value); }
        }
        public string txtUser
        {
            get { return user; }
            set { SetValue(ref this.user, value); }
        }
        public string txtPass
        {
            get { return pass; }
            set { SetValue(ref this.pass, value); }
        }
        #endregion

        #region Commands
        public ICommand RegisterCommand
        {
            get
            {
                return new RelayCommand(Register);
            }
        }

        public ICommand RegresarCommand
        {
            get
            {
                return new RelayCommand(Regresar);
            }
        }
        #endregion

        #region Metodos
        public async void Register()
        {
            if (string.IsNullOrEmpty(this.nom) || string.IsNullOrEmpty(this.correo) || string.IsNullOrEmpty(this.edad) || string.IsNullOrEmpty(this.peso) || string.IsNullOrEmpty(this.plan) || string.IsNullOrEmpty(this.user) || string.IsNullOrEmpty(this.pass))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Digite todos los campos", "Aceptar");
                return;
            }
            var usuario = new UserModel
            {
                Name = nom,
                UserEmail = correo,
                UserAge = edad,
                UserWight = peso,
                UserPlan = plan,
                UserName = user,
                UserPass = pass

            };
            await App.Db.RegisterUserModelAsync(usuario);
            await Application.Current.MainPage.DisplayAlert("Registro", "Usuario Registrado Exitosamente", "Aceptar");
        }

        public async void Regresar()
        {
            await Application.Current.MainPage.DisplayAlert("Alerta", "¿Seguro desea descartar los cambios?", "Aceptar");
            await Application.Current.MainPage.Navigation.PushAsync(new Inicio());
        }
        #endregion
    }
}
