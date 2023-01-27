// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A
//  в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16




int InputNumber(string str)
{
    int number;
    string? text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }

        System.Console.WriteLine("введено некорректное число");
    }
    return number;

}
int result = 1;

int Exp(int num1, int num2)
{
    for (int i = 1; i <= num2; i++)
        result = (num1 * result);
    return result;
}


int A = InputNumber("введитее число A: ");
int B = InputNumber("введитее число B: ");

System.Console.WriteLine(Exp(A, B));

