﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestoTeacher.Model
{
    public class Question
    {
        public List<Answer> answersList { get; set; }
        public string QuestionContent { get; set; }
        public int Repetitions { get; set; }

        public Question(string content, int rep)
        {
            QuestionContent = content;
            Repetitions = rep;
            answersList = new List<Answer>();
        }

        public bool AddAnswer(string answer, bool isCorrect)
        {
            if (answer != null)
            {
                answersList.Add(new Answer(answer, isCorrect));
                return true;
            }
            else
                return false;

        }


    }
}
