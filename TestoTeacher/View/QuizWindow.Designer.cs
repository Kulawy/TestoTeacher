namespace TestoTeacher.View
{
    partial class QuizWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_tittle = new System.Windows.Forms.Label();
            this.label_titleQuestion = new System.Windows.Forms.Label();
            this.label_question = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_menu = new System.Windows.Forms.Button();
            this.checkedListBox_answers = new System.Windows.Forms.CheckedListBox();
            this.label_answersTitle = new System.Windows.Forms.Label();
            this.label_reps = new System.Windows.Forms.Label();
            this.label_repetitions = new System.Windows.Forms.Label();
            this.label_correct_all = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_tittle
            // 
            this.label_tittle.AutoSize = true;
            this.label_tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_tittle.Location = new System.Drawing.Point(14, 14);
            this.label_tittle.Name = "label_tittle";
            this.label_tittle.Size = new System.Drawing.Size(115, 51);
            this.label_tittle.TabIndex = 0;
            this.label_tittle.Text = "Quiz";
            // 
            // label_titleQuestion
            // 
            this.label_titleQuestion.AutoSize = true;
            this.label_titleQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_titleQuestion.Location = new System.Drawing.Point(23, 91);
            this.label_titleQuestion.Name = "label_titleQuestion";
            this.label_titleQuestion.Size = new System.Drawing.Size(72, 18);
            this.label_titleQuestion.TabIndex = 1;
            this.label_titleQuestion.Text = "Question:";
            // 
            // label_question
            // 
            this.label_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_question.Location = new System.Drawing.Point(101, 87);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(690, 70);
            this.label_question.TabIndex = 2;
            this.label_question.Text = "Some sample question";
            // 
            // button_ok
            // 
            this.button_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_ok.Location = new System.Drawing.Point(23, 380);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(55, 39);
            this.button_ok.TabIndex = 4;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_menu
            // 
            this.button_menu.Location = new System.Drawing.Point(723, 13);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(68, 35);
            this.button_menu.TabIndex = 6;
            this.button_menu.Text = "MENU";
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // checkedListBox_answers
            // 
            this.checkedListBox_answers.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkedListBox_answers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_answers.CheckOnClick = true;
            this.checkedListBox_answers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBox_answers.FormattingEnabled = true;
            this.checkedListBox_answers.Location = new System.Drawing.Point(101, 160);
            this.checkedListBox_answers.Name = "checkedListBox_answers";
            this.checkedListBox_answers.Size = new System.Drawing.Size(690, 255);
            this.checkedListBox_answers.TabIndex = 7;
            // 
            // label_answersTitle
            // 
            this.label_answersTitle.AutoSize = true;
            this.label_answersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_answersTitle.Location = new System.Drawing.Point(26, 160);
            this.label_answersTitle.Name = "label_answersTitle";
            this.label_answersTitle.Size = new System.Drawing.Size(69, 18);
            this.label_answersTitle.TabIndex = 8;
            this.label_answersTitle.Text = "Answers:";
            // 
            // label_reps
            // 
            this.label_reps.AutoSize = true;
            this.label_reps.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_reps.ForeColor = System.Drawing.Color.Red;
            this.label_reps.Location = new System.Drawing.Point(399, 35);
            this.label_reps.Name = "label_reps";
            this.label_reps.Size = new System.Drawing.Size(24, 25);
            this.label_reps.TabIndex = 9;
            this.label_reps.Text = "0";
            // 
            // label_repetitions
            // 
            this.label_repetitions.AutoSize = true;
            this.label_repetitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_repetitions.Location = new System.Drawing.Point(240, 39);
            this.label_repetitions.Name = "label_repetitions";
            this.label_repetitions.Size = new System.Drawing.Size(144, 20);
            this.label_repetitions.TabIndex = 10;
            this.label_repetitions.Text = "question repetition:";
            // 
            // label_correct_all
            // 
            this.label_correct_all.AutoSize = true;
            this.label_correct_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_correct_all.Location = new System.Drawing.Point(446, 39);
            this.label_correct_all.Name = "label_correct_all";
            this.label_correct_all.Size = new System.Drawing.Size(81, 20);
            this.label_correct_all.TabIndex = 11;
            this.label_correct_all.Text = "correct/all:";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_score.ForeColor = System.Drawing.Color.Red;
            this.label_score.Location = new System.Drawing.Point(555, 35);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(42, 25);
            this.label_score.TabIndex = 12;
            this.label_score.Text = "0/0";
            // 
            // QuizWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_correct_all);
            this.Controls.Add(this.label_repetitions);
            this.Controls.Add(this.label_reps);
            this.Controls.Add(this.label_answersTitle);
            this.Controls.Add(this.checkedListBox_answers);
            this.Controls.Add(this.button_menu);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label_question);
            this.Controls.Add(this.label_titleQuestion);
            this.Controls.Add(this.label_tittle);
            this.Name = "QuizWindow";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuizWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_tittle;
        private System.Windows.Forms.Label label_titleQuestion;
        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.CheckedListBox checkedListBox_answers;
        private System.Windows.Forms.Label label_answersTitle;
        private System.Windows.Forms.Label label_reps;
        private System.Windows.Forms.Label label_repetitions;
        private System.Windows.Forms.Label label_correct_all;
        private System.Windows.Forms.Label label_score;
    }
}