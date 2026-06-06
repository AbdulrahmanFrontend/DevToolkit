using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.BaseWPF.ViewModels
{
    public class SplashScreenViewModel : BaseViewModel
    {
        private string _logoPath = string.Empty;

        private string _title = "Application";

        private string _subTitle = string.Empty;

        private string _statusMessage = "Initializing...";

        private int _progressValue = 0;

        private string _version = "1.0.0";

        public string LogoPath 
        { 
            get => _logoPath;
            set => _SetProperty<string>(ref _logoPath, value);
        }

        public string Title
        { 
            get => _title;
            set => _SetProperty<string>(ref _title, value);
        }

        public string SubTitle
        { 
            get => _subTitle;
            set => _SetProperty<string>(ref _subTitle, value);
        }

        public string StatusMessage 
        { 
            get => _statusMessage;
            set => _SetProperty<string>(ref _statusMessage, value);
        }

        public int ProgressValue
        {
            get => _progressValue;
            set => _SetProperty<int>(ref _progressValue, value);
        }

        public string Version
        { 
            get => _version;
            set => _SetProperty<string>(ref _version, value);
        }
    }
}
