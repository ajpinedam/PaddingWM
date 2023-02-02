using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Uno.UI.Common;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PaddingWM
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPageViewModel ViewModel { get; set; }

        public MainPage()
        {
            
            ViewModel = new MainPageViewModel();
            this.InitializeComponent();
            DataContext = ViewModel;

            //targetGrid.SizeChanged += TargetGrid_SizeChanged;
        }

        private void TargetGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //targetGrid.Padding = new Thickness(0, 34, 0, 65);
        }

        public void ItemClicked(object s, object e)
        { 

        }
    }

    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            CreateAccount = new DelegateCommand(CreateAccountAction);
        }

        public ICommand CreateAccount { get; set; }

        private void CreateAccountAction()
        {
            string text = string.Empty;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChange(string propertyName) 
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
