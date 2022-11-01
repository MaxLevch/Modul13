using System.Collections;
using System.Text;


namespace Modul13
{
    class Program
    {
        static void Main(string[]args)
        {
            var month = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            var Spisok = new ArrayList();
            for (int i = 0; i < numbers.Length; i++)
            {
                Spisok.Add(month[i]);
                Spisok.Add(numbers[i]);
            }
            var newSpisok = SummList(Spisok);
            foreach (var spisok in newSpisok)
                Console.WriteLine(spisok);

        }

        static ArrayList SummList(ArrayList array)
        {
            int summInt = 0;
            StringBuilder text = new StringBuilder();
            foreach (var item in array)
                if( item is int)
                {
                    summInt += (int)item;
                }
                else if (item is string)
                {
                    text.Append(item);
                }
            var NewSpisok = new ArrayList() { summInt, text.ToString()};
            return NewSpisok;
        }
    }
}