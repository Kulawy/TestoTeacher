using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestoTeacher.View
{
    public partial class MainMenuWindow : Form
    {

        private OpenFileDialog ofd = new OpenFileDialog();
        public MainMenuWindow()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            ofd.Filter = "txt|*.txt";
            if ( ofd.ShowDialog() == DialogResult.OK)
            {
                textBox_fileName.Text = ofd.SafeFileName;
                textBox_adres.Text = ofd.FileName;
            }
        }
    }
}
