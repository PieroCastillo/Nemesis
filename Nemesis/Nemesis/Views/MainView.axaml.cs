using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Aura.UI.Services;
using Aura.UI.Controls.Primitives;
using Aura.UI.UIExtensions;
using Aura.UI.Controls;
using Avalonia.Controls.Primitives;

namespace Nemesis.Views
{
    public class MainView : UserControl
    {
        public MainView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void CreateDocument(object sender, RoutedEventArgs e)
        {
            this.GetParentWindowOfLogical()
                .NewContentDialog("hello", (s,e) => { (sender as AuraTabView).AddTab(new AuraTabItem { Header = "hello" });  }, null, null, null);
        }

        public void TabViewTemplateApplied(object sender, TemplateAppliedEventArgs e)
        {
            (e.Source as AuraTabView).AddTab(TabManager.CreateHomeView());
        }
    }
}
