using System.Diagnostics;

namespace Modul13_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C://Games/BotTelegram/Text1.txt");

            char[] delimitres = new char[] { ' ', '\r', '\n' };

            var words = text.Split(delimitres, StringSplitOptions.RemoveEmptyEntries);

            var testList = new List<string>();
            var timer = Stopwatch.StartNew();
            foreach (var word in words)
                testList.Add(word);
            Console.WriteLine($"Вставка в List: {timer.Elapsed.TotalMilliseconds} мс");

            LinkedList<string> list = new LinkedList<string>();
            var timerLinkedList = Stopwatch.StartNew();
            foreach (var word in words)
                list.AddLast(word);
            Console.WriteLine($"Вставка в LinkedKist: {timerLinkedList.Elapsed.TotalMilliseconds} мс");
        }
    }
}