using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace UD5T2.MVVM.Models
{
    
    public class BMI : INotifyPropertyChanged
    {
        private float altura;
        private float peso;

        // Evento que se lanza cuando la propiedad cambia
        public event PropertyChangedEventHandler? PropertyChanged;

        // Establecemos la propiedad Altura
        public float Altura
        {
            get { return altura; }
            set
            {
                altura = value;
                // LLamadas al método para comprobar si las propiedades han cambiado
                OnPropertyChanged(nameof(Altura));
                OnPropertyChanged(nameof(Resultado));
                OnPropertyChanged(nameof(ResultadoBMI));
            }
        }

        // Establecemos la propiedad Peso
        public float Peso
        {
            get { return peso; }
            set
            {
                peso = value;
                // LLamadas al método para comprobar si las propiedades han cambiado
                OnPropertyChanged(nameof(Peso));
                OnPropertyChanged(nameof(Resultado));
                OnPropertyChanged(nameof(ResultadoBMI));
            }
        }

        // Establecemos la propiedad Resultado
        public float Resultado
        {
            // Definimos el get que nos devolvera el resultado obtenido según el peso y la altura
            get
            {
                return Peso / (Altura * Altura) * 10000;
            }
        }

        // Establecemos la propiedad Resultado
        public String ResultadoBMI
        {
            // Definimos el get que nos devolvera un mensaje según el resultado obtenido
            get
            {
                if (Resultado <= 16 )
                {
                    return "BMI: Delgado Severo";
                } 
                else if (Resultado <= 17)
                {
                    return "BMI: Delgado Moderado";
                } 
                else if (Resultado <= 18.5)
                {
                    return "BMI: Delgado Medio";
                }
                else if (Resultado <= 25)
                {
                    return "BMI: Normal";
                }
                else if (Resultado <= 30)
                {
                    return "BMI: Sobrepeso";
                }
                else if (Resultado <= 35)
                {
                    return "BMI: Obesiddad Clase I";
                }
                else if (Resultado <= 40)
                {
                    return "BMI: Obesidad Clase II";
                }
                else
                {
                    return "BMI: Obesidad Clase III";
                }

            }
        }

        // Invoca a el evento cuando una propiedad cambia
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


    }
}
