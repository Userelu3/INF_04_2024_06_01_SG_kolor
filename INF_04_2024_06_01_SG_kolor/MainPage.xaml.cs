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
            Random rng = new Random();
            int rng1 = rng.Next(1, 7);
            int rng2 = rng.Next(1, 7);
            int rng3 = rng.Next(1, 7);
            int rng4 = rng.Next(1, 7);
            int rng5 = rng.Next(1, 7);
            Dice1.Source = "k" + rng1 + ".jpg";
            Dice2.Source = "k" + rng2 + ".jpg";
            Dice3.Source = "k" + rng3 + ".jpg";
            Dice4.Source = "k" + rng4 + ".jpg";
            Dice5.Source = "k" + rng5 + ".jpg";
            int score = 0;
            if (rng1 == rng2 || rng1 == rng3 || rng1 == rng4 || rng1 == rng5)
                score += rng1;
            if (rng2 == rng1 || rng2 == rng3 || rng2 == rng4 || rng2 == rng5)
                score += rng2;
            if (rng3 == rng1 || rng3 == rng2 || rng3 == rng4 || rng3 == rng5)
                score += rng3;
            if (rng4 == rng1 || rng4 == rng2 || rng4 == rng3 || rng4 == rng5)
                score += rng4;
            if (rng5 == rng1 || rng5 == rng2 || rng5 == rng3 || rng5 == rng4)
                score += rng5;
            PointsLabel.Text = "Wynik tego rzutu: " + score;



        }

        private void ResetButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
