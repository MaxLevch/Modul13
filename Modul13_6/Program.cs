using System.Diagnostics;
using System.Linq;
using System.Runtime;
using Modul13_6_2;

namespace Modul13_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C://Games/BotTelegram/Text1.txt"); //получаем текст из файла
            var noPunctuationText = new string(text.Where(c => !Char.IsPunctuation(c)).ToArray());      // Убираем знаки препинания    
            noPunctuationText.ToLower(); //Делаем нижний регистр у всех слов для правильного подсчета

            char[] delimitres = new char[] { ' ', '\r', '\n' };
            
            var words = noPunctuationText.Split(delimitres, StringSplitOptions.RemoveEmptyEntries);

            HashSet<string> wordHashSet = new HashSet<string>(words); //Список уникальных слов
            List<Words> wordsList = new List<Words>();   //итоговый список наиболее употребляемых

            //сравниваем список с уникальным списком
            foreach (var hashWord in wordHashSet)
            {
                //считаем сколько раз встречалось слово в тексте
                int kol = 0;
                foreach (var word in words)
                { 
                    if (word == hashWord)
                        kol++;
                }

                // добавляем проверяемое слово в итоговый список
                if (wordsList.Count == 0)
                {
                    wordsList.Add(new Words(kol, hashWord));
                }
                else
                {
                    //сравниваем проверяемое слово с уже записанными в список на популярность
                    for (int i = 0; i < wordsList.Count; i++)
                    {
                        if (kol > wordsList[i].Amount)
                        {
                            wordsList.Insert(i, new Words(kol, hashWord));
                            //Убираем 11 слово из списка
                            if (wordsList.Count > 10)
                            { 
                                wordsList.RemoveAt(10);
                                break;
                            }
                            break;
                        }
                    }
                }
            }
            // Выводим итоговый список
            foreach (var word in wordsList)
                Console.WriteLine($" {word.Name} - {word.Amount}");
        }
    }
}