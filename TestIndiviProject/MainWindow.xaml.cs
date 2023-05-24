using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestIndiviProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        public List<Car> cars = new List<Car>();
        public List<Car> newCars = new List<Car>();
        public string speedForTB;
        public string nameCar;

        public MainWindow()
        {
            InitializeComponent();
            Random random = new Random();
        }

        private void AddTwxtBlock_Click(object sender, RoutedEventArgs e)
        {
            //TextBlock textBl = new TextBlock();
            //textBl.HorizontalAlignment = HorizontalAlignment.Left;
            //textBl.VerticalAlignment = VerticalAlignment.Top;
            //textBl.Text = Convert.ToString(DateTime.Now);
            //mainStackPanel.Children.Add(textBl);

            //AddTextBlock addTextBlock = new AddTextBlock();
            //addTextBlock.Show();
            //addTextBlock.Owner = this;

            for (int i = 0; i < 10; i++)
            {
                cars.Add(new Car(i, "Вася"));

            }

            using (var file = new FileStream("text.json", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(file, cars);
            }

            using (var file = new FileStream("text.json", FileMode.OpenOrCreate))
            {
                newCars = binaryFormatter.Deserialize(file) as List<Car>;
            }

            foreach (var car in newCars)
            {
                tbForList.Text += ($"{car.Name} --> {car.Speed} \n");
            }
        }

    }
}
