using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestoTeacher.Model
{
    public class Answer
    {
        public string AnswerContent { get; set; }
        public bool IsCorrect { get; set; }

        public Answer(string content, bool correction)
        {
            AnswerContent = content;
            IsCorrect = correction;
        }

    }
}
