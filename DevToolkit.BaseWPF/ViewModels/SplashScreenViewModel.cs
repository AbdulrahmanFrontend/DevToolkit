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
            set
            {
                if(_logoPath != value)
                {
                    _logoPath = value;
                    OnPropertyChanged();
                }
            } 
        }

        public string Title
        { 
            get => _title;
            set
            {
                if(_title != value)
                {
                    _title = value;
                    OnPropertyChanged();
                }
            } 
        }

        public string SubTitle
        { 
            get => _subTitle;
            set
            {
                if(_subTitle != value)
                {
                    _subTitle = value;
                    OnPropertyChanged();
                }
            } 
        }

        public string StatusMessage 
        { 
            get => _statusMessage;
            set
            {
                if(_statusMessage != value)
                {
                    _statusMessage = value;
                    OnPropertyChanged();
                }
            } 
        }

        public int ProgressValue
        {
            get => _progressValue;
            set
            {
                if(_progressValue != value)
                {
                    _progressValue = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Version
        { 
            get => _version;
            set
            {
                if(_version != value)
                {
                    _version = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
