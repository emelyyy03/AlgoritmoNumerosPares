namespace AlgoritmoNumerosPares
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();

            List<int> numerosPares = new List<int>();
               for (int i = 0; i <= 100; i+=2)
               {
                   numerosPares.Add(i);
               }

               numeroListView.ItemsSource = numerosPares;

        }


       
    }

}
