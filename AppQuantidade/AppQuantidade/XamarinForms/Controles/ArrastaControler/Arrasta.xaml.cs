using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Controles.ArrastaControler
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Arrasta : ContentPage
    {
        public Arrasta()
        {
            InitializeComponent();
        }

        private void SwipeDetalhe(object sender, EventArgs e)
        {
            lblDetalhe.Text = $"Acionou:{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";
        }

        private void SwipeEdit(object sender, EventArgs e)
        {
            lblEditar.Text = $"Acionou:{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";
        }

        private void SwipeExcluir(object sender, EventArgs e)
        {
            lblExcluir.Text = $"Acionou:{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";
        }
    }
}