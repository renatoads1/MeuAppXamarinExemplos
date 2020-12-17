using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Controles.InterruptorControler
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Interruptor : ContentPage
    {
        public Interruptor()
        {
            InitializeComponent();
        }

        private void Trocou(object sender, ToggledEventArgs e)
        {
            lblSwitch.Text = e.Value ? "marcado" : "Desmarcado";
        }
    }
}