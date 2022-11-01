var num = [ 12, 18, 15, 4, 17, 4, 92, 45, 53 ];
var biggest = num[0];
for (let i = 0; i < num.Length; i++)
{
    if(biggest < num[i])
    {
        biggest = num[i];
    }
}
Console.log(biggest);