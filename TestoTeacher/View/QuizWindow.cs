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
using TestoTeacher.Model;

namespace TestoTeacher.View
{
    public partial class QuizWindow : Form
    {

        public MainMenuWindow mainMenu { get; set; }

        private Random rnd;
        private Question actualQuestion;
        private QuizLogic quizLogicService;
        private QuestionProvider questionProvider;
        private int beginingQuestionsCount;


        public QuizWindow(MainMenuWindow menuContext)
        {
            InitializeComponent();
            mainMenu = menuContext;
            
            rnd = new Random();
            
            initialization();
            
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            checkTheAnswer(actualQuestion);
            checkToRemove(actualQuestion);
            actualQuestion = questionProvider.getQuestion(rnd.Next(questionProvider.questionsCount() - 1));
            checkedListBox_answers.Items.Clear();
            fillContent(actualQuestion);
            //actualQuestion = questionProvider.getQuestion(rnd.Next(questionProvider.questionsCount() - 1))
            //fillContent(actualQuestion);
        }

        private void QuizWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mainMenu != null)
                mainMenu.Show();
        }


        // METODY POMOCNICZE

        private void initialization()
        {
            questionProvider = QuestionProvider.GetInstance();
            beginingQuestionsCount = questionProvider.questionsCount();

            if ( questionProvider.questionsCount() <= 0)
            {
                MessageBox.Show("Pleas load file with correct content");
            }
            else
            {
                quizLogicService = new QuizLogic();
                actualQuestion = questionProvider.getQuestion(rnd.Next(questionProvider.questionsCount() -1 ));
                fillContent(actualQuestion);
            }
            
        }


        private void fillContent(Question question)
        {
            label_question.Text = question.QuestionContent;
            label_reps.Text = question.Repetitions.ToString();
            label_score.Text = String.Format("{0} / {1}", quizLogicService.Score, beginingQuestionsCount) ;
            
            foreach ( Answer a in question.answersList)
            {
                checkedListBox_answers.Items.Add(a, false);
            }

        }

        private void checkTheAnswer(Question question)
        {
            bool flag = true;                          
            //dla wszystkich odpowidzi w liscie sprawdzam czy isCorrect równa sie zaznaczony.isChacked
            foreach (Answer a in checkedListBox_answers.Items)
            {
                if ( a.IsCorrect  != ( checkedListBox_answers.GetItemChecked(checkedListBox_answers.Items.IndexOf(a)).Equals(CheckState.Checked) ? true : false))
                {
                    flag = false;
                }
            }
            if (flag)
            {
                question.Repetitions--;
            }
            else
            {
                question.Repetitions += QuestionProvider.RepsWrong;
            }
                

        }

        private void checkToRemove(Question question)
        {
            if ( question.Repetitions <= 0)
            {
                if (!questionProvider.Remove(question))
                    MessageBox.Show("Error when removing");
                else
                {
                    quizLogicService.Score++;
                }
            }
        }

    }
}
