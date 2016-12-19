using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Project.Models;
using Project.ViewModels;
using Template10.Mvvm;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Project.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class InformaticaPage : Page
    {
        public InformaticaPage()
        {
            this.InitializeComponent();
           NavigationCacheMode = NavigationCacheMode.Disabled;
            //ViewModel.IsLoggedIn = true;
            //DataContext = new RichtingViewModel(DummyDataSource.RichtingToegepasteInformatica);
           ViewModel.Richting = DummyDataSource.RichtingToegepasteInformatica;

            ViewModel.SaveCommand = new DelegateCommand(Save);
        }

        private void Save()
        {

            //Richting r = DummyDataSource.RichtingToegepasteInformatica;

            //r.Description = txtDesc.Text;
            //r.Html = txtUrl.Text;
            //r.Title = txtTitle.Text;

            

            ViewModel.SaveRichting();
            //ViewModel.IsLoggedIn = false;
        }
    }
}
