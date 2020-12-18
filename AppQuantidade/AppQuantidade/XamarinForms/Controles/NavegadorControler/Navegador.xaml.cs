
using System.IO;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Controles.NavegadorControler
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Navegador : ContentPage
    {
        public Navegador()
        {
            InitializeComponent();

            //var html = new HtmlWebViewSource();
            //html.Html = "<html><head><h1>Renato de Azevedo</h1></head></html>";
            //webview2.Source = html;
            //var endereco = new UrlWebViewSource();

            var endereco = new UrlWebViewSource();
            var urlbase = DependencyService.Get<IBaseUrl>().Get();
            endereco.Url = urlbase;
            webview3.Source = endereco;
            


        }

        private void btnVoltar(object sender, System.EventArgs e)
        {
            if (webview3.CanGoBack) {
                webview3.GoBack();
            }
        }

        private void btnAtualizar(object sender, System.EventArgs e)
        {
            webview3.Reload();
        }

        private void btnProximo(object sender, System.EventArgs e)
        {
            if (webview3.CanGoForward) {
                webview3.GoForward();
            }
        }

        private void Carregado(object sender, WebNavigatedEventArgs e)
        {
            lblStatus.Text = "carregando...";
        }

        private void Carregando(object sender, WebNavigatingEventArgs e)
        {
            lblStatus.Text = "carregado!!!";
            Thread.Sleep(1000);
            lblStatus.Text = e.Url.ToString();
        }
    }
}