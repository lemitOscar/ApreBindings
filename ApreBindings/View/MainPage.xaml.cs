using ApreBindings.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ApreBindings
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new MainPageViewModel();
            //a qui le dingo donde esta el contexto o los datos que necesita y estan en tipmodel
        }

    
    }
}
