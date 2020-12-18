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

        private void LayoutAbsoluto(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.AbsoluteLayout.Absoluto();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void LayoutRelativo(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.RelativeLayout.Relativo();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void LayoutFlexivel(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.FlexLayout.Flexivel();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void ScrollView(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.BarraDeRolagemLayout.BarraDeRolagem();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void ContentView(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.ControleLayout.Controle();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void FrameView(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.QuadradoLayout.Quadrado();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void BoxView(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.CaixaControle.Caixa();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void LabelRotulo(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.RotuloControle.Rotulo();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void Botao(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.BotaoControle.Botao();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void BotaoImage(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.BotaoImagemControle.BotaoImagem();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void Image(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.ImagemControle.Imagem();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void cdes(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.CampoDeEntradaSimplesControle.CampoDeEntradaSimples();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void MultiLine(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.CampoDeEntradaMultiLineControle.MultiLine();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void CheckBox(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.CaixaDeSelecaoControle.CaixaDeMarcacao();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void RadioButton(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.CaixaDeRadioControler.CaixaDeRadio();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void Switch(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.InterruptorControler.Interruptor();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void Steper(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.PassadorControler.Passador();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void Slider(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.DeslisanteControler.Deslisante();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void Picker(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.SelecaoControler.Selecao();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void DatePicker(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.DatePicker.DatePicker();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void TimePicker(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.TempoSelecaoControler.TempoSelecao();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void IndicadorAtividade(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.IndicadorDeAtividadeControler.IndicadorDeAtividade();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void ProgressBarr(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.ProgressBarrControler.ProgressBarr();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void SearchBar(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.SearchBar.SearchBar();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void RefreshView(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.RefreshView.RefreshView();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void Arrasta(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.ArrastaControler.Arrasta();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void Navegador(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.NavegadorControler.Navegador();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void MediaPage(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.MediaControler.Media();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void Expanssor(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.ExpanssorControler.Expanssor();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void TableView(object sender, EventArgs e)
        {
            //chama a nova pagina no menu
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Listas.TabelaControle.Tabela();
            //recolhe o menu
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }
    }
}