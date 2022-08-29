int[] array = new int[123];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 200);

    if(array[i] > 10 && array[i] < 99)
    {
        count++;
    }
}
void WriteArray(int[] test)
{
    Console.Write("[");
    
        for(int i = 0; i < test.Length; i++)
        {
            if(i < test.Length -1)
            {
                Console.Write(test[i] + ", ");
            }   
            else
            {
                Console.Write(test[i] + "]");         
            }
        }
        
}

WriteArray(array);
Console.Write("\nКоличество элементов: " +count);