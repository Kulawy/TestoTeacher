using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using TestoTeacher.Model;

namespace TestoTeacher.Controler
{
    public class QuestionProvider
    {

        // czy Context czy ContextBoundObject
        private static QuestionProvider provider = null;
        //private Context context;

        private List<Question> questionsList;
        public static int Reps { get; set; }
        public static int RepsWrong { get; set; }
        public static string FileURL { get; set; }

        // tworzymy konten prowidera dodając ilosc powtórzeń 
        //private QuestionProvider(Context current, int repetitions )
        private QuestionProvider()
        {
            questionsList = new List<Question>();
            //FileURL = fileURL;
            ParseFile(FileURL);
            //this.context = current;
        }

        //metoda nadpisująca istniejący prowider bo może istnieć tylko jedna instancja
        //public static QuestionProvider GetInstance(Context context, int repetitions)
        public static QuestionProvider GetInstance()
        {
            if (provider == null)
            //    provider = new QuestionProvider(context, repetitions);
                provider = new QuestionProvider();
            
            return provider;
        }

        public static void DeleteProvider()
        {
            if (provider != null)
                provider = null;
        }


        //metoda czytająca plik linijka po linijce
        private void ParseFile(string fileName)
        {            
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(fileName))
                {
                    // Read line from stream to a string, 
                    while (!sr.EndOfStream)
                    {                        
                        ParseLine(sr.ReadLine());
                    }
                                        
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            
        }


        //medota obsługująca czytanie linijki 
        private void ParseLine(string currentLine)
        {
            //string beginning = currentLine.Substring(0, 2);
            if (!currentLine.Equals(""))
            {
                char[] textArray = currentLine.ToCharArray();
                int firsCharToNum = System.Convert.ToInt32(textArray[0]);

                if (textArray[0].Equals('Q'))
                {
                    questionsList.Add(new Question(currentLine.Substring(2), Reps));
                }
                //else if (System.Text.RegularExpressions.Regex.IsMatch(beginning, "[^0-9]"))
                else if ((firsCharToNum >= 97) && (firsCharToNum <= 105))
                {
                    bool isCorect = false;
                    if (textArray[textArray.Length - 1].Equals("+") && textArray[textArray.Length - 2].Equals("_"))
                        isCorect = true;
                    questionsList[questionsList.Count - 1].AddAnswer(currentLine.Substring(2), isCorect);

                }
            }

        }

        // METODY DO WYKORZYSTANIA PROVIDERA

        //metoda getQuestion

        public int questionsCount()
        {
            return questionsList.Count;
        }
        public Question getQuestion(int Id)
        {
            Question question = questionsList[Id];
            return question;
        }

        public bool Remove(Question question)
        {
            if ( questionsList[questionsList.IndexOf(question)] != null)
            {
                questionsList.Remove(question);
                return true;
            }
            else
            {
                return false;
            }
                
        }

    }
}
