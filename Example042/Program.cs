// 42. Определить сколько цифр больше 0 введено с клавиатуры


string getNumberStr = String.Empty;
int getNumber = 1;
int quan = 0;
Console.WriteLine(" Введите числа, по окончании нажмите любую букву:");
while (getNumber != 0  && getNumber > 0)
{
    getNumberStr = Console.ReadLine();
    int.TryParse(getNumberStr, out getNumber);
    quan++;
    if(getNumber == 0 || getNumber < 0)
    quan--;
}
Console.WriteLine(" Вы ввели " + quan + " чисел (числа) больше 0 ");