
using System.Reflection.Metadata;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RubanovEO.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            string[] words = value.Split(' ');
            string answer = "";
            string word_in_words = "";
            string lol = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0 && words[i].Length != 1)
                {
                    word_in_words = Convert.ToString(words[i]);
                    lol = "";
                    for (int j = 0; j < word_in_words.Length; j++)
                    {
                        if (j != word_in_words.Length / 2)
                        {
                            lol += Convert.ToString(word_in_words[j]);
                        }
                    }
                    answer += lol + " ";
                }
                else
                {
                    answer += words[i] + " ";
                }

            }
            answer = answer.Trim();
            
            


            return answer;
        }
    }
}
