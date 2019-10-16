using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListviewGroup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage

    {

     
        public MainPage()
        {
            InitializeComponent();
            LoaiHoa l = new LoaiHoa();
            lsthoa.ItemsSource = l.Loaihoas;
        }
        
    }
}