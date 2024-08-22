using Avalonia.Controls;
using VirtualKeyboard.Controls.Keyboard.Layout;

namespace VirtualKeyboard.Controls.Keyboard.Layout
{
    public partial class VirtualKeyboardLayoutNumpad : KeyboardLayout
    {
        public VirtualKeyboardLayoutNumpad()
        {
            InitializeComponent();
        }

        public string LayoutName => "numpad";
    }
}
