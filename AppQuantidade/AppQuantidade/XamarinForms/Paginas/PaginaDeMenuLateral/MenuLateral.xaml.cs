using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Paginas.PaginaDeMenuLateral
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuLateral : MasterDetailPage
    {
        public MenuLateral()
        {
            InitializeComponent();
        }

        private void MenuA(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MLConteudo01());
            //fecha menu após chamar a pagina 
            IsPresented = false;
        }
        private void MenuB(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MLConteudo02());
            IsPresented = false;
        }
        private void MenuC(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MLConteudo03());
            IsPresented = false;
        }

        
    }
}