using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace FastpoolDesktop.Views
{
    public class TaskListView : UserControl
    {
        public TaskListView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}