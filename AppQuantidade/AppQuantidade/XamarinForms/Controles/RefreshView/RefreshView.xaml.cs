using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Controles.RefreshView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RefreshView : ContentPage
    {
        public RefreshView()
        {
            InitializeComponent();
        }

        private void EventodeRefresh(object sender, EventArgs e)
        {
            int cont = 0;
            cont++;
            lblStatus.Text = "Atualizado" + cont;
            lblStatus.TextColor = Color.Green;
            //parar o refreshing mas esta dando erro por culpa do nome da clase e do method
            //((RefreshView)sender).IsRefreshing = false;
        }
    }
}