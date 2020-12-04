using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Paginas.Modal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConteudoMod01 : ContentPage
    {
        public ConteudoMod01()
        {
            InitializeComponent();
        }

        private void ChamaModal(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Modal());
        }
    }
}