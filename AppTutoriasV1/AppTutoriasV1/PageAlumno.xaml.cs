using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTutoriasV1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageAlumno : ContentPage
	{
		public PageAlumno ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageReporte());
        }
    }
}