using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Controles.ImagemControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Imagem : ContentPage
    {
        public Imagem()
        {
            InitializeComponent();
            
            csanos.Source = ImageSource.FromResource("AppQuantidade.XamarinForms.Controles.ImagemControle.57anos.png");
        }
    }
}