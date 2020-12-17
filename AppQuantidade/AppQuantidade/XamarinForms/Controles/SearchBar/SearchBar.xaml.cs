using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Controles.SearchBar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBar : ContentPage
    {
        public SearchBar()
        {
            InitializeComponent();
        }

        private void Eventodeentradadetext(object sender, TextChangedEventArgs e)
        {
            lblResultSearch.Text = e.NewTextValue.Length + " - " + e.NewTextValue;
        }

        private void EventoDePesquisa(object sender, EventArgs e)
        {
            lblResultSearch.Text = "clicou em pesquisar";
        }
    }
}