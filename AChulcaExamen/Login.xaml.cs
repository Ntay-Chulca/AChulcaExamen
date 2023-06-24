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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            string user = "estudiante2023";
            string password = "uisrael2023";

            if (txtUser.Text == user && txtPassword.Text == password)
            {
                Navigation.PushAsync(new Registro(user));
            }
            else
            {
                DisplayAlert("Error", "Usuario o Contraseña Incorrecto", "Cerrar");
            }
        }


    }
}