using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Controles.BotaoControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Botao : ContentPage
    {
        public Botao()
        {
            InitializeComponent();
        }

        private void Precionado(object sender, EventArgs e)
        {
            lblprecionado.Text = "precionado";
            
        }

        private void Liberado(object sender, EventArgs e)
        {
            lblliberado.Text = "liberado";
        }

        private void Clicado(object sender, EventArgs e)
        {
            lblclicado.Text = "clicado";
        }

    }
}