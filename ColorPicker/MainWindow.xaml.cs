using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace ColorPicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private CustomColorList ColorList;
        private Color color;
        public MainWindow()
        {
            InitializeComponent();
            SliderAlpha.Value = 255;
            ColorList = new CustomColorList();
            ListBoxColors.ItemsSource = ColorList;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Slider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var alpha = (byte)SliderAlpha.Value;
            var red = (byte)SliderRed.Value;
            var green = (byte)SliderGreen.Value;
            var blue = (byte)SliderBlue.Value;

            color = Color.FromArgb(alpha, red, green, blue);

            EllipseColor.Fill = new SolidColorBrush(color);
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            ColorList.Add(new CustomColor(EllipseColor.Fill.ToString(), new SolidColorBrush(color)));
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            ColorList.Clear();
        }

        private void ListBoxColors_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var nwColor = ListBoxColors.SelectedItems[0] as CustomColor;
            ColorList.Remove(nwColor);
        }

    }
}
