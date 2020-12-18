using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Listas.TabelaControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tabela : ContentPage
    {
        public Tabela()
        {
            InitializeComponent();
        }

        private void MudaCorTexrt(object sender, ToggledEventArgs e)
        {
        }
    }
}