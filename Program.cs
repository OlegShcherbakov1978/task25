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

