using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppServSolTea
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Estudiantes : ContentPage
	{
        Button loginButton;
        StackLayout layout;
        public Estudiantes ()
		{
			InitializeComponent ();

            layout = new StackLayout
            {
                Children =
                {
                    new Label { Text = "Please log in" },
                    new Label { Text = "Username", TextColor = Color.Black },
                    new Entry (),
                    new Label { Text = "Password", TextColor = Color.Black },
                    new Entry { IsPassword = true },

                }
            };

            loginButton = new Button { Text = "Login" };

            layout.Children.Add(loginButton);

            Content = layout;



            //loginButton.Clicked += (sender, e) =>
            //{
            //    Debug.WriteLine("Clicked !");
            //};

        }
	}
}