using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTutoriasV1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async Task<bool> validar()
        {
            if (String.IsNullOrWhiteSpace(txt_matricula.Text))
            {
                await this.DisplayAlert("Advertencia", "El campo es obligatorio.", "OK");
                return false;
            }
            //Valida si la cantidad de digitos ingresados es menor a 10
            else if (txt_matricula.Text.Length != 7)
            {
                await this.DisplayAlert("Advertencia", "Favor de ingresar los digitos necesarios.", "OK");
                return false;
            }
            else
            {
                //Valida que solo se ingresen numeros
                if (!txt_matricula.Text.ToCharArray().All(Char.IsDigit))
                {
                    await this.DisplayAlert("Advertencia", "El formato es incorrecto, solo se aceptan numeros.", "OK");
                    return false;
                }
            }
            return true;
        }

        async void Btn_buscar_Clicked(object sender, EventArgs e)
        {
            //Validación para abrir otra form
            if (await validar())
            {
                //New 
               await Navigation.PushAsync(new PageAlumno());
            }
        }
    }


}
