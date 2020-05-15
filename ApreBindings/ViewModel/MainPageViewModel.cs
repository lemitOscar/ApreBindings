using System;
using System.Collections.Generic;
using System.Text;


namespace ApreBindings.ViewModel
{
    using Xamarin.Forms;
    public class MainPageViewModel//aqui es donde ya se hacen las operaciones
    {
        public TipModel tipModel { get; set; }
        public Command OperacionCommand { get; set; }
        public MainPageViewModel()
        {
            OperacionCommand = new Command(Dooperation);
            tipModel = new TipModel
            {
                Propina = 5,
                Nopersonas = 2
            };
        }
        private void Dooperation()//ctrl+h  usar los break point
        {
            tipModel.Totalpropina = (tipModel.Total * tipModel.Propina) / 100;

            tipModel.TotalconPropina = tipModel.Totalpropina + tipModel.Total;

            tipModel.PropinaPorPersna = tipModel.Totalpropina / tipModel.Nopersonas;

            tipModel.TotalPorPersona = (tipModel.Total + tipModel.Totalpropina) / tipModel.Nopersonas;
        }
    }
}
