using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        int deep = 0;

        Console.Write("Введите строку с символами '(' и ')': ");
        string brackets = Console.ReadLine();

        for (int i = 0; i < brackets.Length; i++)
        {
            if (brackets[i] == '(')
            {
                count++;
            }

            if (brackets[i] == ')')
            {
                if(deep < count)
                {
                    deep = count;
                }

                count--;
            }

            if(count < 0)
            {
                break;
            }
        }

        if (count == 0)
        {
            Console.WriteLine($"Корректное скобочное выражение, максимальная глубина вложенности скобок {deep}.");
        }
        else
        {
            Console.WriteLine("Не корректное скобочное выражение");
        }
    }
}