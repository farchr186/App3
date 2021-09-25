using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Aplicacion2.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        private string _nombre;
        private string _apellido1;
        private string _apellido2;

        
        public string FullName => $"{Nombre} {Apellido1} {Apellido2}";

        public string Nombre
        {

            

            get => _nombre;
            set
            {
                if(string.Equals(_nombre, value)) return;
                _nombre = value;
                RaisePropertyChanged(nameof(Nombre));
            }
        }

        public string Apellido1
        {
            get => _apellido1;
            set
            {
                _apellido1 = value;
                RaisePropertyChanged(nameof(Apellido1));
            }
        }
        public string Apellido2
        {
            get => _apellido2;
            set
            {
                _apellido2 = value;
                RaisePropertyChanged(nameof(Apellido2));
            }
        }
    }
}
