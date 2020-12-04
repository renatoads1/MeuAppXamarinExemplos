using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Paginas.PaginaDeConteudo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaDeConteudo01 : ContentPage
    {
        public PaginaDeConteudo01()
        {
            InitializeComponent();
        }

        private void PaginaA(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaDeNavegacao.ConteudoA());
        }
    }
}