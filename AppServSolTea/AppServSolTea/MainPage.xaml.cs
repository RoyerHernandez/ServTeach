using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppServSolTea
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();


            this.Master = new Master() { Title = "Main Page" };
            this.Detail = new NavigationPage(new Detail());
                    

            //this.Master = new Master();

            //this.Detail = new NavigationPage(new Detail());

            App.MasterDetail = this;
        }
    }
}
