using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UD5T2.MVVM.Models;

namespace UD5T2.MVVM.ViewModels
{
    internal class BMIViewModel
    {
        // Establecemos la propiedad BMI
        public BMI BMI
        {
            get; set;
        }

        public BMIViewModel()
        {
            // Creacion del objeto BMI
            BMI = new BMI();
            // Establecemos un valor para la propiedad Peso
            BMI.Peso = 50;
            // Establecemos un valor para la propiedad Altura
            BMI.Altura = 25;
        }
    }
}
