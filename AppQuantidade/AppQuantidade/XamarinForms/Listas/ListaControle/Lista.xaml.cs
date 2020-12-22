using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Listas.ListaControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista : ContentPage
    {
        public Lista()
        {
            InitializeComponent();
            Lista01.ItemsSource = GetMarcas();

        }

        private List<Marca> GetMarcas(){
            return new List<Marca>()
            {
                GetListaCarrosFiat(),
                GetListaCarrosFord()
            };
        }
        private Marca GetListaCarrosFiat()
        {
           var fiat =  new Marca()
            {
                new carro{Nome = "moby" , Motorizacao = "1.0", ItendeSerie = "vidro eletrico",Descricao = "Rosa"},
                new carro{Nome = "toro" , Motorizacao = "1.1", ItendeSerie = "trava eletrica",Descricao = "verde"},
                new carro{Nome = "Siena" , Motorizacao = "1.2", ItendeSerie = "air Bag",Descricao = "Branco"},
                new carro{Nome = "Vectra" , Motorizacao = "1.3", ItendeSerie = "Direção eletrico",Descricao = "Amarelo"},

            };
            fiat.Nome = "Fiat";
            return fiat;
        }
        private Marca GetListaCarrosFord()
        {
            var ford = new Marca()
            {
                new carro{Nome = "Gol" , Motorizacao = "1.0", ItendeSerie = "vidro eletrico",Descricao = "Rosa"},
                new carro{Nome = "Fox" , Motorizacao = "1.1", ItendeSerie = "trava eletrica",Descricao = "verde"},
                new carro{Nome = "Fusca" , Motorizacao = "1.2", ItendeSerie = "air Bag",Descricao = "Branco"},
                new carro{Nome = "Combi" , Motorizacao = "1.3", ItendeSerie = "Direção eletrico",Descricao = "Amarelo"},

            };
            ford.Nome = "Ford";
            return ford;
        }

        private Marca GetListaCarrosRenault()
        {
            var Renault = new Marca()
            {
                new carro{Nome = "Sandeiro" , Motorizacao = "1.0", ItendeSerie = "vidro eletrico",Descricao = "Rosa"},
                new carro{Nome = "Duster" , Motorizacao = "1.1", ItendeSerie = "trava eletrica",Descricao = "verde"},
                new carro{Nome = "Logan" , Motorizacao = "1.2", ItendeSerie = "air Bag",Descricao = "Branco"},
                new carro{Nome = "Sandeiro" , Motorizacao = "1.3", ItendeSerie = "Direção eletrico",Descricao = "Amarelo"},

            };
            Renault.Nome = "Renault";
            return Renault;
        }

        private void Visualizar(object sender, EventArgs e)
        {
            var parametro = ((MenuItem)sender).CommandParameter;
            var carro = (carro)parametro;
            DisplayAlert("Titulo:oia",$"msg: clicou{carro.Nome}","Fechar");
        }

        private void RefreshNaPagina(object sender, EventArgs e)
        {
            var renault = new List<Marca>() {
            GetListaCarrosRenault()
            };
            Lista01.ItemsSource = renault;
            Lista01.IsRefreshing = false;
        }
    }

    public class carro {
        public string Nome { get; set; }
        public string Motorizacao { get; set; }
        public string Descricao { get; set; }
        public string ItendeSerie { get; set; }


    }

    public class Marca : List<carro> {
        public string Nome { get; set; }
    }


}