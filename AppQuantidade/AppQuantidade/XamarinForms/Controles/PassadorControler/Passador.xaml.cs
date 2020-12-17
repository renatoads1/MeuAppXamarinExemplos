using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Controles.PassadorControler
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Passador : ContentPage
    {
        public Passador()
        {
            InitializeComponent();
        }

        private void ValueChanged(object sender, ValueChangedEventArgs e)
        {
            ValueChangedTextAtual.Text = e.NewValue.ToString();
            ValueChangedTextNovo.Text = e.NewValue.ToString();
            ValueChangedTextAntigo.Text = e.OldValue.ToString();
        }
    }
}