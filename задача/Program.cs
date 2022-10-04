string[] array1 = new string[5] {"1235", "23", "hello", "wor", "res"};
string[] array2 = new string[array1.Length];
void FillingAnArray(string[] array1, string[] array2)
{
int count = 0;
for (int i = 0; i < array1.Length; i++)
{
if(array1[i].Length <= 3)
{
array2[count] = array1[i];
count++;
}
}
}
void PrintArray(string[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}
FillingAnArray(array1, array2);
PrintArray(array2);

