using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSI___Prefeitura.Helpers
{
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public ComboBoxItem(string text, object value)
        {
            this.Text = text;
            this.Value = value;
        }

        public override string ToString()
        {
            return this.Text;
        }
    }
}
