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
    public partial class QuizWindow : Form
    {

        public MainMenuWindow mainMenu { get; set; }

        public QuizWindow(MainMenuWindow menuContext)
        {
            InitializeComponent();
            mainMenu = menuContext;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }
    }
}
