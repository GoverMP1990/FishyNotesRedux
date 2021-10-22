using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FishyNotesRedux.Forms
{
    public partial class FishyNote : Form
    {

        public FishyNote()
        {
            InitializeComponent();
        }

        private void SaveNote(object sender, EventArgs e)
        {
            string _noteText;

            _noteText = richTextBox1.Text;
        }
    }
}
