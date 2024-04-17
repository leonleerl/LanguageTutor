using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LanguageTutor.WPF.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        public MainViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            OpenCommand = new DelegateCommand<string>(Open);
        }
        
        private void Open(string url)
        {
            switch (url)
            {
                case "Japanese":
                    _regionManager.RequestNavigate("ContentRegion", nameof(JapaneseTutor.WPF.Views.MainView));
                    break;
                case "Korean":
                    _regionManager.RequestNavigate("ContentRegion", nameof(KoreanTutor.WPF.Views.MainView));
                    break;
                case "Spanish":
                    MessageBox.Show("Spanish");
                    break;
                default:
                    
                    break;
            }
        }

        public DelegateCommand<string> OpenCommand { get; private set; }
    }
}
