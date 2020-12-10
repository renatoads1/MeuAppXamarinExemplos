using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Controles.CaixaDeSelecaoControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CaixaDeMarcacao : ContentPage
    {
        public CaixaDeMarcacao()
        {
            InitializeComponent();
        }

        private void ClicouNoCheckBox(object sender, CheckedChangedEventArgs e)
        {
            lblClicou.Text = e.Value ? "marcado" : "Desmarcado";
        }
    }
}