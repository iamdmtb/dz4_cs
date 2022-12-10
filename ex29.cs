Console.WriteLine("Введите массив через пробел");
int[] arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
void ArrToString() {
    string result = string.Join(";", arr);
    Console.Write(result);
// for (int k = 0; k <= arr.Length - 1; k++)
// {
//     Console.Write(arr[k] + "\t");
// }
}
ArrToString();
