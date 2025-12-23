
using System;

main();
void main()
{
    //вот начало
    long value;
    Console.Write("введите число, которое хотите перевести в 0b: ");
    value = Convert.ToInt64(Console.ReadLine());
    string a = Convert.ToString(Binary.ConvertTo0b(value));
    Console.WriteLine($"ваше число в 0b: {a}");
    Console.WriteLine($"ваше число, переведенное обратно: {Binary.UnconvertTo0b(a)}");
    /*на этом моменте захотелось
    сделать как у ковиной в pcneiman 
    типа если надо вернуться к началу вверху, 
    то вызовите какой нибудь комманду JMP_TO(8) 8 - строка кода,
    мб это и убьет какой нибудь подход ООП, но просто интересно
    как это сделать */

}
class Binary
{
    public static string ConvertTo0b(long value)
    {
        string vyvod = "";
        string vyvodstopudova = "";
        while (value > 0)
        {
            vyvod = vyvod + Convert.ToString(value % 2);
            value /= 2;
        }
        for (int i = vyvod.Length - 1; i != -1; i--)
        {
            vyvodstopudova = vyvodstopudova + vyvod[i];
        }
        return vyvodstopudova;
    }

    public static double UnconvertTo0b(string value)
    {
        int f = 0;
        int vs;
        double sum = 0;
        for (int i = value.Length - 1; i != -1; i--)
        {
            if (value[i] == 48) // это потому, что он думает, что value[i] (0 типа) = 48. это он берет из кодировки ASCII. я хз пока как это фиксить
            {
                vs = 0;
            }
            else vs = 1;
            sum += vs * Math.Pow(2, f);
            f++;
        }
        return sum;
    }
}