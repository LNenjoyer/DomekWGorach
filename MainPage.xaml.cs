namespace DomekWGorach
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        int state = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            string pressed = button.Text;
            if(pressed=="Zapisz")
                state = 1;
            if(pressed== "Polub"&&state==0)
                count++;
            if (pressed == "Usuń" && count>0 && state == 0)
                count--;
            this.licznik.Text = $"{count} polubień";


            SemanticScreenReader.Announce(licznik.Text);
        }
    }

}
