using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //chama as paginas com botões
            //var pagina = new NavigationPage(
            //        new XamarinForms.Paginas.PaginaDeConteudo.PaginaDeConteudo01() 
            //    );
            //MainPage = pagina;
            //########################## paginas de modal
            //MainPage = new XamarinForms.Paginas.Modal.ConteudoMod01();
            //########################## pagina de carrosel
            //var pagina = new CarouselPage();
            //pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrosel.PageCarrosel01());
            //pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrosel.PageCarrosel02());
            //pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrosel.PageCarrosel03());
            //pagina.CurrentPage = pagina.Children[1];
            //MainPage = pagina;
            //MainPage = new XamarinForms.Paginas.PaginaCarroselXaml.CarroselXaml();
            //########################## pagina de abas tabpage
            //MainPage = new XamarinForms.Paginas.PaginaDeAbas.Abas();
            //########################## master detail page
            //var pagina = new MasterDetailPage();
            //########################## menu - recebe a pagina que fica os elementos do menu
            //pagina.Master =  new ContentPage();
            //########################## conteudo - recebe as paginas que são chamadas
            //pagina.Detail = new ContentPage();

            // pagina de menu lateral
            //MainPage = new XamarinForms.Paginas.PaginaDeMenuLateral.MenuLateral();
            //menu que chama todas as paginas
            MainPage = new AppBase.Menu();


        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
