using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Controles.ProgressBarrControler
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgressBarr : ContentPage
    {
        double cont = 0.0;
        public ProgressBarr()
        {
            InitializeComponent();
        }

        private void IniciaProgresBarr(object sender, EventArgs e)
        {
            
                cont += 0.1;
                ProgresAnimada.ProgressTo(cont,500,Easing.BounceOut);
            
            
        }
    }
}