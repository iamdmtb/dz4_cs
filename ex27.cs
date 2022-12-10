Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int[] NumToArr(int num){
int[] digits = new int[1 + (int)Math.Log10(num)];
for (int i = digits.Length - 1; i >= 0; i--)
{
    int digit;
    num = Math.DivRem(num, 10, out digit);
    digits[i] = digit;
}
return digits;
}
int[] arr = NumToArr(num);
int sum = arr[0];
for (int i=1; i <= arr.Length - 1; i++){
    sum = sum + arr[i];
}
Console.WriteLine($"Сумма цифр заданного числа = {sum}");