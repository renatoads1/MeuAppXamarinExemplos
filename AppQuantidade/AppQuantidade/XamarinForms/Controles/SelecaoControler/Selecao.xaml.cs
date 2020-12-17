using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Controles.SelecaoControler
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Selecao : ContentPage
    {
        public Selecao()
        {
            InitializeComponent();
        }

        private void onSelectEventChanged(object sender, EventArgs e)
        {
           string a  =  ((Picker)sender).SelectedIndex + " - " + ((Picker)sender).SelectedItem;
            lblPicker.Text = a;
        }
    }
}