using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using VirtualKeyboard.Controls.Keyboard.Layout;

namespace VirtualKeyboard.Controls.Keyboard.Layout
{
    public partial class VirtualKeyboardLayoutDE : KeyboardLayout
    {
        public VirtualKeyboardLayoutDE()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public string LayoutName => "de-DE";
    }
}
