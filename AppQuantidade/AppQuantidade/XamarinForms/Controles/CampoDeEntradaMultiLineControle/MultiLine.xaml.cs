using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Controles.CampoDeEntradaMultiLineControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MultiLine : ContentPage
    {
        public int contador = 300;
        public MultiLine()
        {
            InitializeComponent();
        }

        private void QuantCharDigit(object sender, TextChangedEventArgs e)
        {
            lblQuantidadeChar.Text = (contador - e.NewTextValue.Length).ToString();
        }
    }
}