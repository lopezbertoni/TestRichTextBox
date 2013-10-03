using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestRichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddRight_Click(object sender, EventArgs e)
        {
            var txt = String.Format("{0}", "Text Right \r\n");
            txtText.SelectionAlignment = HorizontalAlignment.Right;
            txtText.SelectedText = txt;
        }

        private void btnAddLeft_Click(object sender, EventArgs e)
        {
            var txt = "Text Left \r\n";
            txtText.SelectionAlignment = HorizontalAlignment.Left;
            txtText.SelectedText = txt;
        }
    }
}
