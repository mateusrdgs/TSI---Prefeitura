using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSI___Prefeitura.Métodos
{
    public static class ControlesIteradores
    {
        public static void limparControles(Control control)
        {
            foreach(Control child in control.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                if(child is TextBox)
                {
                    if(
                        !string.IsNullOrEmpty(child.Text) ||
                        !string.IsNullOrWhiteSpace(child.Text) ||
                        child.Text != string.Empty
                       )
                    {
                        child.Text = "";
                    }
                }
                else if (child is MaskedTextBox)
                {
                    ((MaskedTextBox)child).TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    if (
                        !string.IsNullOrEmpty(child.Text) ||
                        !string.IsNullOrWhiteSpace(child.Text) ||
                        child.Text != string.Empty
                    )
                    {
                        child.Text = "";
                    }
                }
                else if (child is ComboBox)
                {
                    ((ComboBox)child).SelectedIndex = -1;
                }
            }
        }

        public static string checharCampoVazio(Control control)
        {
            foreach(Control child in control.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                if(child is TextBox)
                {
                    if(
                        string.IsNullOrEmpty(child.Text) ||
                        string.IsNullOrWhiteSpace(child.Text) ||
                        child.Text == string.Empty
                    )
                    {
                        return child.Tag.ToString();
                    }
                }
                else if (child is MaskedTextBox)
                {
                    ((MaskedTextBox)child).TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    if (
                        string.IsNullOrEmpty(child.Text) ||
                        string.IsNullOrWhiteSpace(child.Text) ||
                        child.Text == string.Empty                        
                     )
                     {
                        return child.Tag.ToString();
                     }
                }
                else if (child is ComboBox && ((ComboBox)child).SelectedIndex < 0)
                {
                    return child.Tag.ToString();
                }
            }
            return "";
        }
    }
}
