using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Paginas.PaginaDeMenuLateral
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MLConteudo01 : ContentPage
    {
        public MLConteudo01()
        {
            InitializeComponent();
        }

        private void AbreMenuLateral(object sender, EventArgs e)
        {
            //sender quiser colocar botão para abrir menu lateral
            ((MasterDetailPage)App.Current.MainPage).IsPresented = true;
        }
    }
}