using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.AppBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

 

        private void Home(object sender, EventArgs e)
        {
            //((MasterDetailPage)App.Current.MainPage).Detail = XamarinForms.Paginas.
        }

        private void Perfil(object sender, EventArgs e)
        {

        }

        private void ContentPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeConteudo.PaginaDeConteudo01();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void CarroselPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeCarrosel.PageCarrosel01();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }
        private void PaginaDeNavegacao(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail =new NavigationPage( new XamarinForms.Paginas.PaginaDeNavegacao.ConteudoA());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;

        }

        private void TabbedPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeAbas.Abas();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void MasterDetailPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeMenuLateral.MenuLateral();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void PaginaDeModal(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.Modal.Modal();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void LayoutDePilha(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.PilhaLayout.PageDePilha();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void LayoutDeGrade(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.GradeLayouts.Grade();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }
    }
}