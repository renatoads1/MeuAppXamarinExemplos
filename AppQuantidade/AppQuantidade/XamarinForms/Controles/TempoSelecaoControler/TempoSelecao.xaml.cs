using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Controles.TempoSelecaoControler
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TempoSelecao : ContentPage
    {
        public TempoSelecao()
        {
            InitializeComponent();
        }

        private void TimeAlterado(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            lblResult.Text = "Hora alterada "+((TimePicker)sender).Time.ToString("HH:mm");
        }
    }
}