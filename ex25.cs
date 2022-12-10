Console.Write("Введите два числа: ");
double a = Convert.ToInt32(Console.ReadLine());
double b = Convert.ToInt32(Console.ReadLine());
double Stepen(double a,double b){
    double res = Math.Pow(a, b);
    return res;
}
double result = Stepen(a,b);
Console.Write($"{a} в степень {b} = {result}");