namespace HardwarePOS.UI.Helpers
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            KeyPreview = true;

            KeyDown += BaseForm_KeyDown;
        }

        private void BaseForm_KeyDown(
            object? sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Control? focusedControl =
                    GetFocusedControl(this);

                if (focusedControl is Button button)
                {
                    button.PerformClick();

                    return;
                }

                e.SuppressKeyPress = true;

                SelectNextControl(
                    focusedControl,
                    true,
                    true,
                    true,
                    true);
            }
        }

        private Control? GetFocusedControl(
            Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control.Focused)
                    return control;

                if (control.HasChildren)
                {
                    var child =
                        GetFocusedControl(control);

                    if (child != null)
                        return child;
                }
            }

            return null;
        }
    }
}