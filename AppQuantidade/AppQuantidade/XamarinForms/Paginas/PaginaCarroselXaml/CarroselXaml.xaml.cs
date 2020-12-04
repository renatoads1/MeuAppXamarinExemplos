using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Paginas.PaginaCarroselXaml
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarroselXaml : CarouselPage
    {
        public CarroselXaml()
        {
            InitializeComponent();
            //faz com qua a primeira página seja a de numero 2
            //CurrentPage = this.Children[1];
        }
    }
}