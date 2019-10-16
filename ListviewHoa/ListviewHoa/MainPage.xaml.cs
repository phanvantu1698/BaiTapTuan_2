using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListviewHoa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        ObservableCollection<hoa> Hoas = new ObservableCollection<hoa>();

        public MainPage()
        {
            InitializeComponent();
            Hoas.Add(new hoa { TenHoa = "Đón Xuân", Gia = 50000, Hinh = "donXuan.jpg", MoTa = "Hoa Cúc các màu: trắng, vàng, cam " });
            Hoas.Add(new hoa { TenHoa = "Hồn nhiên", Gia = 60000, Hinh = "honNhien.jpg", MoTa = "Hoa Cúc các vàng, cam, lá măng " });
            Hoas.Add(new hoa { TenHoa = "Tím thuỷ chung", Gia = 45000, Hinh = "timThuyChung.jpg", MoTa = "Hoa Cúc tím" });
            lsvHoa.ItemsSource = Hoas;
        }
    }
}
