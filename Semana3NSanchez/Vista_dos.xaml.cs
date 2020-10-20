using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3NSanchez
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vista_dos : ContentPage
    {
        public Vista_dos(string usuario, string pass)
        {
            InitializeComponent();
            string us = lblUser.Text;
            lblUser.Text = us + usuario;

        }
    }
}