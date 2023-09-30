using Academy.ViewModels;
using Academy.ViewModels.Base;
using System;
using System.Collections.Generic;
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

namespace Academy
{
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();

            this.viewModel = new MainViewModel();

            this.viewModel.ActiveViewModel = new HomeViewModel();
            this.DataContext = this.viewModel;
        }

        private void infoButtonClicked(object sender, RoutedEventArgs e) => this.viewModel.ActiveViewModel = new InfoViewModel();
        private void groupsButtonClicked(object sender, RoutedEventArgs e) => this.viewModel.ActiveViewModel = new GroupsViewModel();
        private void studentsButtonClicked(object sender, RoutedEventArgs e) => this.viewModel.ActiveViewModel = new StudentsViewModel();
        private void teachersButtonClicked(object sender, RoutedEventArgs e) => this.viewModel.ActiveViewModel = new TeachersViewModel();
    }
}
