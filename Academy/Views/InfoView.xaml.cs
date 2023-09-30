using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace Academy.Views
{

    public partial class InfoView : UserControl
    {
        public InfoView()
        {
            InitializeComponent();

            this.infoText.Text = File.ReadAllText("assets/info.txt");
        }

        private void infoText_TextChanged(object sender, TextChangedEventArgs e) => File.WriteAllText("assets/info.txt", this.infoText.Text);
    }
}
