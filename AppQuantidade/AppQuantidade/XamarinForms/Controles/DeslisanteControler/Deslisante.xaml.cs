using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Controles.DeslisanteControler
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Deslisante : ContentPage
    {
        public Deslisante()
        {
            InitializeComponent();
        }

        private void MudaComponente(object sender, ValueChangedEventArgs e)
        {
            lblMudaComponente.Text = e.NewValue.ToString();
            //arredondando
            ((Slider)sender).Value = (Math.Round(e.NewValue / 1)*1);

        }

        private void FinalizouArrasto(object sender, EventArgs e)
        {
            lblFinalizouArrasto.Text = "Finalizou o arrasto";
        }
    }
}