using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Controles.CampoDeEntradaSimplesControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CampoDeEntradaSimples : ContentPage
    {
        public CampoDeEntradaSimples()
        {
            InitializeComponent();
        }

        private void Focus(object sender, FocusEventArgs e)
        {
            lblFocus.Text = "recebeu foco";
        }

        private void Unfocus(object sender, FocusEventArgs e)
        {
            lblUnfocus.Text = "perdeu o foco";
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            lblTextChanged.Text = e.NewTextValue + " cont:" + e.NewTextValue.Length; 
        }

        private void Completed(object sender, EventArgs e)
        {
            lblCompleted.Text = "Finalizado";
        }
    }
}