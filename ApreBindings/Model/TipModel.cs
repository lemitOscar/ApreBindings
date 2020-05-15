using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ApreBindings
{

    //aqui es donde se hacen los modelos como los son las propiedades

    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    //uso la siguiente interfaz para actualizar los bindigs por que 
    //    ellos no saben cuando hay un cambio o ya se realizo algo
    public class TipModel : INotifyPropertyChanged
    {
        #region Implementación
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Properties
        public decimal Total { get; set; }
        public int Propina { get; set; }
        public int Nopersonas { get; set; }

        private decimal _Totalpropina;

        public decimal Totalpropina//propfull
        {
            get { return _Totalpropina; }
            set { _Totalpropina = value;
                OnPropertyChanged();
                }
        }


        private decimal _TotalconPropina;

        public decimal TotalconPropina
        {
            get { return _TotalconPropina; }
            set { _TotalconPropina = value;
                OnPropertyChanged();
            }
        }

        private decimal _PropinaPorPersna;

        public decimal PropinaPorPersna
        {
            get { return _PropinaPorPersna; }
            set { _PropinaPorPersna = value;
                 OnPropertyChanged();
            }
        }


        private decimal _TotalPorPersona;

        public decimal TotalPorPersona
        {
            get { return _TotalPorPersona; }
            set { _TotalPorPersona = value;
                OnPropertyChanged();
                }
        }

        #endregion

     

    }
}
