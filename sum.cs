int[] num = { 12, 18,15,4,17,4,92,45,53 };
int sum = 0;

for (int i = 0; i < num.Length; i++)
{
    if (num[i] > 0 && num[i] % 6 == 0)
    {
        sum+=num[i];
    }
}
Console.WriteLine(sum);
