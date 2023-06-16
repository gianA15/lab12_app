using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace lab12_app.ViewModel
{
    public class OperacionesViewModel : ViewModelBase
    {
        int valorA;
        public int ValorA
        {
            get { return valorA; }
            set
            {
                if (valorA != value)
                {
                    valorA = value;
                    OnPropertyChanged();
                }
            }
        }

        int valorB;
        public int ValorB
        {
            get { return valorB; }
            set
            {
                if (valorB != value)
                {
                    valorB = value;
                    OnPropertyChanged();
                }
            }
        }


        int resultadoArea;
        public int ResultadoArea
        {
            get { return resultadoArea; }
            set
            {
                if (resultadoArea != value)
                {
                    resultadoArea = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultadoPerimetro;
        public int ResultadoPerimetro
        {
            get { return resultadoPerimetro; }
            set
            {
                if (resultadoPerimetro != value)
                {
                    resultadoPerimetro = value;
                    OnPropertyChanged();
                }
            }
        }




        public ICommand CalcularArea { get; set; }
        public ICommand CalcularPerimetro { get; set; }


        public OperacionesViewModel()
        {

            CalcularArea = new Command(() =>
            {
                ResultadoArea = ValorA * ValorB;
            });
            CalcularPerimetro = new Command(() =>
            {
                ResultadoPerimetro = 2 * (ValorA + ValorB);
            });
        }
    }
}
