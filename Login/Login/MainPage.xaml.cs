using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Login
{
    public class LogInfo
    {
       public string Name { get; set; }     
    }
    
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private LogInfo li { get; set; }
       public string Name { get; set; }
       
        public MainPage()
        {
            InitializeComponent();
            li = new LogInfo();
            BindingContext = li;
        }
      
        private void butt_Clicked(object sender, EventArgs e)
        {
            Name = name.Text;
            if (!(pass.Text.Any(char.IsDigit)))
            {
                DisplayAlert("Neplatné heslo", "Heslo neobsahuje číslo.", "OK");
            }
            else if (!(pass.Text.Length > 8))
            {
                DisplayAlert("Neplatné heslo", "Heslo nemá požadovanou délku", "OK");
            }
            else if (!(pass.Text.Any(char.IsLetterOrDigit))) 
            {
                DisplayAlert("Neplatné heslo", "Hesloneobsahuje speciální znak", "OK");
            }

            else
            {


                Application.Current.MainPage.Navigation.PushAsync(new LoggedPage(li));


            }
        }
    }
}
