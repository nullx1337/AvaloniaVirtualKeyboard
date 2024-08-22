using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using VirtualKeyboard.Controls.Keyboard.Layout;

namespace VirtualKeyboard.Controls.Keyboard.Layout
{
    public partial class VirtualKeyboardLayoutUS : KeyboardLayout
    {
        public VirtualKeyboardLayoutUS()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public string LayoutName => "en-US";
    }
}
