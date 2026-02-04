namespace INF_04_2024_06_01_SG_kolor
{
    public partial class MainPage : ContentPage
    {
    
        public MainPage()
        {
            InitializeComponent();
        }

        private void ThrowButton_Clicked(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int RandomNumber1 = rnd.Next(1, 7);
            int RandomNumber2 = rnd.Next(1, 7);
            int RandomNumber3 = rnd.Next(1, 7);
            int RandomNumber4 = rnd.Next(1, 7);
            int RandomNumber5 = rnd.Next(1, 7);
            Dice1.Source = "k" + RandomNumber1 + ".jpg";
            Dice2.Source = "k" + RandomNumber2 + ".jpg";
            Dice3.Source = "k" + RandomNumber3 + ".jpg";
            Dice4.Source = "k" + RandomNumber4 + ".jpg";
            Dice5.Source = "k" + RandomNumber5 + ".jpg";
            

        }

        private void ResetButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
