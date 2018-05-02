using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App7.mdPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class mdPageMaster : ContentPage
    {
        public ListView ListView;

        public mdPageMaster()
        {
            InitializeComponent();

            BindingContext = new mdPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class mdPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<mdPageMenuItem> MenuItems { get; set; }
            
            public mdPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<mdPageMenuItem>(new[]
                {
                    new mdPageMenuItem { Id = 0, Title = "Page 1", TargetType = typeof(MainPage), ImgSrc = "App7.img.page1.png" },
                    new mdPageMenuItem { Id = 1, Title = "Page 2", TargetType = typeof(Perso.PersoDetail) },
                    new mdPageMenuItem { Id = 2, Title = "Page 3" },
                    new mdPageMenuItem { Id = 3, Title = "Page 4" },
                    new mdPageMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}