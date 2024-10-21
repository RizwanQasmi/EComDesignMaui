using EComDesignMaui.Models;

namespace EComDesignMaui
{
    public partial class MainPage : ContentPage
    {
       public List<FruitInformation> MangoInfo { get; set; }

        public MainPage()
        {
            InitializeComponent();
            MangoInfo = new List<FruitInformation>()
            {
                new FruitInformation
                {
                    Micronutrient="Vitamin C",
                    Percentgage=100
                },
                new FruitInformation
                {
                    Micronutrient="Vitamin A",
                    Percentgage=25
                },
                new FruitInformation
                {
                    Micronutrient="Vitamin D",
                    Percentgage=105
                },
                new FruitInformation
                {
                    Micronutrient="Calcium",
                    Percentgage=54
                },
                new FruitInformation
                {
                    Micronutrient="Magnisium",
                    Percentgage=12
                }
            };
            BindingContext = this;
        }

       
    }

}
