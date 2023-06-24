using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AChulcaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        string usuario;
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUser.Text = "USUARIO CONECTADO" + " " + "ACHULCA" + " " + usuario;
            this.usuario = usuario;
        }


        public Registro()
        {
            InitializeComponent();
        }


        private void btnPagoM_Clicked(object sender, EventArgs e)
        {
            double Monto = Convert.ToDouble(txtMonto.Text);
            double PagoMensual = (1500 - Monto) / 4 * 1.04;
            txtPagoM.Text = PagoMensual.ToString();
        }


        private void btnResumen_Clicked(object sender, EventArgs e)
        {

        }
    }
}