using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemesis.ViewModels
{
    public class HomeViewViewModel : ViewModelBase
    {
        public string WelcomeText
        {
            get => LanguageHelper.GetWelcome();
        }

        public string WhatDoYouWantToDoText
        {
            get => LanguageHelper.GetWhatDoYouWantToDoText();
        }

        public string OpenRecentText
        {
            get => LanguageHelper.GetOpenRecent();
        }

        public string CreateNewText
        {
            get => LanguageHelper.GetCreateNew();
        }
    }
}
