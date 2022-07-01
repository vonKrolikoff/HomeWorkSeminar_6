// Задача 41: Пользователь вводит с клавиатуры числа через запятую. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine ("Введите числа -");
int[] numbers = StrToNumbers(Console.ReadLine());
int result = 0;
Console.WriteLine ();

for (int i = 0; i< numbers.Length; i++)
{
    // Console.WriteLine (numbers[i]);
    if (numbers[i] > 0)
    {
        result++;
    }
}

Console.WriteLine ("Вами было введено чисел больше 0 - " + result);

int[] StrToNumbers(string input)
{
    int countnumb = 1;

    for (int i = 0; i< input.Length; i++)
    {
        if (input[i] == ',')
        {
            countnumb++;
        }
    }
    int[] numbers = new int[countnumb];
    int index = 0;

    for (int i = 0; i< input.Length; i++)
    {
        string tempstring = "";

        while(input[i] != ',')
        {
            if(i != input.Length - 1)
            {
                tempstring += input[i].ToString();
                i++;
            }
            else
            {
                tempstring += input[i].ToString();
                break;
            }
        }
        numbers[index] = Convert.ToInt32(tempstring);
        index++;
    }
    return numbers;
}
