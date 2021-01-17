using Aura.UI.Controls;
using Avalonia.Interactivity;
using Nemesis.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemesis
{
    public class TabManager
    {
        public static AuraTabItem CreateHomeView()
        {

            return new AuraTabItem()
            {
                Header = LanguageHelper.GetWelcome(),
                Content = new HomeView()
            };
        }

        public static AuraTabItem CreateNewDocument()
        {
            return default(AuraTabItem);
        }
    }
}
