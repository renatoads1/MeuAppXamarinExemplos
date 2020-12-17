using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade.XamarinForms.Controles.DatePicker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePicker : ContentPage
    {
        public DatePicker()
        {
            InitializeComponent();
        }

        private void DataSelecionada(object sender, DateChangedEventArgs e)
        {
            lblDatePicker.Text = "data antiga: " + e.OldDate.ToString("dd/MM/yyyy") + "data Nova: " + e.NewDate.ToString("dd/MM/yyyy");
        }
    }
}