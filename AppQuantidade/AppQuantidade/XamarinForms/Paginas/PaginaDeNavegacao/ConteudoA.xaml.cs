using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Paginas.PaginaDeNavegacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConteudoA : ContentPage
    {
        public ConteudoA()
        {
            InitializeComponent();
        }

        private void PaginaB(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaDeNavegacao.ConteudoB());
        }

        private void Paginac(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaDeNavegacao.ConteudoC());
        }
    }
}