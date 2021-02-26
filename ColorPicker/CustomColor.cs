using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ColorPicker
{
    public class CustomColor
    {
        public string Name { get; set; }
        public SolidColorBrush Color { get; set; }

        public CustomColor() {}
        public CustomColor(string name, SolidColorBrush color)
        {
            Name = name;
            Color = color;
        }
    }

    public class CustomColorList : ObservableCollection<CustomColor>
    {
        public CustomColorList()
        
        {
            this.Add(new CustomColor("#FF000000", new SolidColorBrush(Color.FromArgb((byte)255,(byte)0, (byte)0, (byte)0))));
            this.Add(new CustomColor("#FF706DD0", new SolidColorBrush(Color.FromArgb((byte)255,(byte)112, (byte)109, (byte)208))));
            this.Add(new CustomColor("#53D42882", new SolidColorBrush(Color.FromArgb((byte)83,(byte)212, (byte)40, (byte)130))));
            this.Add(new CustomColor("#FF27BC59", new SolidColorBrush(Color.FromArgb((byte)255,(byte)39, (byte)188, (byte)89))));
        }
    }
}
