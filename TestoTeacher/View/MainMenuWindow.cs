using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestoTeacher.Controler;

namespace TestoTeacher.View
{
    public partial class MainMenuWindow : Form
    {

        private OpenFileDialog ofd = new OpenFileDialog();
        private QuizWindow quizWindow;
        private QuestionProvider questionProvider;
        private string fileUrl;

        //CONSTRUCTOR
        public MainMenuWindow()
        {
            InitializeComponent();
        }


        //EVENTS METHODS
        private void add_button_Click(object sender, EventArgs e)
        {
            ofd.Filter = "txt|*.txt";
            if ( ofd.ShowDialog() == DialogResult.OK)
            {
                textBox_fileName.Text = ofd.SafeFileName;
                textBox_adres.Text = ofd.FileName;
                fileUrl = ofd.FileName;
            }
        }

        private void buton_start_Click(object sender, EventArgs e)
        {
            if ( CheckValidation() )
            {
                QuizImplementator();
                this.Hide();
                quizWindow = new QuizWindow(this);
                quizWindow.Show();                
            }
            else
                MessageBox.Show("Please fill empty holders");

        }

        private void button_resume_Click(object sender, EventArgs e)
        {
            if ( quizWindow != null)
            {
                this.Hide();
                quizWindow.Show();
            }
            else
            {
                MessageBox.Show("What you want to resume?");
            }
            
        }

        private void textBox_repNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_repNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox_repNumber.Text = textBox_repNumber.Text.Remove(textBox_repNumber.Text.Length - 1);
            }
        }

        private void textBox_repWrongNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_repWrongNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox_repWrongNumber.Text = textBox_repNumber.Text.Remove(textBox_repWrongNumber.Text.Length - 1);
            }
        }

        //HELPERS METHODS
        private bool CheckValidation()
        {
            if (!textBox_repNumber.Text.Equals("") && !textBox_repWrongNumber.Text.Equals("") && !textBox_fileName.Text.Equals(""))
                return true;
            else
                return false;
        }

        private void QuizImplementator()
        {
            if (questionProvider != null)
                QuestionProvider.DeleteProvider();
            QuestionProvider.Reps = System.Convert.ToInt32(textBox_repNumber.Text);
            QuestionProvider.RepsWrong = System.Convert.ToInt32(textBox_repWrongNumber.Text);
            QuestionProvider.FileURL = fileUrl;
            questionProvider = QuestionProvider.GetInstance();
            
        }

        
    }
}
