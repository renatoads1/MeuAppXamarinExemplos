using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Layouts.ControleLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardHorizontal : ContentView
    {

        private string _titulo;
        private string _texto;
        private Color _cor;


        public string Titulo { get { return _titulo; } set { _titulo = value; carTitulo.Text = _titulo; } }
        public string Texto { get { return _texto; } set { _texto = value; cardTexto.Text = _texto; } }
        public Color cor { get { return _cor; } set { _cor = value; card.BackgroundColor = _cor; } }
        public CardHorizontal()
        {
            InitializeComponent();

            card.BackgroundColor = cor;
            carTitulo.Text = Texto;
            cardTexto.Text = Titulo;
        }
    }
}