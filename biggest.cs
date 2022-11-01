int[] num = { 12, 18, 15, 4, 17, 4, 92, 45, 53 };
int biggest = num[0];
for (int i = 0; i < num.Length; i++)
{
    if(biggest < num[i])
    {
        biggest = num[i];
    }
}
Console.WriteLine(biggest);